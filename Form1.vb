Imports System.Net
Imports Newtonsoft.Json
Imports System.IO.Compression
Imports Octokit
Public Class Form1
    Dim lethalpath As String
    Public modfolder As Boolean = False
    Dim pluginsfolder As String()
    Dim pluginsdirfolder As String()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("If you use the default location in steam and also installed lethal from steam, press enter 2 times.")
        Dim fbd As New FolderBrowserDialog
        fbd.SelectedPath = "C:\Program Files (x86)\Steam\steamapps\common\Lethal Company"
        If fbd.ShowDialog() = DialogResult.OK Then
            Dim folder As String = fbd.SelectedPath
            Dim found As Boolean = False
            If folder.Contains("Lethal Company") Then
                found = True
            Else
                MessageBox.Show("Please open a folder named 'Lethal Company' or use Diff open.")
            End If
            If found = True Then
                lethalpath = folder
                path.Text = "Path: " + lethalpath
                Button1.Enabled = False
                Button2.Enabled = False
                Dim files As String() = IO.Directory.GetFiles(folder)
                Dim filenames As String
                For Each filname In files
                    filenames = filenames + Struct.detectfile(filname, folder) + vbCrLf
                Next
                Dim filesok As Boolean = False
                If Struct.checkfiles(filenames) = False Then
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Exit Sub
                Else
                    filesok = True
                End If

                Dim folders As String() = IO.Directory.GetDirectories(folder)
                Dim foldnames As String
                For Each foldname In folders
                    foldnames = foldnames + Struct.detectfolder(foldname, folder) + vbCrLf
                Next
                Dim foldersok As Boolean = False
                If Struct.checkfolders(foldnames) = False Then
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Exit Sub
                Else
                    foldersok = True
                End If
                If modfolder = False Then
                    Button3.Enabled = True
                    Button3.Visible = True
                Else
                    Button4.Visible = True
                End If
                If filesok = True AndAlso foldersok = True Then
                    basegame.Checked = True
                End If
                Struct.bepinexdetect(filenames, foldnames)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Diff open is used if the folder name differs from the original.")
    End Sub

    Private Sub bepininstaller_Click(sender As Object, e As EventArgs) Handles bepininstaller.Click
        Dim client As New WebClient
        Dim url As String = "https://github.com/BepInEx/BepInEx/releases/download/v5.4.22/BepInEx_x64_5.4.22.0.zip"
        Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.InternetCache) + "\BepInEx_x64_5.4.22.0.zip"
        client.DownloadFile(url, filename)
        ZipFile.ExtractToDirectory(filename, lethalpath)
        Dim bepinpath As String = lethalpath + "\BepInEx"
        IO.Directory.CreateDirectory(bepinpath + "\plugins")
        IO.Directory.CreateDirectory(bepinpath + "\config")
        IO.Directory.CreateDirectory(bepinpath + "\patchers")
        MessageBox.Show("BepInEx has been installed.")
        IO.File.Delete(filename)
        bepininstaller.Enabled = False
        bepininstaller.Visible = False
        BepInExStatus.Checked = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim path As String = lethalpath + "\KYSModMan"
        IO.Directory.CreateDirectory(path)
        Button3.Enabled = False
        Button3.Visible = False
        Button4.Visible = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modsList.Items.Clear()
        Dim path As String = lethalpath + "\BepInEx\plugins"
        pluginsfolder = IO.Directory.GetFiles(path)
        For Each file In pluginsfolder
            file = file.Replace(path + "\", "")
            file = file.Replace(".dll", "")
            file = file.Trim
            modsList.Items.Add(file)
        Next
        pluginsdirfolder = IO.Directory.GetDirectories(path)
        For Each directory In pluginsdirfolder
            Dim topology As String() = IO.Directory.GetFiles(directory)
            Dim filelist As String
            For Each file In topology
                Dim filename As String = file
                filename = filename.Replace(path + "\", "")
                filename = filename.Trim
                filelist = filelist + filename + vbCrLf
                If file.EndsWith(".dll") Then
                    file = file.Replace(directory + "\", "")
                    file = file.Replace(".dll", "")
                    file = file.Trim
                    file = "*" + file
                    modsList.Items.Add(file)
                Else
                    Continue For
                End If
            Next
            Dim filelistarray As String()
            If filelist = Nothing Then
                Continue For
            Else
                filelistarray = filelist.Split(vbCrLf)
            End If
            Dim dllfound As Boolean = False
            For Each file In filelistarray
                If file.Contains(".dll") Then
                    dllfound = True
                End If
            Next
            If dllfound = False Then
                Dim dirname As String = directory
                dirname = directory.Replace(path + "\", "")
                Dim nodename As String = "?" + dirname
                If modsList.Items.Contains(nodename) = False Then
                    modsList.Items.Add(nodename)
                End If
            End If
        Next
    End Sub

    Private Sub modsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modsList.SelectedIndexChanged
        Button6.Enabled = True
        Button7.Enabled = True
        selected.Text = modsList.SelectedItem.ToString
        ' try to locate file
        Dim path As String = lethalpath + "\BepInEx\plugins"
        Dim found As Boolean = False
        For Each file In pluginsfolder
            Dim fileorig As String = file
            fileorig = fileorig.Replace(path, "")
            file = file.Replace(path + "\", "")
            file = file.Replace(".dll", "")
            file = file.Trim
            If file = modsList.SelectedItem.ToString Then
                fileloc.Text = "Loc: " + fileorig
                found = True
            End If
        Next
        If found = False Then
            For Each directory In pluginsdirfolder
                Dim topology As String() = IO.Directory.GetFiles(directory)
                For Each file In topology
                    Dim fileorig As String = file
                    fileorig = fileorig.Replace(path, "")
                    If file.EndsWith(".dll") Then
                        file = file.Replace(directory + "\", "")
                        file = file.Replace(".dll", "")
                        file = file.Trim
                        file = "*" + file
                        If file = modsList.SelectedItem.ToString Then
                            fileloc.Text = "Loc: " + fileorig
                            found = True
                        End If
                    Else
                        Continue For
                    End If
                Next
            Next
        End If
        If found = False Then
            Dim folder As String = selected.Text.Replace("?", "")
            folder = lethalpath + "\BepInEx\plugins\" + folder + "\"
            folder = folder.Replace(path, "")
            fileloc.Text = "Loc: " + folder
        End If
        If selected.Text.StartsWith("*") Then
            filetype.Text = "Type: Plugin in folder"
        ElseIf selected.Text.StartsWith("?") Then
            filetype.Text = "Type: Folder"
            Button7.Enabled = False
        Else
            filetype.Text = "Type: Plugin"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Dim folderfix As Boolean = False
        Dim nodllfix As Boolean = False
        If selected.Text.StartsWith("*") Then
            folderfix = True
        End If
        If selected.Text.StartsWith("?") Then
            nodllfix = True
        End If
        Dim path As String = lethalpath + "\BepInEx\plugins"
        If folderfix = False AndAlso nodllfix = False Then
            IO.File.Delete(path + "\" + selected.Text + ".dll")
            If IO.Directory.Exists(path + "\" + selected.Text) Then
                IO.Directory.Delete(path + "\" + selected.Text, True)
            End If
        ElseIf folderfix = True AndAlso nodllfix = False Then
            For Each directory In pluginsdirfolder
                Dim topology As String() = IO.Directory.GetFiles(directory)
                For Each file In topology
                    Dim fileorig As String = file
                    fileorig = fileorig.Replace(directory, "")
                    If file.EndsWith(".dll") Then
                        Dim found As Boolean = False
                        file = file.Replace(directory + "\", "")
                        file = file.Replace(".dll", "")
                        file = file.Trim
                        If "*" + file = modsList.SelectedItem.ToString Then
                            found = True
                        End If
                        If found = True Then
                            IO.Directory.Delete(directory, True)
                        End If
                    Else
                        Continue For
                    End If
                Next
            Next
        ElseIf folderfix = False AndAlso nodllfix = True Then
            Dim foldername As String = selected.Text.Replace("?", "")
            foldername = lethalpath + "\BepInEx\plugins\" + foldername
            IO.Directory.Delete(foldername, True)
        End If
        Button6.Enabled = True
        Button4.PerformClick()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Dim modmanpath = lethalpath + "\KYSModMan\Disabled\"
        Dim folderfix As Boolean = False
        Dim nodllfix As Boolean = False
        If selected.Text.StartsWith("*") Then
            folderfix = True
        End If
        If selected.Text.StartsWith("?") Then
            nodllfix = True
        End If
        Dim path As String = lethalpath + "\BepInEx\plugins"
        If folderfix = False AndAlso nodllfix = False Then
            IO.File.Move(path + "\" + selected.Text + ".dll", modmanpath + selected.Text + ".dll")
            If IO.Directory.Exists(path + "\" + selected.Text) Then
                IO.Directory.Move(path + "\" + selected.Text, modmanpath + selected.Text)
            End If
        ElseIf folderfix = True AndAlso nodllfix = False Then
            For Each directory In pluginsdirfolder
                Dim topology As String() = IO.Directory.GetFiles(directory)
                For Each file In topology
                    Dim fileorig As String = file
                    fileorig = fileorig.Replace(directory, "")
                    If file.EndsWith(".dll") Then
                        Dim found As Boolean = False
                        file = file.Replace(directory + "\", "")
                        file = file.Replace(".dll", "")
                        file = file.Trim
                        If "*" + file = modsList.SelectedItem.ToString Then
                            found = True
                        End If
                        If found = True Then
                            Dim foldername As String = directory.Replace(path, "")
                            IO.Directory.Move(directory, modmanpath + foldername)
                        End If
                    Else
                        Continue For
                    End If
                Next
            Next
        ElseIf folderfix = False AndAlso nodllfix = True Then
            MessageBox.Show("You can't disable folders without plugins.")
        End If
        Button7.Enabled = True
        Button4.PerformClick()
    End Sub
End Class

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
        MessageBox.Show("The original steam location will be used, you may have to click only ok.")
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
            For Each file In topology
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
        Next
    End Sub

    Private Sub modsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modsList.SelectedIndexChanged
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
    End Sub
End Class

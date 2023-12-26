Imports System.Net
Imports Newtonsoft.Json
Imports System.IO.Compression
Imports Octokit
Public Class Form1
    Dim lethalpath As String
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
                Dim modfolder As Boolean = False
                Dim folders As String() = IO.Directory.GetDirectories(folder)
                Dim foldnames As String
                For Each foldname In folders
                    foldnames = foldnames + Struct.detectfolder(foldname, folder) + vbCrLf
                Next
                Dim foldersok As Boolean = False
                If Struct.checkfolders(foldnames, modfolder) = False Then
                    Button1.Enabled = True
                    Button2.Enabled = True
                    Exit Sub
                Else
                    foldersok = True
                End If
                If modfolder = False Then
                    Button3.Enabled = True
                    Button3.Visible = True
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
        MessageBox.Show("BepInEx has been installed.")
        IO.File.Delete(filename)
        bepininstaller.Enabled = False
        bepininstaller.Visible = False
        BepInExStatus.Checked = True
    End Sub
End Class

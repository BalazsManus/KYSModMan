Public Class Form1
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
                path.Text = "Path: " + folder
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
End Class

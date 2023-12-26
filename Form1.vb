Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' folder select dialog
        Dim fbd As New FolderBrowserDialog
        ' start folder
        fbd.SelectedPath = "C:\Program Files (x86)\Steam\steamapps\common\Lethal Company"
        If fbd.ShowDialog() = DialogResult.OK Then
            Dim folder As String = fbd.SelectedPath
            Dim found As Boolean = False
            If folder.Contains("Lethal Company") Then
                found = True
            Else
                MessageBox.Show("Pls select Lethal Company named folder, if u don't hav it, then leav")
            End If
            If found = True Then
                Dim files As String() = IO.Directory.GetFiles(folder)
                Dim folders As String() = IO.Directory.GetDirectories(folder)
                Dim filepath As String = ""
                Dim bepin As Boolean = False
                For Each Dirc In folders
                    If Dirc.Contains("BepInEx") Then
                        bepin = True
                    End If
                    filepath = filepath + vbCrLf + Dirc.ToString
                Next
                For Each file As String In files
                    filepath = filepath + vbCrLf + file.ToString
                Next
                If bepin = True Then
                    BepInExStatus.Checked = True
                Else
                    BepInExStatus.Checked = False
                End If
            End If
        End If
    End Sub
End Class

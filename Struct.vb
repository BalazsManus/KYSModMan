Module Struct
    Public Function detectfolder(foldname As String, path As String)
        ' remove path from string
        foldname = foldname.Replace(path + "\", "")
        If foldname = "BepInEx" Then
            Return "BepInEx"
        ElseIf foldname = "Lethal Company_Data" Then
            Return "Unity Data Folder"
        ElseIf foldname = "MonoBleedingEdge" Then
            Return "Mono Runtime"
        End If
    End Function
    Public Function detectfile(filname As String, path As String)
        ' remove path from string
        filname = filname.Replace(path + "\", "")
        If filname = "doorstop_config.ini" Then
            Return "Unity Doorstop"
        ElseIf filname = "Lethal Company.exe" Then
            Return "Lethal Company Executable"
        ElseIf filname = "nvngx_dlss.dll" Then
            Return "Nvidia DLSS"
        ElseIf filname = "NVUnityPlugin.dll" Then
            Return "Nvidia Native module Loader"
        ElseIf filname = "UnityCrashHandler64.exe" Then
            Return "Unity Crash Handler"
        ElseIf filname = "UnityPlayer.dll" Then
            Return "Unity Playback Engine"
        ElseIf filname = "winhttp.dll" Then
            Return "Unity Doorstop DLL Proxy"
        Else
            Return "Unknown"
        End If
    End Function
    Public Function checkfiles(filenames As String)
        ' convert string to array
        Dim filenamesarray As String() = filenames.Split(vbCrLf)
        Dim lethal As Boolean = False
        Dim dlss As Boolean = False
        Dim nvunity As Boolean = False
        Dim crashhandler As Boolean = False
        Dim playback As Boolean = False
        For Each filename In filenamesarray
            ' remove whitespace
            ' i hate it whem array is buggy as hell
            filename = filename.Replace(vbCrLf, "")
            filename = filename.Trim()
            filename = filename.TrimStart()
            filename = filename.TrimEnd()
            ' filename = filename.Busscut()
            If filename = "Lethal Company Executable" Then
                lethal = True
            ElseIf filename = "Nvidia DLSS" Then
                dlss = True
            ElseIf filename = "Nvidia Native module Loader" Then
                nvunity = True
            ElseIf filename = "Unity Crash Handler" Then
                crashhandler = True
            ElseIf filename = "Unity Playback Engine" Then
                playback = True
            End If
        Next
        If lethal = True AndAlso dlss = True AndAlso nvunity = True AndAlso crashhandler = True AndAlso playback = True Then
            Return True
        Else
            Form1.Button1.Enabled = True
            Form1.Button2.Enabled = True
            MessageBox.Show("Couldn't find the base game files, did you select the right folder?")
            Return False
        End If
    End Function
    Public Function bepinexdetect(filenames As String, foldernames As String)
        Dim doorstop As Boolean = False
        Dim doorstopproxy As Boolean = False
        Dim bepinex As Boolean = False
        Dim filenamesarray As String() = filenames.Split(vbCrLf)
        For Each filename In filenamesarray
            filename = filename.Replace(vbCrLf, "")
            filename = filename.Trim()
            filename = filename.TrimStart()
            filename = filename.TrimEnd()
            If filename = "Unity Doorstop" Then
                doorstop = True
            End If
            If filename = "Unity Doorstop DLL Proxy" Then
                doorstopproxy = True
            End If
        Next
        Dim foldernamesarray As String() = foldernames.Split(vbCrLf)
        For Each foldername In foldernamesarray
            foldername = foldername.Replace(vbCrLf, "")
            foldername = foldername.Trim()
            foldername = foldername.TrimStart()
            foldername = foldername.TrimEnd()
            If foldername = "BepInEx" Then
                bepinex = True
            End If
        Next
        If doorstop = True AndAlso doorstopproxy = True AndAlso bepinex = True Then
            Form1.BepInExStatus.Checked = True
        Else
            Form1.bepininstaller.Visible = True
            Form1.bepininstaller.Enabled = True
        End If
    End Function
    Public Function checkfolders(foldernames As String)
        ' convert string to array
        Dim foldernamesarray As String() = foldernames.Split(vbCrLf)
        Dim data As Boolean = False
        Dim mono As Boolean = False
        For Each foldername In foldernamesarray
            ' remove whitespace
            ' i hate it whem array is buggy as hell
            foldername = foldername.Replace(vbCrLf, "")
            foldername = foldername.Trim()
            foldername = foldername.TrimStart()
            foldername = foldername.TrimEnd()
            ' filename = filename.Busscut()
            If foldername = "Unity Data Folder" Then
                data = True
            ElseIf foldername = "Mono Runtime" Then
                mono = True
            End If
        Next
        If data = True AndAlso mono = True Then
            Return True
        Else
            Form1.Button1.Enabled = True
            Form1.Button2.Enabled = True
            MessageBox.Show("Couldn't find the base game folders, did you select the right folder?")
            Return False
        End If
    End Function
End Module

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Button1 = New Button()
        Label1 = New Label()
        BepInExStatus = New CheckBox()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        Label3 = New Label()
        Label4 = New Label()
        Button2 = New Button()
        path = New Label()
        bepininstaller = New Button()
        basegame = New CheckBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 25)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 23)
        Button1.TabIndex = 0
        Button1.Text = "Open"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(186, 13)
        Label1.TabIndex = 1
        Label1.Text = "Step 1: open ""Lethal Company"" folder"
        ' 
        ' BepInExStatus
        ' 
        BepInExStatus.AutoSize = True
        BepInExStatus.Enabled = False
        BepInExStatus.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        BepInExStatus.Location = New Point(672, 6)
        BepInExStatus.Name = "BepInExStatus"
        BepInExStatus.Size = New Size(117, 20)
        BepInExStatus.TabIndex = 3
        BepInExStatus.Text = "BepInEx Status"
        BepInExStatus.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 428)
        Label2.Name = "Label2"
        Label2.Size = New Size(103, 13)
        Label2.TabIndex = 4
        Label2.Text = "Made specifically for"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2023_12_25_182152
        PictureBox1.Location = New Point(121, 378)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(196, 72)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(323, 428)
        Label3.Name = "Label3"
        Label3.Size = New Size(214, 13)
        Label3.TabIndex = 6
        Label3.Text = "and other ppl who can't find a fucking folder"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(196, 388)
        Label4.Name = "Label4"
        Label4.Size = New Size(44, 13)
        Label4.TabIndex = 7
        Label4.Text = "(Nigger)"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(121, 25)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 23)
        Button2.TabIndex = 8
        Button2.Text = "Diff open"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' path
        ' 
        path.AutoSize = True
        path.Location = New Point(12, 51)
        path.Name = "path"
        path.Size = New Size(55, 13)
        path.TabIndex = 9
        path.Text = "Path: N/A"
        ' 
        ' bepininstaller
        ' 
        bepininstaller.Enabled = False
        bepininstaller.Location = New Point(672, 25)
        bepininstaller.Name = "bepininstaller"
        bepininstaller.Size = New Size(116, 23)
        bepininstaller.TabIndex = 10
        bepininstaller.Text = "Install BepInEx"
        bepininstaller.UseVisualStyleBackColor = True
        bepininstaller.Visible = False
        ' 
        ' basegame
        ' 
        basegame.AutoSize = True
        basegame.Enabled = False
        basegame.Font = New Font("Microsoft Sans Serif", 9.75F)
        basegame.Location = New Point(550, 6)
        basegame.Name = "basegame"
        basegame.Size = New Size(99, 20)
        basegame.TabIndex = 11
        basegame.Text = "Base Game"
        basegame.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 13F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(basegame)
        Controls.Add(bepininstaller)
        Controls.Add(path)
        Controls.Add(Button2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Label2)
        Controls.Add(BepInExStatus)
        Controls.Add(Label1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "Form1"
        Text = "Simple lethal mod manager"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BepInExStatus As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents path As Label
    Friend WithEvents bepininstaller As Button
    Friend WithEvents basegame As CheckBox
End Class

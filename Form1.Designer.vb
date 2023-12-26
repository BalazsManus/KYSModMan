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
        Panel1 = New Panel()
        Panel2 = New Panel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.System
        Button1.Location = New Point(12, 29)
        Button1.Name = "Button1"
        Button1.Size = New Size(103, 27)
        Button1.TabIndex = 0
        Button1.Text = "Open"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(223, 15)
        Label1.TabIndex = 1
        Label1.Text = "Step 1: open ""Lethal Company"" folder"
        ' 
        ' BepInExStatus
        ' 
        BepInExStatus.AutoSize = True
        BepInExStatus.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        BepInExStatus.Enabled = False
        BepInExStatus.Font = New Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        BepInExStatus.ForeColor = Color.Black
        BepInExStatus.Location = New Point(135, 3)
        BepInExStatus.Name = "BepInExStatus"
        BepInExStatus.Size = New Size(117, 20)
        BepInExStatus.TabIndex = 3
        BepInExStatus.Text = "BepInEx Status"
        BepInExStatus.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Label2.ForeColor = Color.Lime
        Label2.Location = New Point(3, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(133, 15)
        Label2.TabIndex = 4
        Label2.Text = "Made specifically for"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.Screenshot_2023_12_25_182152
        PictureBox1.Location = New Point(133, -2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(196, 83)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Label3.ForeColor = Color.Lime
        Label3.Location = New Point(232, 59)
        Label3.Name = "Label3"
        Label3.Size = New Size(277, 15)
        Label3.TabIndex = 6
        Label3.Text = "and other ppl who can't find a fucking folder"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        Label4.ForeColor = Color.Lime
        Label4.Location = New Point(199, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(55, 15)
        Label4.TabIndex = 7
        Label4.Text = "(Nigger)"
        ' 
        ' Button2
        ' 
        Button2.FlatStyle = FlatStyle.System
        Button2.Location = New Point(121, 29)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 27)
        Button2.TabIndex = 8
        Button2.Text = "Diff open"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' path
        ' 
        path.AutoSize = True
        path.Location = New Point(12, 59)
        path.Name = "path"
        path.Size = New Size(61, 15)
        path.TabIndex = 9
        path.Text = "Path: N/A"
        ' 
        ' bepininstaller
        ' 
        bepininstaller.Enabled = False
        bepininstaller.FlatStyle = FlatStyle.System
        bepininstaller.Location = New Point(135, 29)
        bepininstaller.Name = "bepininstaller"
        bepininstaller.Size = New Size(116, 27)
        bepininstaller.TabIndex = 10
        bepininstaller.Text = "Install BepInEx"
        bepininstaller.UseVisualStyleBackColor = True
        bepininstaller.Visible = False
        ' 
        ' basegame
        ' 
        basegame.AutoSize = True
        basegame.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        basegame.Enabled = False
        basegame.Font = New Font("Microsoft Sans Serif", 9.75F)
        basegame.ForeColor = Color.Black
        basegame.Location = New Point(3, 3)
        basegame.Name = "basegame"
        basegame.Size = New Size(99, 20)
        basegame.TabIndex = 11
        basegame.Text = "Base Game"
        basegame.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Black
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 435)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 84)
        Panel1.TabIndex = 12
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        Panel2.BorderStyle = BorderStyle.Fixed3D
        Panel2.Controls.Add(basegame)
        Panel2.Controls.Add(BepInExStatus)
        Panel2.Controls.Add(bepininstaller)
        Panel2.ForeColor = Color.Black
        Panel2.Location = New Point(545, 10)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(255, 61)
        Panel2.TabIndex = 13
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(6F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        ClientSize = New Size(800, 519)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(path)
        Controls.Add(Button2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        DoubleBuffered = True
        Font = New Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(238))
        ForeColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        ShowIcon = False
        SizeGripStyle = SizeGripStyle.Hide
        Text = "KYSModMan: Simple Lethal Mod Manager"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class

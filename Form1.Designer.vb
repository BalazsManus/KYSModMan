<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BepInExStatus = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.path = New System.Windows.Forms.Label()
        Me.bepininstaller = New System.Windows.Forms.Button()
        Me.basegame = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.modsList = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.filetype = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.fileloc = New System.Windows.Forms.Label()
        Me.selected = New System.Windows.Forms.Label()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.disabledstatus = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(12, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Open"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Directory Management" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BepInExStatus
        '
        Me.BepInExStatus.AutoSize = True
        Me.BepInExStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BepInExStatus.Enabled = False
        Me.BepInExStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.BepInExStatus.ForeColor = System.Drawing.Color.Black
        Me.BepInExStatus.Location = New System.Drawing.Point(135, 3)
        Me.BepInExStatus.Name = "BepInExStatus"
        Me.BepInExStatus.Size = New System.Drawing.Size(116, 20)
        Me.BepInExStatus.TabIndex = 3
        Me.BepInExStatus.Text = "BepInEx Status"
        Me.BepInExStatus.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cascadia Code", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(3, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Made specifically for"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cascadia Code", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(232, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "and other ppl who can't find a fucking folder"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cascadia Code", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(199, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "← (Nigger)"
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(121, 29)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 27)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Diff open"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'path
        '
        Me.path.AutoSize = True
        Me.path.Location = New System.Drawing.Point(12, 59)
        Me.path.Name = "path"
        Me.path.Size = New System.Drawing.Size(61, 15)
        Me.path.TabIndex = 9
        Me.path.Text = "Path: N/A"
        '
        'bepininstaller
        '
        Me.bepininstaller.Enabled = False
        Me.bepininstaller.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bepininstaller.Location = New System.Drawing.Point(132, 27)
        Me.bepininstaller.Name = "bepininstaller"
        Me.bepininstaller.Size = New System.Drawing.Size(116, 27)
        Me.bepininstaller.TabIndex = 10
        Me.bepininstaller.Text = "Install BepInEx"
        Me.bepininstaller.UseVisualStyleBackColor = True
        Me.bepininstaller.Visible = False
        '
        'basegame
        '
        Me.basegame.AutoSize = True
        Me.basegame.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.basegame.Enabled = False
        Me.basegame.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.basegame.ForeColor = System.Drawing.Color.Black
        Me.basegame.Location = New System.Drawing.Point(3, 3)
        Me.basegame.Name = "basegame"
        Me.basegame.Size = New System.Drawing.Size(98, 20)
        Me.basegame.TabIndex = 11
        Me.basegame.Text = "Base Game"
        Me.basegame.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(37, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 435)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 84)
        Me.Panel1.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(118, 10)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "→"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.KYSModMan.My.Resources.Resources.dfyz0yj_fd9b7f1a_4bec_40ea_a100_2470245723f4
        Me.PictureBox2.Location = New System.Drawing.Point(59, 3)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 15
        Me.PictureBox2.TabStop = False
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(515, 6)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(273, 23)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Relocate mods"
        Me.Button4.UseVisualStyleBackColor = True
        Me.Button4.Visible = False
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Font = New System.Drawing.Font("Cascadia Code", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Button3.Location = New System.Drawing.Point(515, 31)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(273, 43)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Install Modman"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.KYSModMan.My.Resources.Resources.Screenshot_2023_12_25_182152
        Me.PictureBox1.Location = New System.Drawing.Point(133, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 83)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.basegame)
        Me.Panel2.Controls.Add(Me.BepInExStatus)
        Me.Panel2.Controls.Add(Me.bepininstaller)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(545, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 61)
        Me.Panel2.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Black
        Me.GroupBox1.Controls.Add(Me.modsList)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Lime
        Me.GroupBox1.Location = New System.Drawing.Point(12, 77)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(608, 352)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mods"
        '
        'modsList
        '
        Me.modsList.BackColor = System.Drawing.Color.Black
        Me.modsList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.modsList.ForeColor = System.Drawing.Color.Lime
        Me.modsList.FormattingEnabled = True
        Me.modsList.ItemHeight = 15
        Me.modsList.Location = New System.Drawing.Point(6, 19)
        Me.modsList.Name = "modsList"
        Me.modsList.Size = New System.Drawing.Size(449, 330)
        Me.modsList.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.disabledstatus)
        Me.Panel3.Controls.Add(Me.Button8)
        Me.Panel3.Controls.Add(Me.filetype)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Button7)
        Me.Panel3.Controls.Add(Me.Button6)
        Me.Panel3.Controls.Add(Me.fileloc)
        Me.Panel3.Controls.Add(Me.selected)
        Me.Panel3.Location = New System.Drawing.Point(473, 115)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(315, 272)
        Me.Panel3.TabIndex = 1
        '
        'filetype
        '
        Me.filetype.AutoSize = True
        Me.filetype.Location = New System.Drawing.Point(25, 121)
        Me.filetype.Name = "filetype"
        Me.filetype.Size = New System.Drawing.Size(61, 15)
        Me.filetype.TabIndex = 5
        Me.filetype.Text = "Type: N/A"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(3, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 15)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Kill Yourself Mod Manager"
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button7.Location = New System.Drawing.Point(3, 227)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(170, 23)
        Me.Button7.TabIndex = 3
        Me.Button7.Text = "Disable"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button6.Location = New System.Drawing.Point(174, 227)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(134, 23)
        Me.Button6.TabIndex = 2
        Me.Button6.Text = "Delete (Permanent)"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'fileloc
        '
        Me.fileloc.Location = New System.Drawing.Point(25, 57)
        Me.fileloc.Name = "fileloc"
        Me.fileloc.Size = New System.Drawing.Size(283, 64)
        Me.fileloc.TabIndex = 1
        Me.fileloc.Text = "Loc: N/A"
        '
        'selected
        '
        Me.selected.Location = New System.Drawing.Point(3, 0)
        Me.selected.Name = "selected"
        Me.selected.Size = New System.Drawing.Size(305, 57)
        Me.selected.TabIndex = 0
        Me.selected.Text = "Select an item"
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button5.Location = New System.Drawing.Point(626, 86)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(162, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "Install Mod (.zip)"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Gray
        Me.Label6.Location = New System.Drawing.Point(626, 387)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 45)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Please don't microwave ur" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "HDD or any% other crap u" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "use"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(424, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 30)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "God forgive me for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "this UI"
        '
        'Button8
        '
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button8.Location = New System.Drawing.Point(3, 198)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(75, 23)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "Enable"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'disabledstatus
        '
        Me.disabledstatus.AutoSize = True
        Me.disabledstatus.Location = New System.Drawing.Point(25, 145)
        Me.disabledstatus.Name = "disabledstatus"
        Me.disabledstatus.Size = New System.Drawing.Size(85, 15)
        Me.disabledstatus.TabIndex = 7
        Me.disabledstatus.Text = "Disabled: N/A"
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.path)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Cascadia Code", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "KYSModMan: Simple Lethal Mod Manager"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents modsList As ListBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents selected As Label
    Friend WithEvents fileloc As Label
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents filetype As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents disabledstatus As Label
End Class

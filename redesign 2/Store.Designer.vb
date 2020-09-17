<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStore
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStore))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBSoftware = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveList = New System.Windows.Forms.Button()
        Me.btnClearList = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lbHost = New System.Windows.Forms.ListBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.BW1 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.txtFile = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnInstall)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Location = New System.Drawing.Point(589, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 108)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 3. Start Install"
        '
        'btnInstall
        '
        Me.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstall.Image = Global.redesign_2.My.Resources.Resources.install1
        Me.btnInstall.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnInstall.Location = New System.Drawing.Point(17, 19)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(75, 75)
        Me.btnInstall.TabIndex = 4
        Me.btnInstall.Text = "Submit [F1]"
        Me.btnInstall.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBSoftware)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(421, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(158, 331)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 2. Select Software"
        '
        'LBSoftware
        '
        Me.LBSoftware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBSoftware.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSoftware.FormattingEnabled = True
        Me.LBSoftware.ItemHeight = 16
        Me.LBSoftware.Items.AddRange(New Object() {"Adobe Flash", "Adobe Reader XI", "Cisco Softphone", "Cisco VPN", "Copy E-Sig Files", "CutePDF Writer", "Dameware Update", "IE8 Setup", "Java Install", "LightShot ScreenShot", "MB Applications", "MB Calculator Setup", "McAfee", "MS Office 2010 Std", "MS Office 2013 Std", "MS Office Lync 2010", "MS Office Lync 2013", "MS SQL Management Studio", ".Net 4 Install", ".Net 4.5 Install", "OpenOffice", "Ordo", "Update Visionx Files", "UltraVNC ", "WUMO (Updated)", "XenApp"})
        Me.LBSoftware.Location = New System.Drawing.Point(4, 19)
        Me.LBSoftware.Name = "LBSoftware"
        Me.LBSoftware.Size = New System.Drawing.Size(154, 306)
        Me.LBSoftware.TabIndex = 11
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSaveList)
        Me.GroupBox1.Controls.Add(Me.btnClearList)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnTransfer)
        Me.GroupBox1.Controls.Add(Me.lbHost)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 331)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1. Enter WSTN's"
        '
        'btnSaveList
        '
        Me.btnSaveList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveList.ForeColor = System.Drawing.Color.Yellow
        Me.btnSaveList.Location = New System.Drawing.Point(178, 133)
        Me.btnSaveList.Name = "btnSaveList"
        Me.btnSaveList.Size = New System.Drawing.Size(55, 60)
        Me.btnSaveList.TabIndex = 8
        Me.btnSaveList.Text = "Save"
        Me.btnSaveList.UseVisualStyleBackColor = True
        '
        'btnClearList
        '
        Me.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearList.ForeColor = System.Drawing.Color.Yellow
        Me.btnClearList.Location = New System.Drawing.Point(177, 199)
        Me.btnClearList.Name = "btnClearList"
        Me.btnClearList.Size = New System.Drawing.Size(56, 61)
        Me.btnClearList.TabIndex = 7
        Me.btnClearList.Text = "Clear List"
        Me.btnClearList.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(403, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 403)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Select Software"
        '
        'btnTransfer
        '
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.ForeColor = System.Drawing.Color.Yellow
        Me.btnTransfer.Location = New System.Drawing.Point(177, 64)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(56, 63)
        Me.btnTransfer.TabIndex = 1
        Me.btnTransfer.Text = ">>>>"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lbHost
        '
        Me.lbHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHost.FormattingEnabled = True
        Me.lbHost.ItemHeight = 15
        Me.lbHost.Location = New System.Drawing.Point(239, 19)
        Me.lbHost.Name = "lbHost"
        Me.lbHost.Size = New System.Drawing.Size(152, 304)
        Me.lbHost.TabIndex = 3
        '
        'txtHost
        '
        Me.txtHost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.Location = New System.Drawing.Point(14, 24)
        Me.txtHost.Multiline = True
        Me.txtHost.Name = "txtHost"
        Me.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHost.Size = New System.Drawing.Size(158, 299)
        Me.txtHost.TabIndex = 0
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(22, 355)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Load Saved File"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtFile
        '
        Me.txtFile.Location = New System.Drawing.Point(112, 352)
        Me.txtFile.Name = "txtFile"
        Me.txtFile.Size = New System.Drawing.Size(297, 20)
        Me.txtFile.TabIndex = 12
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(415, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.ForeColor = System.Drawing.Color.Yellow
        Me.btnExit.Location = New System.Drawing.Point(626, 350)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Exit [ESC]"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'frmStore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(715, 385)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtFile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmStore"
        Me.Text = "Store Software Install"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents lbHost As System.Windows.Forms.ListBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents BW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LBSoftware As System.Windows.Forms.ListBox
    Friend WithEvents btnClearList As System.Windows.Forms.Button
    Friend WithEvents btnSaveList As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents txtFile As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftware
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSoftware))
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.lbHost = New System.Windows.Forms.ListBox()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LBSoftware = New System.Windows.Forms.ListBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.BW1 = New System.ComponentModel.BackgroundWorker()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.ScrollableControl1 = New System.Windows.Forms.ScrollableControl()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtHost
        '
        Me.txtHost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.Location = New System.Drawing.Point(13, 15)
        Me.txtHost.Multiline = True
        Me.txtHost.Name = "txtHost"
        Me.txtHost.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtHost.Size = New System.Drawing.Size(158, 334)
        Me.txtHost.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.btnTransfer)
        Me.GroupBox1.Controls.Add(Me.lbHost)
        Me.GroupBox1.Controls.Add(Me.txtHost)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(8, 17)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(397, 353)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Step 1. Enter WSTN's"
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
        Me.btnTransfer.Location = New System.Drawing.Point(177, 177)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(41, 63)
        Me.btnTransfer.TabIndex = 1
        Me.btnTransfer.Text = ">>>>"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'lbHost
        '
        Me.lbHost.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHost.FormattingEnabled = True
        Me.lbHost.ItemHeight = 15
        Me.lbHost.Location = New System.Drawing.Point(224, 15)
        Me.lbHost.Name = "lbHost"
        Me.lbHost.Size = New System.Drawing.Size(148, 334)
        Me.lbHost.TabIndex = 3
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LBSoftware)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox3.Location = New System.Drawing.Point(417, 17)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 353)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Step 2. Select Software"
        '
        'LBSoftware
        '
        Me.LBSoftware.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBSoftware.FormattingEnabled = True
        Me.LBSoftware.ItemHeight = 19
        Me.LBSoftware.Items.AddRange(New Object() {"Cisco Softphone", "Cisco VPN", "McAfee Antivirus", "MS Office 2013", "Adobe Reader XI", "Java Install", "Firefox", "Chrome", ".Net Install 4", ".Net Install 4.5", "Adobe Flash", "Lync 2013", "CutePDF Writer", "UltraVNC", "Dameware Update", "NICE Reporter/Player"})
        Me.LBSoftware.Location = New System.Drawing.Point(0, 15)
        Me.LBSoftware.Name = "LBSoftware"
        Me.LBSoftware.Size = New System.Drawing.Size(155, 327)
        Me.LBSoftware.TabIndex = 8
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnInstall)
        Me.GroupBox4.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox4.Location = New System.Drawing.Point(584, 17)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(112, 106)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Step 3. Start Install"
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(621, 352)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "Exit [ESC]"
        Me.btnExit.UseVisualStyleBackColor = True
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
        'ScrollableControl1
        '
        Me.ScrollableControl1.Location = New System.Drawing.Point(601, 217)
        Me.ScrollableControl1.Name = "ScrollableControl1"
        Me.ScrollableControl1.Size = New System.Drawing.Size(75, 23)
        Me.ScrollableControl1.TabIndex = 9
        Me.ScrollableControl1.Text = "hi"
        '
        'frmSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.ClientSize = New System.Drawing.Size(705, 387)
        Me.Controls.Add(Me.ScrollableControl1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmSoftware"
        Me.Text = "Corporate Software Installation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents lbHost As System.Windows.Forms.ListBox
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents BW1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents LBSoftware As System.Windows.Forms.ListBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents ScrollableControl1 As System.Windows.Forms.ScrollableControl
End Class

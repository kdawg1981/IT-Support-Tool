<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Forms_Print
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
        Me.lbHost = New System.Windows.Forms.ListBox()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.btn_Close = New System.Windows.Forms.Button()
        Me.txt_Name = New System.Windows.Forms.TextBox()
        Me.txt_IP = New System.Windows.Forms.TextBox()
        Me.rdoFPN = New System.Windows.Forms.RadioButton()
        Me.rdoRPN = New System.Windows.Forms.RadioButton()
        Me.chkWin7 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'lbHost
        '
        Me.lbHost.FormattingEnabled = True
        Me.lbHost.Location = New System.Drawing.Point(226, 24)
        Me.lbHost.Name = "lbHost"
        Me.lbHost.Size = New System.Drawing.Size(176, 225)
        Me.lbHost.TabIndex = 3
        '
        'btnInstall
        '
        Me.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInstall.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInstall.ForeColor = System.Drawing.Color.Yellow
        Me.btnInstall.Location = New System.Drawing.Point(275, 284)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(75, 23)
        Me.btnInstall.TabIndex = 7
        Me.btnInstall.Text = "INSTALL"
        Me.btnInstall.UseVisualStyleBackColor = True
        '
        'btnMove
        '
        Me.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMove.ForeColor = System.Drawing.Color.Yellow
        Me.btnMove.Location = New System.Drawing.Point(173, 80)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(47, 99)
        Me.btnMove.TabIndex = 2
        Me.btnMove.Text = ">>>>"
        Me.btnMove.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(12, 254)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "IP Address"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(12, 284)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Printer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(60, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "SELECT PC'S"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Yellow
        Me.Label4.Location = New System.Drawing.Point(282, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "PC'S TO INSTALL"
        '
        'txtHost
        '
        Me.txtHost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHost.Location = New System.Drawing.Point(25, 24)
        Me.txtHost.Multiline = True
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(142, 222)
        Me.txtHost.TabIndex = 1
        '
        'btn_Close
        '
        Me.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Close.ForeColor = System.Drawing.Color.Yellow
        Me.btn_Close.Location = New System.Drawing.Point(357, 284)
        Me.btn_Close.Name = "btn_Close"
        Me.btn_Close.Size = New System.Drawing.Size(45, 23)
        Me.btn_Close.TabIndex = 8
        Me.btn_Close.Text = "Close"
        Me.btn_Close.UseVisualStyleBackColor = True
        '
        'txt_Name
        '
        Me.txt_Name.Location = New System.Drawing.Point(87, 280)
        Me.txt_Name.Name = "txt_Name"
        Me.txt_Name.Size = New System.Drawing.Size(100, 20)
        Me.txt_Name.TabIndex = 5
        '
        'txt_IP
        '
        Me.txt_IP.Location = New System.Drawing.Point(87, 254)
        Me.txt_IP.Name = "txt_IP"
        Me.txt_IP.Size = New System.Drawing.Size(100, 20)
        Me.txt_IP.TabIndex = 4
        '
        'rdoFPN
        '
        Me.rdoFPN.AutoSize = True
        Me.rdoFPN.ForeColor = System.Drawing.Color.Yellow
        Me.rdoFPN.Location = New System.Drawing.Point(304, 257)
        Me.rdoFPN.Name = "rdoFPN"
        Me.rdoFPN.Size = New System.Drawing.Size(46, 17)
        Me.rdoFPN.TabIndex = 12
        Me.rdoFPN.TabStop = True
        Me.rdoFPN.Text = "FPN"
        Me.rdoFPN.UseVisualStyleBackColor = True
        '
        'rdoRPN
        '
        Me.rdoRPN.AutoSize = True
        Me.rdoRPN.ForeColor = System.Drawing.Color.Yellow
        Me.rdoRPN.Location = New System.Drawing.Point(356, 257)
        Me.rdoRPN.Name = "rdoRPN"
        Me.rdoRPN.Size = New System.Drawing.Size(48, 17)
        Me.rdoRPN.TabIndex = 13
        Me.rdoRPN.TabStop = True
        Me.rdoRPN.Text = "RPN"
        Me.rdoRPN.UseVisualStyleBackColor = True
        '
        'chkWin7
        '
        Me.chkWin7.AutoSize = True
        Me.chkWin7.ForeColor = System.Drawing.Color.Yellow
        Me.chkWin7.Location = New System.Drawing.Point(226, 257)
        Me.chkWin7.Name = "chkWin7"
        Me.chkWin7.Size = New System.Drawing.Size(74, 17)
        Me.chkWin7.TabIndex = 14
        Me.chkWin7.Text = "Win 7 x64"
        Me.chkWin7.UseVisualStyleBackColor = True
        '
        'New_Forms_Print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(414, 312)
        Me.Controls.Add(Me.chkWin7)
        Me.Controls.Add(Me.rdoRPN)
        Me.Controls.Add(Me.rdoFPN)
        Me.Controls.Add(Me.txt_IP)
        Me.Controls.Add(Me.txt_Name)
        Me.Controls.Add(Me.btn_Close)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.lbHost)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.Name = "New_Forms_Print"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Network Printer Install"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbHost As System.Windows.Forms.ListBox
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnMove As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents btn_Close As System.Windows.Forms.Button
    Friend WithEvents txt_Name As System.Windows.Forms.TextBox
    Friend WithEvents txt_IP As System.Windows.Forms.TextBox
    Friend WithEvents rdoFPN As System.Windows.Forms.RadioButton
    Friend WithEvents rdoRPN As System.Windows.Forms.RadioButton
    Friend WithEvents chkWin7 As System.Windows.Forms.CheckBox
End Class

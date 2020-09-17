<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class New_Autologon
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
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.lbPCName = New System.Windows.Forms.ListBox()
        Me.btnTransfer = New System.Windows.Forms.Button()
        Me.chkWin7 = New System.Windows.Forms.CheckBox()
        Me.btnEnable = New System.Windows.Forms.Button()
        Me.btnDisable = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPC
        '
        Me.txtPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPC.Location = New System.Drawing.Point(12, 23)
        Me.txtPC.Multiline = True
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(133, 213)
        Me.txtPC.TabIndex = 0
        '
        'lbPCName
        '
        Me.lbPCName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPCName.FormattingEnabled = True
        Me.lbPCName.Location = New System.Drawing.Point(222, 23)
        Me.lbPCName.Name = "lbPCName"
        Me.lbPCName.Size = New System.Drawing.Size(120, 212)
        Me.lbPCName.TabIndex = 1
        '
        'btnTransfer
        '
        Me.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTransfer.ForeColor = System.Drawing.Color.Yellow
        Me.btnTransfer.Location = New System.Drawing.Point(151, 76)
        Me.btnTransfer.Name = "btnTransfer"
        Me.btnTransfer.Size = New System.Drawing.Size(65, 98)
        Me.btnTransfer.TabIndex = 2
        Me.btnTransfer.Text = ">>>>>"
        Me.btnTransfer.UseVisualStyleBackColor = True
        '
        'chkWin7
        '
        Me.chkWin7.AutoSize = True
        Me.chkWin7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkWin7.ForeColor = System.Drawing.Color.Yellow
        Me.chkWin7.Location = New System.Drawing.Point(12, 242)
        Me.chkWin7.Name = "chkWin7"
        Me.chkWin7.Size = New System.Drawing.Size(93, 17)
        Me.chkWin7.TabIndex = 3
        Me.chkWin7.Text = "Windows 7 PC"
        Me.chkWin7.UseVisualStyleBackColor = True
        '
        'btnEnable
        '
        Me.btnEnable.Enabled = False
        Me.btnEnable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnable.ForeColor = System.Drawing.Color.Yellow
        Me.btnEnable.Location = New System.Drawing.Point(205, 241)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.Size = New System.Drawing.Size(75, 23)
        Me.btnEnable.TabIndex = 4
        Me.btnEnable.Text = "Enable"
        Me.btnEnable.UseVisualStyleBackColor = True
        '
        'btnDisable
        '
        Me.btnDisable.Enabled = False
        Me.btnDisable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDisable.ForeColor = System.Drawing.Color.Yellow
        Me.btnDisable.Location = New System.Drawing.Point(286, 242)
        Me.btnDisable.Name = "btnDisable"
        Me.btnDisable.Size = New System.Drawing.Size(75, 23)
        Me.btnDisable.TabIndex = 5
        Me.btnDisable.Text = "Disable"
        Me.btnDisable.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(54, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Enter PCs"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(229, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Enable/Disable PC's"
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Yellow
        Me.Button4.Location = New System.Drawing.Point(356, 4)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(15, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "X"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'New_Autologon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(374, 274)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisable)
        Me.Controls.Add(Me.btnEnable)
        Me.Controls.Add(Me.chkWin7)
        Me.Controls.Add(Me.btnTransfer)
        Me.Controls.Add(Me.lbPCName)
        Me.Controls.Add(Me.txtPC)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "New_Autologon"
        Me.Text = "Store Autologon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents lbPCName As System.Windows.Forms.ListBox
    Friend WithEvents btnTransfer As System.Windows.Forms.Button
    Friend WithEvents chkWin7 As System.Windows.Forms.CheckBox
    Friend WithEvents btnEnable As System.Windows.Forms.Button
    Friend WithEvents btnDisable As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class

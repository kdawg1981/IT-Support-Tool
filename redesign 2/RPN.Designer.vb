<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RPN
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
        Me.txtPrintName = New System.Windows.Forms.TextBox()
        Me.txtPrintIP = New System.Windows.Forms.TextBox()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPrintName
        '
        Me.txtPrintName.Location = New System.Drawing.Point(83, 64)
        Me.txtPrintName.Name = "txtPrintName"
        Me.txtPrintName.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintName.TabIndex = 12
        '
        'txtPrintIP
        '
        Me.txtPrintIP.Location = New System.Drawing.Point(83, 38)
        Me.txtPrintIP.Name = "txtPrintIP"
        Me.txtPrintIP.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintIP.TabIndex = 10
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(83, 12)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 20)
        Me.txtHost.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Printer Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Printer IP"
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(9, 15)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(44, 13)
        Me.lblHost.TabIndex = 7
        Me.lblHost.Text = "Host/IP"
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(61, 90)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 13
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'RPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(199, 125)
        Me.Controls.Add(Me.txtPrintName)
        Me.Controls.Add(Me.txtPrintIP)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "RPN"
        Me.Text = "RPN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPrintName As System.Windows.Forms.TextBox
    Friend WithEvents txtPrintIP As System.Windows.Forms.TextBox
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents btnSetup As System.Windows.Forms.Button
End Class

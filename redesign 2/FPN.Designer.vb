<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FPN
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
        Me.btnSetup = New System.Windows.Forms.Button()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.txtPrintIP = New System.Windows.Forms.TextBox()
        Me.txtPrintName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnSetup
        '
        Me.btnSetup.Location = New System.Drawing.Point(59, 87)
        Me.btnSetup.Name = "btnSetup"
        Me.btnSetup.Size = New System.Drawing.Size(75, 23)
        Me.btnSetup.TabIndex = 6
        Me.btnSetup.Text = "Setup"
        Me.btnSetup.UseVisualStyleBackColor = True
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(7, 12)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(44, 13)
        Me.lblHost.TabIndex = 0
        Me.lblHost.Text = "Host/IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Printer IP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Printer Name"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(81, 9)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 20)
        Me.txtHost.TabIndex = 1
        '
        'txtPrintIP
        '
        Me.txtPrintIP.Location = New System.Drawing.Point(81, 35)
        Me.txtPrintIP.Name = "txtPrintIP"
        Me.txtPrintIP.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintIP.TabIndex = 3
        '
        'txtPrintName
        '
        Me.txtPrintName.Location = New System.Drawing.Point(81, 61)
        Me.txtPrintName.Name = "txtPrintName"
        Me.txtPrintName.Size = New System.Drawing.Size(100, 20)
        Me.txtPrintName.TabIndex = 5
        '
        'FPN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(196, 118)
        Me.Controls.Add(Me.txtPrintName)
        Me.Controls.Add(Me.txtPrintIP)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.btnSetup)
        Me.Name = "FPN"
        Me.Text = "FPN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSetup As System.Windows.Forms.Button
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents txtPrintIP As System.Windows.Forms.TextBox
    Friend WithEvents txtPrintName As System.Windows.Forms.TextBox
End Class

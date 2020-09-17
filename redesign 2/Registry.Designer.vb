<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registry))
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblHost = New System.Windows.Forms.Label()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(12, 49)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(228, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Service [F12]"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblHost
        '
        Me.lblHost.AutoSize = True
        Me.lblHost.Location = New System.Drawing.Point(104, 7)
        Me.lblHost.Name = "lblHost"
        Me.lblHost.Size = New System.Drawing.Size(44, 13)
        Me.lblHost.TabIndex = 0
        Me.lblHost.Text = "Host/IP"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(77, 23)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 20)
        Me.txtHost.TabIndex = 1
        '
        'Form4
        '
        Me.AcceptButton = Me.btnStart
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(252, 82)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.lblHost)
        Me.Controls.Add(Me.btnStart)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Enable Remote Registry"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents lblHost As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
End Class

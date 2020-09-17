<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scanner
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
        Me.rdo3080 = New System.Windows.Forms.RadioButton()
        Me.rdo4010 = New System.Windows.Forms.RadioButton()
        Me.rdo6010 = New System.Windows.Forms.RadioButton()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.txthost = New System.Windows.Forms.TextBox()
        Me.lblhost = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rdo3080
        '
        Me.rdo3080.AutoSize = True
        Me.rdo3080.Location = New System.Drawing.Point(135, 12)
        Me.rdo3080.Name = "rdo3080"
        Me.rdo3080.Size = New System.Drawing.Size(83, 17)
        Me.rdo3080.TabIndex = 0
        Me.rdo3080.TabStop = True
        Me.rdo3080.Text = "Canon 3080"
        Me.rdo3080.UseVisualStyleBackColor = True
        '
        'rdo4010
        '
        Me.rdo4010.AutoSize = True
        Me.rdo4010.Location = New System.Drawing.Point(135, 58)
        Me.rdo4010.Name = "rdo4010"
        Me.rdo4010.Size = New System.Drawing.Size(83, 17)
        Me.rdo4010.TabIndex = 1
        Me.rdo4010.TabStop = True
        Me.rdo4010.Text = "Canon 4010"
        Me.rdo4010.UseVisualStyleBackColor = True
        '
        'rdo6010
        '
        Me.rdo6010.AutoSize = True
        Me.rdo6010.Location = New System.Drawing.Point(135, 106)
        Me.rdo6010.Name = "rdo6010"
        Me.rdo6010.Size = New System.Drawing.Size(83, 17)
        Me.rdo6010.TabIndex = 2
        Me.rdo6010.TabStop = True
        Me.rdo6010.Text = "Canon 6010"
        Me.rdo6010.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Red
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(258, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'txthost
        '
        Me.txthost.Location = New System.Drawing.Point(12, 12)
        Me.txthost.Name = "txthost"
        Me.txthost.Size = New System.Drawing.Size(100, 20)
        Me.txthost.TabIndex = 4
        '
        'lblhost
        '
        Me.lblhost.AutoSize = True
        Me.lblhost.Location = New System.Drawing.Point(39, 35)
        Me.lblhost.Name = "lblhost"
        Me.lblhost.Size = New System.Drawing.Size(44, 13)
        Me.lblhost.TabIndex = 5
        Me.lblhost.Text = "Host/IP"
        '
        'Scanner
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 142)
        Me.Controls.Add(Me.lblhost)
        Me.Controls.Add(Me.txthost)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.rdo6010)
        Me.Controls.Add(Me.rdo4010)
        Me.Controls.Add(Me.rdo3080)
        Me.Name = "Scanner"
        Me.Text = "Scanner Station Setup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rdo3080 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo4010 As System.Windows.Forms.RadioButton
    Friend WithEvents rdo6010 As System.Windows.Forms.RadioButton
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents txthost As System.Windows.Forms.TextBox
    Friend WithEvents lblhost As System.Windows.Forms.Label
End Class

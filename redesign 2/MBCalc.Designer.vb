<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MBCalc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MBCalc))
        Me.btnFix = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRegister = New System.Windows.Forms.TextBox()
        Me.txthost = New System.Windows.Forms.TextBox()
        Me.mtxtPrinter = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFix
        '
        Me.btnFix.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFix.ForeColor = System.Drawing.Color.Yellow
        Me.btnFix.Location = New System.Drawing.Point(18, 119)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Size = New System.Drawing.Size(171, 23)
        Me.btnFix.TabIndex = 6
        Me.btnFix.Text = "FIX CALCULATOR"
        Me.btnFix.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Host/IP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Yellow
        Me.Label2.Location = New System.Drawing.Point(15, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Printer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(15, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Register#"
        '
        'txtRegister
        '
        Me.txtRegister.AcceptsReturn = True
        Me.txtRegister.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRegister.Location = New System.Drawing.Point(89, 93)
        Me.txtRegister.Name = "txtRegister"
        Me.txtRegister.Size = New System.Drawing.Size(100, 20)
        Me.txtRegister.TabIndex = 5
        '
        'txthost
        '
        Me.txthost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txthost.Location = New System.Drawing.Point(89, 26)
        Me.txthost.Name = "txthost"
        Me.txthost.Size = New System.Drawing.Size(100, 20)
        Me.txthost.TabIndex = 1
        '
        'mtxtPrinter
        '
        Me.mtxtPrinter.Location = New System.Drawing.Point(89, 60)
        Me.mtxtPrinter.Mask = "RP0"
        Me.mtxtPrinter.Name = "mtxtPrinter"
        Me.mtxtPrinter.Size = New System.Drawing.Size(100, 20)
        Me.mtxtPrinter.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Yellow
        Me.Button1.Location = New System.Drawing.Point(185, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(14, 20)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MBCalc
        '
        Me.AcceptButton = Me.btnFix
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGreen
        Me.ClientSize = New System.Drawing.Size(201, 158)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mtxtPrinter)
        Me.Controls.Add(Me.txthost)
        Me.Controls.Add(Me.txtRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFix)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MBCalc"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "MBCalculator Fix"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRegister As System.Windows.Forms.TextBox
    Friend WithEvents txthost As System.Windows.Forms.TextBox
    Friend WithEvents mtxtPrinter As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

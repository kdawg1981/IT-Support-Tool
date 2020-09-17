<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestions))
        Me.txtQuestions = New System.Windows.Forms.TextBox()
        Me.btncopy = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtQuestions
        '
        Me.txtQuestions.Location = New System.Drawing.Point(12, 12)
        Me.txtQuestions.Multiline = True
        Me.txtQuestions.Name = "txtQuestions"
        Me.txtQuestions.ReadOnly = True
        Me.txtQuestions.Size = New System.Drawing.Size(397, 232)
        Me.txtQuestions.TabIndex = 0
        Me.txtQuestions.Text = resources.GetString("txtQuestions.Text")
        '
        'btncopy
        '
        Me.btncopy.Location = New System.Drawing.Point(148, 250)
        Me.btncopy.Name = "btncopy"
        Me.btncopy.Size = New System.Drawing.Size(111, 23)
        Me.btncopy.TabIndex = 1
        Me.btncopy.Text = "Copy to Clipboard"
        Me.btncopy.UseVisualStyleBackColor = True
        '
        'frmQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 285)
        Me.Controls.Add(Me.btncopy)
        Me.Controls.Add(Me.txtQuestions)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmQuestions"
        Me.Text = "Development Questions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtQuestions As System.Windows.Forms.TextBox
    Friend WithEvents btncopy As System.Windows.Forms.Button
End Class

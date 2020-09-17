<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PCName
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
        Me.btnComputer = New System.Windows.Forms.Button()
        Me.txtNewPCNAme = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(33, 49)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(209, 20)
        Me.txtPC.TabIndex = 0
        '
        'btnComputer
        '
        Me.btnComputer.Location = New System.Drawing.Point(69, 98)
        Me.btnComputer.Name = "btnComputer"
        Me.btnComputer.Size = New System.Drawing.Size(130, 23)
        Me.btnComputer.TabIndex = 1
        Me.btnComputer.Text = "change computer name"
        Me.btnComputer.UseVisualStyleBackColor = True
        '
        'txtNewPCNAme
        '
        Me.txtNewPCNAme.Location = New System.Drawing.Point(33, 72)
        Me.txtNewPCNAme.Name = "txtNewPCNAme"
        Me.txtNewPCNAme.Size = New System.Drawing.Size(209, 20)
        Me.txtNewPCNAme.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.txtNewPCNAme)
        Me.Controls.Add(Me.btnComputer)
        Me.Controls.Add(Me.txtPC)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents btnComputer As System.Windows.Forms.Button
    Friend WithEvents txtNewPCNAme As System.Windows.Forms.TextBox

End Class

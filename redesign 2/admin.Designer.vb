<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPWD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPWD))
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.lbHost = New System.Windows.Forms.ListBox()
        Me.txtMove = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.rdoStore = New System.Windows.Forms.RadioButton()
        Me.rdoCorp = New System.Windows.Forms.RadioButton()
        Me.rdoCash = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(12, 12)
        Me.txtHost.Multiline = True
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(100, 173)
        Me.txtHost.TabIndex = 0
        '
        'lbHost
        '
        Me.lbHost.FormattingEnabled = True
        Me.lbHost.Location = New System.Drawing.Point(214, 12)
        Me.lbHost.Name = "lbHost"
        Me.lbHost.Size = New System.Drawing.Size(105, 173)
        Me.lbHost.TabIndex = 2
        '
        'txtMove
        '
        Me.txtMove.Location = New System.Drawing.Point(118, 12)
        Me.txtMove.Name = "txtMove"
        Me.txtMove.Size = New System.Drawing.Size(90, 23)
        Me.txtMove.TabIndex = 1
        Me.txtMove.Text = "--------->"
        Me.txtMove.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Change"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rdoStore
        '
        Me.rdoStore.AutoSize = True
        Me.rdoStore.Location = New System.Drawing.Point(118, 92)
        Me.rdoStore.Name = "rdoStore"
        Me.rdoStore.Size = New System.Drawing.Size(47, 17)
        Me.rdoStore.TabIndex = 4
        Me.rdoStore.TabStop = True
        Me.rdoStore.Text = "SRC"
        Me.rdoStore.UseVisualStyleBackColor = True
        '
        'rdoCorp
        '
        Me.rdoCorp.AutoSize = True
        Me.rdoCorp.Location = New System.Drawing.Point(118, 59)
        Me.rdoCorp.Name = "rdoCorp"
        Me.rdoCorp.Size = New System.Drawing.Size(71, 17)
        Me.rdoCorp.TabIndex = 3
        Me.rdoCorp.TabStop = True
        Me.rdoCorp.Text = "Corporate"
        Me.rdoCorp.UseVisualStyleBackColor = True
        '
        'rdoCash
        '
        Me.rdoCash.AutoSize = True
        Me.rdoCash.Location = New System.Drawing.Point(118, 125)
        Me.rdoCash.Name = "rdoCash"
        Me.rdoCash.Size = New System.Drawing.Size(84, 17)
        Me.rdoCash.TabIndex = 5
        Me.rdoCash.TabStop = True
        Me.rdoCash.Text = "Cash Money"
        Me.rdoCash.UseVisualStyleBackColor = True
        '
        'frmPWD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 194)
        Me.Controls.Add(Me.rdoCash)
        Me.Controls.Add(Me.rdoCorp)
        Me.Controls.Add(Me.rdoStore)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtMove)
        Me.Controls.Add(Me.lbHost)
        Me.Controls.Add(Me.txtHost)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPWD"
        Me.Text = "Administrator PWD"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents lbHost As System.Windows.Forms.ListBox
    Friend WithEvents txtMove As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents rdoStore As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCorp As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCash As System.Windows.Forms.RadioButton
End Class

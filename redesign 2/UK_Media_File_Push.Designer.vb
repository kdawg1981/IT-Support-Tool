<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UK_Media_File_Push
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
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.txtFileSelect = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.btnNonLoc = New System.Windows.Forms.Button()
        Me.btnCopyDef = New System.Windows.Forms.Button()
        Me.btnCopyNonDef = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.OFD_Browse = New System.Windows.Forms.OpenFileDialog()
        Me.LB_Stations = New System.Windows.Forms.ListBox()
        Me.LB_PCs = New System.Windows.Forms.ListBox()
        Me.btnMove = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBrowse
        '
        Me.btnBrowse.ForeColor = System.Drawing.Color.Maroon
        Me.btnBrowse.Location = New System.Drawing.Point(14, 28)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 2
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'txtFileSelect
        '
        Me.txtFileSelect.Location = New System.Drawing.Point(95, 31)
        Me.txtFileSelect.Name = "txtFileSelect"
        Me.txtFileSelect.Size = New System.Drawing.Size(431, 20)
        Me.txtFileSelect.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.btnNonLoc)
        Me.GroupBox1.Controls.Add(Me.txtFileSelect)
        Me.GroupBox1.Controls.Add(Me.btnBrowse)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(556, 158)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "File Selection"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Non-Default Location"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(95, 101)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(431, 20)
        Me.TextBox2.TabIndex = 5
        '
        'btnNonLoc
        '
        Me.btnNonLoc.ForeColor = System.Drawing.Color.Maroon
        Me.btnNonLoc.Location = New System.Drawing.Point(14, 99)
        Me.btnNonLoc.Name = "btnNonLoc"
        Me.btnNonLoc.Size = New System.Drawing.Size(75, 23)
        Me.btnNonLoc.TabIndex = 4
        Me.btnNonLoc.Text = "Browse"
        Me.btnNonLoc.UseVisualStyleBackColor = True
        '
        'btnCopyDef
        '
        Me.btnCopyDef.BackColor = System.Drawing.Color.Transparent
        Me.btnCopyDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyDef.ForeColor = System.Drawing.Color.Black
        Me.btnCopyDef.Location = New System.Drawing.Point(387, 178)
        Me.btnCopyDef.Name = "btnCopyDef"
        Me.btnCopyDef.Size = New System.Drawing.Size(181, 59)
        Me.btnCopyDef.TabIndex = 6
        Me.btnCopyDef.Text = "Copy -> Default Location"
        Me.btnCopyDef.UseVisualStyleBackColor = False
        '
        'btnCopyNonDef
        '
        Me.btnCopyNonDef.BackColor = System.Drawing.Color.Transparent
        Me.btnCopyNonDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyNonDef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyNonDef.ForeColor = System.Drawing.Color.Black
        Me.btnCopyNonDef.Location = New System.Drawing.Point(388, 243)
        Me.btnCopyNonDef.Name = "btnCopyNonDef"
        Me.btnCopyNonDef.Size = New System.Drawing.Size(181, 59)
        Me.btnCopyNonDef.TabIndex = 7
        Me.btnCopyNonDef.Text = "Copy-> Non-Def Location"
        Me.btnCopyNonDef.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Image = Global.redesign_2.My.Resources.Resources.exit__3_
        Me.btnClose.Location = New System.Drawing.Point(533, 335)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(43, 43)
        Me.btnClose.TabIndex = 8
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'OFD_Browse
        '
        Me.OFD_Browse.FileName = "OpenFileDialog2"
        '
        'LB_Stations
        '
        Me.LB_Stations.FormattingEnabled = True
        Me.LB_Stations.Location = New System.Drawing.Point(12, 178)
        Me.LB_Stations.Name = "LB_Stations"
        Me.LB_Stations.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.LB_Stations.Size = New System.Drawing.Size(120, 199)
        Me.LB_Stations.TabIndex = 9
        '
        'LB_PCs
        '
        Me.LB_PCs.FormattingEnabled = True
        Me.LB_PCs.Location = New System.Drawing.Point(193, 178)
        Me.LB_PCs.Name = "LB_PCs"
        Me.LB_PCs.Size = New System.Drawing.Size(120, 199)
        Me.LB_PCs.TabIndex = 10
        '
        'btnMove
        '
        Me.btnMove.BackColor = System.Drawing.Color.Transparent
        Me.btnMove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMove.ForeColor = System.Drawing.Color.Navy
        Me.btnMove.Image = Global.redesign_2.My.Resources.Resources.gtk_media_forward_ltr
        Me.btnMove.Location = New System.Drawing.Point(138, 243)
        Me.btnMove.Name = "btnMove"
        Me.btnMove.Size = New System.Drawing.Size(49, 59)
        Me.btnMove.TabIndex = 11
        Me.btnMove.UseVisualStyleBackColor = False
        '
        'UK_Media_File_Push
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.BackgroundImage = Global.redesign_2.My.Resources.Resources.uk_flag
        Me.ClientSize = New System.Drawing.Size(581, 390)
        Me.Controls.Add(Me.btnMove)
        Me.Controls.Add(Me.LB_PCs)
        Me.Controls.Add(Me.LB_Stations)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCopyNonDef)
        Me.Controls.Add(Me.btnCopyDef)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "UK_Media_File_Push"
        Me.Text = "UK_Media_File_Push"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents txtFileSelect As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnNonLoc As System.Windows.Forms.Button
    Friend WithEvents btnCopyDef As System.Windows.Forms.Button
    Friend WithEvents btnCopyNonDef As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents OFD_Browse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LB_Stations As System.Windows.Forms.ListBox
    Friend WithEvents LB_PCs As System.Windows.Forms.ListBox
    Friend WithEvents btnMove As System.Windows.Forms.Button
End Class

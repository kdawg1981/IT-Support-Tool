<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Citrix
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
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btn_test = New System.Windows.Forms.Button()
        Me.btn_CAN = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtOutputUK = New System.Windows.Forms.TextBox()
        Me.lbUK = New System.Windows.Forms.ListBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.txtOutputCan = New System.Windows.Forms.TextBox()
        Me.lbCAN = New System.Windows.Forms.ListBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(3, 162)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutput.Size = New System.Drawing.Size(443, 153)
        Me.txtOutput.TabIndex = 0
        '
        'btnTest
        '
        Me.btnTest.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTest.Location = New System.Drawing.Point(6, 321)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(440, 40)
        Me.btnTest.TabIndex = 1
        Me.btnTest.Text = "Test US Servers"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(179, 15)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(0, 13)
        Me.lblResult.TabIndex = 3
        '
        'btn_test
        '
        Me.btn_test.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_test.Location = New System.Drawing.Point(6, 323)
        Me.btn_test.Name = "btn_test"
        Me.btn_test.Size = New System.Drawing.Size(440, 40)
        Me.btn_test.TabIndex = 4
        Me.btn_test.Text = "Test UK Servers"
        Me.btn_test.UseVisualStyleBackColor = True
        '
        'btn_CAN
        '
        Me.btn_CAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CAN.Location = New System.Drawing.Point(3, 326)
        Me.btn_CAN.Name = "btn_CAN"
        Me.btn_CAN.Size = New System.Drawing.Size(440, 40)
        Me.btn_CAN.TabIndex = 5
        Me.btn_CAN.Text = "Test CAN Servers"
        Me.btn_CAN.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(460, 395)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ListBox1)
        Me.TabPage1.Controls.Add(Me.txtOutput)
        Me.TabPage1.Controls.Add(Me.btnTest)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(452, 369)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "US Citrix Svrs"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"ICTCITRIX1", "ICTCITRIX2", "ICTCITRIX3", "ICTCITRIX4", "ICTCITRIX5", "ICTCITRIX6", "ICTCITRIX7", "ICTCITRIX8", "ICTCITRIX9", "ICTCITRIX10", "ICTCITRIX11", "ICTCITRIX12", "ICTCITRIX13", "ICTCITRIX14", "ICTCITRIX15", "ICTCITRIX16", "ICTCITRIX17", "ICTCITRIX18", "ICTCITRIX19", "ICTCITRIX20", "ICTCITRIX21", "ICTCITRIX22", "ICTCITRIX23"})
        Me.ListBox1.Location = New System.Drawing.Point(6, 6)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(440, 147)
        Me.ListBox1.TabIndex = 8
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtOutputUK)
        Me.TabPage2.Controls.Add(Me.lbUK)
        Me.TabPage2.Controls.Add(Me.btn_test)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(452, 369)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "UK Citrix Svrs"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtOutputUK
        '
        Me.txtOutputUK.Location = New System.Drawing.Point(6, 107)
        Me.txtOutputUK.Multiline = True
        Me.txtOutputUK.Name = "txtOutputUK"
        Me.txtOutputUK.ReadOnly = True
        Me.txtOutputUK.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputUK.Size = New System.Drawing.Size(443, 205)
        Me.txtOutputUK.TabIndex = 10
        '
        'lbUK
        '
        Me.lbUK.FormattingEnabled = True
        Me.lbUK.Items.AddRange(New Object() {"UKCITRIX1", "UKCITRIX2", "UKCITRIX3", "UKCITRIX4", "UKCITRIX5", "UKCITRIX6"})
        Me.lbUK.Location = New System.Drawing.Point(6, 6)
        Me.lbUK.Name = "lbUK"
        Me.lbUK.Size = New System.Drawing.Size(440, 95)
        Me.lbUK.TabIndex = 9
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.txtOutputCan)
        Me.TabPage3.Controls.Add(Me.lbCAN)
        Me.TabPage3.Controls.Add(Me.btn_CAN)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(452, 369)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "CAN Citrix Svrs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'txtOutputCan
        '
        Me.txtOutputCan.Location = New System.Drawing.Point(3, 143)
        Me.txtOutputCan.Multiline = True
        Me.txtOutputCan.Name = "txtOutputCan"
        Me.txtOutputCan.ReadOnly = True
        Me.txtOutputCan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOutputCan.Size = New System.Drawing.Size(443, 179)
        Me.txtOutputCan.TabIndex = 12
        '
        'lbCAN
        '
        Me.lbCAN.FormattingEnabled = True
        Me.lbCAN.Items.AddRange(New Object() {"CANCITRIX1", "CANCITRIX2", "CANCITRIX3", "CANCITRIX4", "CANCITRIX5", "CANCITRIX6", "CANCITRIX7", "CANCITRIX8", "CANCITRIX9", "CANCITRIX10"})
        Me.lbCAN.Location = New System.Drawing.Point(3, 3)
        Me.lbCAN.Name = "lbCAN"
        Me.lbCAN.Size = New System.Drawing.Size(440, 134)
        Me.lbCAN.TabIndex = 11
        '
        'Citrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 414)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblResult)
        Me.Name = "Citrix"
        Me.Text = "Citrix Server Check"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btn_test As System.Windows.Forms.Button
    Friend WithEvents btn_CAN As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents txtOutputUK As System.Windows.Forms.TextBox
    Friend WithEvents lbUK As System.Windows.Forms.ListBox
    Friend WithEvents txtOutputCan As System.Windows.Forms.TextBox
    Friend WithEvents lbCAN As System.Windows.Forms.ListBox
End Class

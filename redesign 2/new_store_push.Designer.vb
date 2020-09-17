<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_store_push
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
        Me.components = New System.ComponentModel.Container()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Java"}, -1, System.Drawing.Color.Black, System.Drawing.Color.Empty, Nothing)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("McAfee")
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dameware")
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Adobe Flash")
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Adober Reader")
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Cisco Softphone")
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Cisco VPN")
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Copy E-Signature")
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("CutePDF Writer")
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dameware Update")
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Lightshot Screenshot")
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MB Applications")
        Dim ListViewItem13 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MB Calculator")
        Dim ListViewItem14 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MS Office 2010 Std")
        Dim ListViewItem15 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MS Office 2013 Std")
        Dim ListViewItem16 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MS Office Lync 2010")
        Dim ListViewItem17 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MS Office Lync 2013")
        Dim ListViewItem18 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("MS SQL Mgmt Studio")
        Dim ListViewItem19 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dot Net 4")
        Dim ListViewItem20 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Dot Net 4.5")
        Dim ListViewItem21 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("OpenOffice 4")
        Dim ListViewItem22 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Update VisionX Files")
        Dim ListViewItem23 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("UltraVNC")
        Dim ListViewItem24 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("US/MEX WUMO INI")
        Dim ListViewItem25 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("Citrix XenApp")
        Me.lvSoftware = New System.Windows.Forms.ListView()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.WinchkPREDataSet3 = New redesign_2.WinchkPREDataSet3()
        Me.StoreWindowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Store_WindowsTableAdapter = New redesign_2.WinchkPREDataSet3TableAdapters.Store_WindowsTableAdapter()
        Me.btnPush = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.StoreWindowsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.StoreWindowsBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.WinchkPREDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreWindowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreWindowsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreWindowsBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lvSoftware
        '
        Me.lvSoftware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lvSoftware.CheckBoxes = True
        ListViewItem1.StateImageIndex = 0
        ListViewItem2.StateImageIndex = 0
        ListViewItem3.StateImageIndex = 0
        ListViewItem4.StateImageIndex = 0
        ListViewItem5.StateImageIndex = 0
        ListViewItem6.StateImageIndex = 0
        ListViewItem7.StateImageIndex = 0
        ListViewItem8.StateImageIndex = 0
        ListViewItem9.StateImageIndex = 0
        ListViewItem10.StateImageIndex = 0
        ListViewItem11.StateImageIndex = 0
        ListViewItem12.StateImageIndex = 0
        ListViewItem13.StateImageIndex = 0
        ListViewItem14.StateImageIndex = 0
        ListViewItem15.StateImageIndex = 0
        ListViewItem16.StateImageIndex = 0
        ListViewItem17.StateImageIndex = 0
        ListViewItem18.StateImageIndex = 0
        ListViewItem19.StateImageIndex = 0
        ListViewItem20.StateImageIndex = 0
        ListViewItem21.StateImageIndex = 0
        ListViewItem22.StateImageIndex = 0
        ListViewItem23.StateImageIndex = 0
        ListViewItem24.StateImageIndex = 0
        ListViewItem25.StateImageIndex = 0
        Me.lvSoftware.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12, ListViewItem13, ListViewItem14, ListViewItem15, ListViewItem16, ListViewItem17, ListViewItem18, ListViewItem19, ListViewItem20, ListViewItem21, ListViewItem22, ListViewItem23, ListViewItem24, ListViewItem25})
        Me.lvSoftware.Location = New System.Drawing.Point(329, 12)
        Me.lvSoftware.Name = "lvSoftware"
        Me.lvSoftware.Size = New System.Drawing.Size(484, 199)
        Me.lvSoftware.TabIndex = 1
        Me.lvSoftware.UseCompatibleStateImageBehavior = False
        Me.lvSoftware.View = System.Windows.Forms.View.List
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'WinchkPREDataSet3
        '
        Me.WinchkPREDataSet3.DataSetName = "WinchkPREDataSet3"
        Me.WinchkPREDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreWindowsBindingSource
        '
        Me.StoreWindowsBindingSource.DataMember = "Store_Windows"
        Me.StoreWindowsBindingSource.DataSource = Me.WinchkPREDataSet3
        '
        'Store_WindowsTableAdapter
        '
        Me.Store_WindowsTableAdapter.ClearBeforeFill = True
        '
        'btnPush
        '
        Me.btnPush.Image = Global.redesign_2.My.Resources.Resources.down__1_
        Me.btnPush.Location = New System.Drawing.Point(750, 217)
        Me.btnPush.Name = "btnPush"
        Me.btnPush.Size = New System.Drawing.Size(63, 69)
        Me.btnPush.TabIndex = 4
        Me.btnPush.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.BackColor = System.Drawing.Color.White
        Me.lblMessage.Font = New System.Drawing.Font("Agency FB", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.ForeColor = System.Drawing.Color.Red
        Me.lblMessage.Location = New System.Drawing.Point(339, 235)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(366, 36)
        Me.lblMessage.TabIndex = 5
        Me.lblMessage.Text = "Pushing software to workstation(s)......."
        '
        'StoreWindowsBindingSource1
        '
        Me.StoreWindowsBindingSource1.DataMember = "Store_Windows"
        Me.StoreWindowsBindingSource1.DataSource = Me.WinchkPREDataSet3
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.ListBox1.Size = New System.Drawing.Size(148, 277)
        Me.ListBox1.TabIndex = 8
        '
        'ListBox2
        '
        Me.ListBox2.AllowDrop = True
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(167, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(156, 277)
        Me.ListBox2.TabIndex = 9
        '
        'StoreWindowsBindingSource2
        '
        Me.StoreWindowsBindingSource2.DataMember = "Store_Windows"
        Me.StoreWindowsBindingSource2.DataSource = Me.WinchkPREDataSet3
        '
        'new_store_push
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 296)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnPush)
        Me.Controls.Add(Me.lvSoftware)
        Me.Name = "new_store_push"
        Me.Text = "new_store_push"
        CType(Me.WinchkPREDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreWindowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreWindowsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreWindowsBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lvSoftware As System.Windows.Forms.ListView
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents WinchkPREDataSet3 As redesign_2.WinchkPREDataSet3
    Friend WithEvents StoreWindowsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Store_WindowsTableAdapter As redesign_2.WinchkPREDataSet3TableAdapters.Store_WindowsTableAdapter
    Friend WithEvents btnPush As System.Windows.Forms.Button
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents StoreWindowsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents StoreWindowsBindingSource2 As System.Windows.Forms.BindingSource
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmComputer_Info
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.CuroPrint = New System.Windows.Forms.TabPage()
        Me.txtLocation = New System.Windows.Forms.TextBox()
        Me.btnGet = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoUK = New System.Windows.Forms.RadioButton()
        Me.rdoUS = New System.Windows.Forms.RadioButton()
        Me.rdoWDA = New System.Windows.Forms.RadioButton()
        Me.rdoCAN = New System.Windows.Forms.RadioButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CuroID = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoCuroCAN = New System.Windows.Forms.RadioButton()
        Me.rdoCuroUK = New System.Windows.Forms.RadioButton()
        Me.rdoCuroUS = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnCuro = New System.Windows.Forms.Button()
        Me.btnLName = New System.Windows.Forms.Button()
        Me.btnFName = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuroID = New System.Windows.Forms.TextBox()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.ListApps = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtWSTN = New System.Windows.Forms.TextBox()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.ServiceTag = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPC = New System.Windows.Forms.TextBox()
        Me.btnTag = New System.Windows.Forms.Button()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.SysInfo = New System.Windows.Forms.TabPage()
        Me.WinchkPREDataSet = New redesign_2.WinchkPREDataSet()
        Me.StoreWindowsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Store_WindowsTableAdapter = New redesign_2.WinchkPREDataSetTableAdapters.Store_WindowsTableAdapter()
        Me.WinchkPREDataSet2 = New redesign_2.WinchkPREDataSet2()
        Me.StoreWindowsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Store_WindowsTableAdapter1 = New redesign_2.WinchkPREDataSet2TableAdapters.Store_WindowsTableAdapter()
        Me.txtSysinfo = New System.Windows.Forms.TextBox()
        Me.btnGetSys = New System.Windows.Forms.Button()
        Me.txtHost = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.CuroPrint.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CuroID.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ListApps.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ServiceTag.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SysInfo.SuspendLayout()
        CType(Me.WinchkPREDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreWindowsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinchkPREDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StoreWindowsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.CuroPrint)
        Me.TabControl1.Controls.Add(Me.CuroID)
        Me.TabControl1.Controls.Add(Me.ListApps)
        Me.TabControl1.Controls.Add(Me.ServiceTag)
        Me.TabControl1.Controls.Add(Me.SysInfo)
        Me.TabControl1.Location = New System.Drawing.Point(1, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(671, 444)
        Me.TabControl1.TabIndex = 0
        '
        'CuroPrint
        '
        Me.CuroPrint.Controls.Add(Me.txtLocation)
        Me.CuroPrint.Controls.Add(Me.btnGet)
        Me.CuroPrint.Controls.Add(Me.Label1)
        Me.CuroPrint.Controls.Add(Me.GroupBox1)
        Me.CuroPrint.Controls.Add(Me.DataGridView1)
        Me.CuroPrint.Location = New System.Drawing.Point(4, 22)
        Me.CuroPrint.Name = "CuroPrint"
        Me.CuroPrint.Padding = New System.Windows.Forms.Padding(3)
        Me.CuroPrint.Size = New System.Drawing.Size(663, 418)
        Me.CuroPrint.TabIndex = 0
        Me.CuroPrint.Text = "Curo Printer Info"
        Me.CuroPrint.UseVisualStyleBackColor = True
        '
        'txtLocation
        '
        Me.txtLocation.Location = New System.Drawing.Point(197, 360)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(63, 20)
        Me.txtLocation.TabIndex = 13
        '
        'btnGet
        '
        Me.btnGet.Location = New System.Drawing.Point(312, 358)
        Me.btnGet.Name = "btnGet"
        Me.btnGet.Size = New System.Drawing.Size(101, 23)
        Me.btnGet.TabIndex = 11
        Me.btnGet.Text = "Get Info"
        Me.btnGet.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(185, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Location Search"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoUK)
        Me.GroupBox1.Controls.Add(Me.rdoUS)
        Me.GroupBox1.Controls.Add(Me.rdoWDA)
        Me.GroupBox1.Controls.Add(Me.rdoCAN)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 345)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(123, 65)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Environment"
        '
        'rdoUK
        '
        Me.rdoUK.AutoSize = True
        Me.rdoUK.Location = New System.Drawing.Point(52, 16)
        Me.rdoUK.Name = "rdoUK"
        Me.rdoUK.Size = New System.Drawing.Size(40, 17)
        Me.rdoUK.TabIndex = 3
        Me.rdoUK.TabStop = True
        Me.rdoUK.Text = "UK"
        Me.rdoUK.UseVisualStyleBackColor = True
        '
        'rdoUS
        '
        Me.rdoUS.AutoSize = True
        Me.rdoUS.Location = New System.Drawing.Point(6, 16)
        Me.rdoUS.Name = "rdoUS"
        Me.rdoUS.Size = New System.Drawing.Size(40, 17)
        Me.rdoUS.TabIndex = 2
        Me.rdoUS.TabStop = True
        Me.rdoUS.Text = "US"
        Me.rdoUS.UseVisualStyleBackColor = True
        '
        'rdoWDA
        '
        Me.rdoWDA.AutoSize = True
        Me.rdoWDA.Location = New System.Drawing.Point(52, 39)
        Me.rdoWDA.Name = "rdoWDA"
        Me.rdoWDA.Size = New System.Drawing.Size(51, 17)
        Me.rdoWDA.TabIndex = 5
        Me.rdoWDA.TabStop = True
        Me.rdoWDA.Text = "WDA"
        Me.rdoWDA.UseVisualStyleBackColor = True
        '
        'rdoCAN
        '
        Me.rdoCAN.AutoSize = True
        Me.rdoCAN.Location = New System.Drawing.Point(6, 39)
        Me.rdoCAN.Name = "rdoCAN"
        Me.rdoCAN.Size = New System.Drawing.Size(47, 17)
        Me.rdoCAN.TabIndex = 4
        Me.rdoCAN.TabStop = True
        Me.rdoCAN.Text = "CAN"
        Me.rdoCAN.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.DataGridView1.Location = New System.Drawing.Point(6, 7)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DataGridView1.Size = New System.Drawing.Size(651, 332)
        Me.DataGridView1.TabIndex = 1
        '
        'CuroID
        '
        Me.CuroID.Controls.Add(Me.GroupBox3)
        Me.CuroID.Controls.Add(Me.GroupBox2)
        Me.CuroID.Controls.Add(Me.DataGridView3)
        Me.CuroID.Location = New System.Drawing.Point(4, 22)
        Me.CuroID.Name = "CuroID"
        Me.CuroID.Size = New System.Drawing.Size(663, 418)
        Me.CuroID.TabIndex = 3
        Me.CuroID.Text = "Curo ID Lookup"
        Me.CuroID.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdoCuroCAN)
        Me.GroupBox3.Controls.Add(Me.rdoCuroUK)
        Me.GroupBox3.Controls.Add(Me.rdoCuroUS)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 253)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(92, 89)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Environment"
        '
        'rdoCuroCAN
        '
        Me.rdoCuroCAN.AutoSize = True
        Me.rdoCuroCAN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCuroCAN.Location = New System.Drawing.Point(6, 62)
        Me.rdoCuroCAN.Name = "rdoCuroCAN"
        Me.rdoCuroCAN.Size = New System.Drawing.Size(71, 17)
        Me.rdoCuroCAN.TabIndex = 2
        Me.rdoCuroCAN.TabStop = True
        Me.rdoCuroCAN.Text = "CAN DB"
        Me.rdoCuroCAN.UseVisualStyleBackColor = True
        '
        'rdoCuroUK
        '
        Me.rdoCuroUK.AutoSize = True
        Me.rdoCuroUK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCuroUK.Location = New System.Drawing.Point(6, 39)
        Me.rdoCuroUK.Name = "rdoCuroUK"
        Me.rdoCuroUK.Size = New System.Drawing.Size(63, 17)
        Me.rdoCuroUK.TabIndex = 1
        Me.rdoCuroUK.TabStop = True
        Me.rdoCuroUK.Text = "UK DB"
        Me.rdoCuroUK.UseVisualStyleBackColor = True
        '
        'rdoCuroUS
        '
        Me.rdoCuroUS.AutoSize = True
        Me.rdoCuroUS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoCuroUS.Location = New System.Drawing.Point(6, 16)
        Me.rdoCuroUS.Name = "rdoCuroUS"
        Me.rdoCuroUS.Size = New System.Drawing.Size(63, 17)
        Me.rdoCuroUS.TabIndex = 0
        Me.rdoCuroUS.TabStop = True
        Me.rdoCuroUS.Text = "US DB"
        Me.rdoCuroUS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCuro)
        Me.GroupBox2.Controls.Add(Me.btnLName)
        Me.GroupBox2.Controls.Add(Me.btnFName)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCuroID)
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Location = New System.Drawing.Point(106, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(551, 158)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Options"
        '
        'btnCuro
        '
        Me.btnCuro.Location = New System.Drawing.Point(470, 110)
        Me.btnCuro.Name = "btnCuro"
        Me.btnCuro.Size = New System.Drawing.Size(75, 37)
        Me.btnCuro.TabIndex = 5
        Me.btnCuro.Text = "Search by CuroID"
        Me.btnCuro.UseVisualStyleBackColor = True
        '
        'btnLName
        '
        Me.btnLName.Location = New System.Drawing.Point(470, 68)
        Me.btnLName.Name = "btnLName"
        Me.btnLName.Size = New System.Drawing.Size(75, 37)
        Me.btnLName.TabIndex = 3
        Me.btnLName.Text = "Search by LastName"
        Me.btnLName.UseVisualStyleBackColor = True
        '
        'btnFName
        '
        Me.btnFName.Location = New System.Drawing.Point(470, 19)
        Me.btnFName.Name = "btnFName"
        Me.btnFName.Size = New System.Drawing.Size(75, 43)
        Me.btnFName.TabIndex = 1
        Me.btnFName.Text = "Search by FirstName"
        Me.btnFName.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 91)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 17)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Curo_ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last_Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "First_Name"
        '
        'txtCuroID
        '
        Me.txtCuroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuroID.Location = New System.Drawing.Point(100, 90)
        Me.txtCuroID.Name = "txtCuroID"
        Me.txtCuroID.Size = New System.Drawing.Size(170, 23)
        Me.txtCuroID.TabIndex = 4
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(100, 52)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(170, 23)
        Me.txtLName.TabIndex = 2
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(100, 20)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(170, 23)
        Me.txtFName.TabIndex = 0
        '
        'DataGridView3
        '
        Me.DataGridView3.AllowUserToAddRows = False
        Me.DataGridView3.AllowUserToDeleteRows = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(8, 4)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.ReadOnly = True
        Me.DataGridView3.Size = New System.Drawing.Size(649, 242)
        Me.DataGridView3.TabIndex = 0
        '
        'ListApps
        '
        Me.ListApps.Controls.Add(Me.Label4)
        Me.ListApps.Controls.Add(Me.Button2)
        Me.ListApps.Controls.Add(Me.txtWSTN)
        Me.ListApps.Controls.Add(Me.DataGridView2)
        Me.ListApps.Location = New System.Drawing.Point(4, 22)
        Me.ListApps.Name = "ListApps"
        Me.ListApps.Padding = New System.Windows.Forms.Padding(3)
        Me.ListApps.Size = New System.Drawing.Size(663, 418)
        Me.ListApps.TabIndex = 1
        Me.ListApps.Text = "List of Applications"
        Me.ListApps.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 387)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Workstation/IP Address"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(331, 364)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(324, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Submit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtWSTN
        '
        Me.txtWSTN.Location = New System.Drawing.Point(7, 364)
        Me.txtWSTN.Multiline = True
        Me.txtWSTN.Name = "txtWSTN"
        Me.txtWSTN.Size = New System.Drawing.Size(252, 20)
        Me.txtWSTN.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.Size = New System.Drawing.Size(649, 352)
        Me.DataGridView2.TabIndex = 0
        '
        'ServiceTag
        '
        Me.ServiceTag.Controls.Add(Me.Label6)
        Me.ServiceTag.Controls.Add(Me.txtPC)
        Me.ServiceTag.Controls.Add(Me.btnTag)
        Me.ServiceTag.Controls.Add(Me.DataGridView4)
        Me.ServiceTag.Location = New System.Drawing.Point(4, 22)
        Me.ServiceTag.Name = "ServiceTag"
        Me.ServiceTag.Size = New System.Drawing.Size(663, 418)
        Me.ServiceTag.TabIndex = 2
        Me.ServiceTag.Text = "Service Tag"
        Me.ServiceTag.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(172, 367)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Workstation/IP Address"
        '
        'txtPC
        '
        Me.txtPC.Location = New System.Drawing.Point(140, 383)
        Me.txtPC.Name = "txtPC"
        Me.txtPC.Size = New System.Drawing.Size(179, 20)
        Me.txtPC.TabIndex = 0
        '
        'btnTag
        '
        Me.btnTag.Location = New System.Drawing.Point(348, 380)
        Me.btnTag.Name = "btnTag"
        Me.btnTag.Size = New System.Drawing.Size(125, 23)
        Me.btnTag.TabIndex = 1
        Me.btnTag.Text = "Get Service Tag [F10]"
        Me.btnTag.UseVisualStyleBackColor = True
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(4, 4)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(653, 358)
        Me.DataGridView4.TabIndex = 0
        '
        'SysInfo
        '
        Me.SysInfo.Controls.Add(Me.Label7)
        Me.SysInfo.Controls.Add(Me.txtHost)
        Me.SysInfo.Controls.Add(Me.btnGetSys)
        Me.SysInfo.Controls.Add(Me.txtSysinfo)
        Me.SysInfo.Location = New System.Drawing.Point(4, 22)
        Me.SysInfo.Name = "SysInfo"
        Me.SysInfo.Size = New System.Drawing.Size(663, 418)
        Me.SysInfo.TabIndex = 4
        Me.SysInfo.Text = "System Info"
        Me.SysInfo.UseVisualStyleBackColor = True
        '
        'WinchkPREDataSet
        '
        Me.WinchkPREDataSet.DataSetName = "WinchkPREDataSet"
        Me.WinchkPREDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreWindowsBindingSource
        '
        Me.StoreWindowsBindingSource.DataMember = "Store_Windows"
        Me.StoreWindowsBindingSource.DataSource = Me.WinchkPREDataSet
        '
        'Store_WindowsTableAdapter
        '
        Me.Store_WindowsTableAdapter.ClearBeforeFill = True
        '
        'WinchkPREDataSet2
        '
        Me.WinchkPREDataSet2.DataSetName = "WinchkPREDataSet2"
        Me.WinchkPREDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StoreWindowsBindingSource1
        '
        Me.StoreWindowsBindingSource1.DataMember = "Store_Windows"
        Me.StoreWindowsBindingSource1.DataSource = Me.WinchkPREDataSet2
        '
        'Store_WindowsTableAdapter1
        '
        Me.Store_WindowsTableAdapter1.ClearBeforeFill = True
        '
        'txtSysinfo
        '
        Me.txtSysinfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSysinfo.Location = New System.Drawing.Point(3, 8)
        Me.txtSysinfo.Multiline = True
        Me.txtSysinfo.Name = "txtSysinfo"
        Me.txtSysinfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSysinfo.Size = New System.Drawing.Size(654, 353)
        Me.txtSysinfo.TabIndex = 0
        '
        'btnGetSys
        '
        Me.btnGetSys.Location = New System.Drawing.Point(582, 388)
        Me.btnGetSys.Name = "btnGetSys"
        Me.btnGetSys.Size = New System.Drawing.Size(75, 23)
        Me.btnGetSys.TabIndex = 1
        Me.btnGetSys.Text = "Get Info"
        Me.btnGetSys.UseVisualStyleBackColor = True
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(365, 388)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Size = New System.Drawing.Size(211, 20)
        Me.txtHost.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(457, 372)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Host/IP"
        '
        'frmComputer_Info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 445)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmComputer_Info"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "System Information"
        Me.TabControl1.ResumeLayout(False)
        Me.CuroPrint.ResumeLayout(False)
        Me.CuroPrint.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CuroID.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ListApps.ResumeLayout(False)
        Me.ListApps.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ServiceTag.ResumeLayout(False)
        Me.ServiceTag.PerformLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SysInfo.ResumeLayout(False)
        Me.SysInfo.PerformLayout()
        CType(Me.WinchkPREDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreWindowsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinchkPREDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StoreWindowsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents CuroPrint As System.Windows.Forms.TabPage
    Friend WithEvents btnGet As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoUK As System.Windows.Forms.RadioButton
    Friend WithEvents rdoUS As System.Windows.Forms.RadioButton
    Friend WithEvents rdoWDA As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCAN As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ListApps As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtWSTN As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ServiceTag As System.Windows.Forms.TabPage
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents WinchkPREDataSet As redesign_2.WinchkPREDataSet
    Friend WithEvents StoreWindowsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Store_WindowsTableAdapter As redesign_2.WinchkPREDataSetTableAdapters.Store_WindowsTableAdapter
    Friend WithEvents WinchkPREDataSet2 As redesign_2.WinchkPREDataSet2
    Friend WithEvents StoreWindowsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Store_WindowsTableAdapter1 As redesign_2.WinchkPREDataSet2TableAdapters.Store_WindowsTableAdapter
    Friend WithEvents CuroID As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rdoCuroCAN As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCuroUK As System.Windows.Forms.RadioButton
    Friend WithEvents rdoCuroUS As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents txtCuroID As System.Windows.Forms.TextBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents btnCuro As System.Windows.Forms.Button
    Friend WithEvents btnLName As System.Windows.Forms.Button
    Friend WithEvents btnFName As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SysInfo As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPC As System.Windows.Forms.TextBox
    Friend WithEvents btnTag As System.Windows.Forms.Button
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtHost As System.Windows.Forms.TextBox
    Friend WithEvents btnGetSys As System.Windows.Forms.Button
    Friend WithEvents txtSysinfo As System.Windows.Forms.TextBox
End Class

Imports System
Imports System.Management
Imports System.Text


Public Class ComputerInfo

    Private Sub btnGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGet.Click
        If cboPC.SelectedItem.Equals("Service Tag") Then
            ServiceTag()
        ElseIf cboPC.SelectedItem.Equals("List of Applications") Then
            SoftwareList()
        ElseIf cboPC.SelectedItem.Equals("Services") Then
            Services()
        ElseIf cboPC.SelectedItem.Equals("Processes") Then
            Processes()
        End If
    End Sub
    Public Sub SoftwareList()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_Product")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Name", "Name")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("Name"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
    Public Sub ServiceTag()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_BIOS")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("SerialNumber", "SerialNumber")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("SerialNumber"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
    Public Sub NetworkShares()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_ComputerSystem")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("UserName", "Username")
        'DataGridView1.Columns.Add("Name", "Name")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("UserName"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
    Public Sub Processes()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_Process")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("ProcessId", "ProcessId")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("Name"), m("ProcessId"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
    Public Sub Services()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_Service")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("Started", "Started")
        DataGridView1.Columns.Add("State", "State")
        DataGridView1.Columns.Add("Status", "Status")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("Name"), m("Started"), m("State"), m("Status"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
    Public Sub Printers()
        ' Making the connection to the remote computer
        Dim strHost As String = txtHost.Text
        'Dim username As String = txtUserName.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_Printer")

        ' Generate Datagridview
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Name", "Name")
        DataGridView1.Columns.Add("Caption", "Caption")
        DataGridView1.Columns.Add("DriverName", "DriverName")
        DataGridView1.Columns.Add("Location", "Location")
        DataGridView1.Columns.Add("PortName", "PortName")
        DataGridView1.Columns.Add("ShareName", "ShareName")
        DataGridView1.Columns.Add("Default", "Default")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView1.Rows.Add(m("Name"), m("Caption"), m("DriverName"), m("Location"),
                                   m("Portname"), m("ShareName"), m("Default"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub
End Class
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Management



Public Class frmComputer_Info

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        Dim connectionString As String
        Dim connectionstringUK As String
        Dim connectionstringCAN As String
        Dim connectionstringWDA As String
        Dim connection As SqlConnection
        Dim connectionUK As SqlConnection
        Dim connectionCAN As SqlConnection
        Dim connectionWDA As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim mysql As New SqlCommand

        connectionString = "Data Source=ictdev20;Initial Catalog=WinchkPRE;Integrated Security=True"
        connectionstringUK = "Data Source=UKdev20;Initial Catalog=WinchkUKPRE;Integrated Security=True"
        connectionstringCAN = "Data Source=CANdev20;Initial Catalog=WinchkCANPRE;Integrated Security=True"
        connectionstringWDA = "Data Source=UKWDAdev20;Initial Catalog=WinchkUKWDAPRE;Integrated Security=True"

        connection = New SqlConnection(connectionString)
        connectionUK = New SqlConnection(connectionstringUK)
        connectionCAN = New SqlConnection(connectionstringCAN)
        connectionWDA = New SqlConnection(connectionstringWDA)

        Try
            If rdoUS.Checked = True Then
                connection.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Location =" & txtLocation.Text & Space(1) & "Order by Computer_Name", connection)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                connection.Close()
                DataGridView1.DataSource = ds.Tables(0)
            ElseIf rdoUK.Checked = True Then
                connectionUK.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Location =" & txtLocation.Text & Space(1) & "Order by Computer_Name", connectionUK)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                connectionUK.Close()
                DataGridView1.DataSource = ds.Tables(0)
            ElseIf rdoCAN.Checked = True Then
                connectionCAN.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Location =" & txtLocation.Text & Space(1) & "Order by Computer_Name", connectionCAN)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                connectionCAN.Close()
                DataGridView1.DataSource = ds.Tables(0)
            ElseIf rdoWDA.Checked = True Then
                connectionWDA.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Location =" & txtLocation.Text & Space(1) & "Order by Computer_Name", connectionWDA)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                connectionWDA.Close()
                DataGridView1.DataSource = ds.Tables(0)
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub frmComputer_Info_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F10
                btnTag.PerformClick()
            Case Keys.Escape
                Me.Close()

        End Select
    End Sub

    Private Sub frmComputer_Info_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: This line of code loads data into the 'WinchkPREDataSet2.Store_Windows' table. You can move, or remove it, as needed.
        'Me.Store_WindowsTableAdapter1.Fill(Me.WinchkPREDataSet2.Store_Windows)
        ''TODO: This line of code loads data into the 'WinchkPREDataSet.Store_Windows' table. You can move, or remove it, as needed.
        'Me.Store_WindowsTableAdapter.Fill(Me.WinchkPREDataSet.Store_Windows)

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtCuroID.TextChanged

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnCuro.Click
        Dim cs As String
        Dim csUK As String
        Dim csCAN As String
        Dim csWDA As String
        Dim con As SqlConnection
        Dim conUK As SqlConnection
        Dim conCAN As SqlConnection
        Dim conWDA As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim mysql As New SqlCommand

        cs = "Data Source=ictdev20;Initial Catalog=WinchkPRE;Integrated Security=True"
        csUK = "Data Source=UKdev20;Initial Catalog=WinchkUKPRE;Integrated Security=True"
        csCAN = "Data Source=CANdev20;Initial Catalog=WinchkCANPRE;Integrated Security=True"
        csWDA = "Data Source=UKWDAdev20;Initial Catalog=WinchkUKWDAPRE;Integrated Security=True"

        con = New SqlConnection(cs)
        conUK = New SqlConnection(csUK)
        conCAN = New SqlConnection(csCAN)
        conWDA = New SqlConnection(csWDA)


        Try
            If rdoCuroUS.Checked = True Then
                con.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE TELLER ='" & txtCuroID.Text & "'", con)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                con.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtCuroID.Clear()

            ElseIf rdoUK.Checked = True Then
                conUK.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE TELLER ='" & txtCuroID.Text & "'", conUK)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conUK.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtCuroID.Clear()
            ElseIf rdoCAN.Checked = True Then
                conCAN.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE TELLER ='" & txtCuroID.Text & "'", conCAN)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conCAN.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtCuroID.Clear()
            ElseIf rdoWDA.Checked = True Then
                conWDA.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE TELLER ='" & txtCuroID.Text & "'", conWDA)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conWDA.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtCuroID.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnFName_Click(sender As Object, e As EventArgs) Handles btnFName.Click
        Dim cs As String
        Dim csUK As String
        Dim csCAN As String
        Dim csWDA As String
        Dim con As SqlConnection
        Dim conUK As SqlConnection
        Dim conCAN As SqlConnection
        Dim conWDA As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim mysql As New SqlCommand

        cs = "Data Source=ictdev20;Initial Catalog=WinchkPRE;Integrated Security=True"
        csUK = "Data Source=UKdev20;Initial Catalog=WinchkUKPRE;Integrated Security=True"
        csCAN = "Data Source=CANdev20;Initial Catalog=WinchkCANPRE;Integrated Security=True"
        csWDA = "Data Source=UKWDAdev20;Initial Catalog=WinchkUKWDAPRE;Integrated Security=True"

        con = New SqlConnection(cs)
        conUK = New SqlConnection(csUK)
        conCAN = New SqlConnection(csCAN)
        conWDA = New SqlConnection(csWDA)


        Try
            If rdoCuroUS.Checked = True Then
                con.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE FIRSTNAME LIKE '%" & txtFName.Text & "%'", con)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                con.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtFName.Clear()

            ElseIf rdoUK.Checked = True Then
                conUK.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE FIRSTNAME LIKE '%" & txtFName.Text & "%'", conUK)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conUK.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtFName.Clear()
            ElseIf rdoCAN.Checked = True Then
                conCAN.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE FIRSTNAME LIKE '%" & txtFName.Text & "%'", conCAN)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conCAN.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtFName.Clear()
            ElseIf rdoWDA.Checked = True Then
                conWDA.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE FIRSTNAME LIKE '%" & txtFName.Text & "%'", conWDA)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conWDA.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtFName.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnLName_Click(sender As Object, e As EventArgs) Handles btnLName.Click
        Dim cs As String
        Dim csUK As String
        Dim csCAN As String
        Dim csWDA As String
        Dim con As SqlConnection
        Dim conUK As SqlConnection
        Dim conCAN As SqlConnection
        Dim conWDA As SqlConnection
        Dim adapter As New SqlDataAdapter
        Dim ds As New DataSet
        Dim mysql As New SqlCommand

        cs = "Data Source=ictdev20;Initial Catalog=WinchkPRE;Integrated Security=True"
        csUK = "Data Source=UKdev20;Initial Catalog=WinchkUKPRE;Integrated Security=True"
        csCAN = "Data Source=CANdev20;Initial Catalog=WinchkCANPRE;Integrated Security=True"
        csWDA = "Data Source=UKWDAdev20;Initial Catalog=WinchkUKWDAPRE;Integrated Security=True"

        con = New SqlConnection(cs)
        conUK = New SqlConnection(csUK)
        conCAN = New SqlConnection(csCAN)
        conWDA = New SqlConnection(csWDA)


        Try
            If rdoCuroUS.Checked = True Then
                con.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE LSTNAME LIKE '%" & txtLName.Text & "%'", con)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                con.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtLName.Clear()
            ElseIf rdoUK.Checked = True Then
                conUK.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE LSTNAME LIKE '%" & txtLName.Text & "%'", conUK)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conUK.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtLName.Clear()
            ElseIf rdoCAN.Checked = True Then
                conCAN.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE LSTNAME LIKE '%" & txtLName.Text & "%'", conCAN)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conCAN.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtLName.Clear()
            ElseIf rdoWDA.Checked = True Then
                conWDA.Open()
                adapter.SelectCommand = New SqlCommand("SELECT Location, TELLER, FIRSTNAME, LSTNAME FROM TELLERID WHERE LSTNAME LIKE '%" & txtLName.Text & "%'", conWDA)
                'adapter.SelectCommand = New SqlCommand("SELECT Location, Computer_name, agreement, Receipt, Money_orders FROM Store_Windows WHERE Computer_name = " & txtWstn.Text & Space(1) & "Order by Computer_Name", connection)
                adapter.Fill(ds)
                conWDA.Close()
                DataGridView3.DataSource = ds.Tables(0)
                txtLName.Clear()
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Making the connection to the remote computer
        Dim strHost As String = txtWSTN.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_Product")

        ' Generate Datagridview
        DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("Name", "Name")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView2.Rows.Add(m("Name"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub btnTag_Click(sender As Object, e As EventArgs) Handles btnTag.Click
        ' Making the connection to the remote computer
        Dim strHost As String = txtPC.Text
        Dim scope As ManagementScope
        scope = New ManagementScope("\\" & strHost & "\root\cimv2")
        scope.Connect()

        ' query system for OS information
        Dim query As ObjectQuery
        query = New ObjectQuery("Select * From Win32_BIOS")

        ' Generate Datagridview
        DataGridView4.Columns.Clear()
        DataGridView4.Columns.Add("SerialNumber", "SerialNumber")

        Dim searcher As New ManagementObjectSearcher(scope, query)
        Dim queryCollection As ManagementObjectCollection
        queryCollection = searcher.Get()

        Dim m As ManagementObject

        For Each m In queryCollection
            DataGridView4.Rows.Add(m("SerialNumber"))

        Next
        ' display message for search complete
        MsgBox("Search Complete", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub btnTag_KeyDown(sender As Object, e As KeyEventArgs) Handles btnTag.KeyDown
        
    End Sub

    Private Sub btnGetSys_Click(sender As Object, e As EventArgs) Handles btnGetSys.Click
        Try
            Dim sysinfop As New Process
            Dim sysinfo As New System.Diagnostics.ProcessStartInfo
            sysinfo.FileName = "systeminfo"
            sysinfo.Arguments = "/s" & Space(1) & txtHost.Text & ".speedycash.ict"
            sysinfo.RedirectStandardInput = True
            sysinfo.RedirectStandardOutput = True
            sysinfo.UseShellExecute = False
            sysinfo.UseShellExecute = False
            sysinfo.CreateNoWindow = True
            sysinfop.StartInfo = sysinfo
            sysinfop.Start()
            Dim sr As System.IO.StreamReader = sysinfop.StandardOutput
            Dim sw As System.IO.StreamWriter = sysinfop.StandardInput
            sw.WriteLine(txtSysinfo.Text)
            txtSysinfo.Text = sr.ReadToEnd
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
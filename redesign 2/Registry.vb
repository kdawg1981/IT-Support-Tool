Public Class Registry

    Private Sub Form4_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' Pressing function key to perform task
        Select Case e.KeyCode
            Case Keys.F12
                btnStart.PerformClick()
        End Select
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnStart_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnStart.Click
        Dim objWMIService, objService
        Dim colListOfServices, strComputer, strService, strInput
        strInput = False
        ' Creates the Input Message Box
        Do
            strComputer = txtHost.Text
            If strComputer <> "" Then strInput = True
        Loop Until strInput = True
        ' NB Spelling of RemoteRegistry (No space).
        strService = " 'RemoteRegistry' "
        objWMIService = GetObject("winmgmts:" _
        & "{impersonationLevel=impersonate}!\\" _
        & strComputer & "\root\cimv2")
        colListOfServices = objWMIService.ExecQuery _
        ("Select * from Win32_Service Where Name =" & strService & " ")
        For Each objService In colListOfServices

            objService.StartService()
        Next
        '' Start service on remote workstation
        'Dim host As String = txtHost.Text

        '' Start the process
        'Dim objRegistry As New System.Diagnostics.Process

        'objRegistry.StartInfo.FileName = "psexec.exe"
        'objRegistry.StartInfo.Arguments = "\\" & host & Space(1) & "-u speedycash\MBConvert -p MBconverT123 SC start RemoteRegistry"
        'objRegistry.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        'objRegistry.Start()
        'objRegistry.WaitForExit()
        'objRegistry.Close()

        ' Display message box letting the user know of the service started

        MessageBox.Show("Remote Registry Started on " & strComputer & "!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        txtHost.Text = ""

    End Sub
End Class
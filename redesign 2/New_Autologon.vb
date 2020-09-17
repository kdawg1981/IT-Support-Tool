Public Class New_Autologon

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        If chkWin7.Checked = True Then
            For i As Integer = 0 To Me.lbPCName.Items.Count - 1
                Try
                    Dim objWMIService, objService
                    Dim colListOfServices, strComputer, strService, strInput
                    strInput = False
                    ' Creates the Input Message Box
                    Do
                        strComputer = lbPCName.Items(i)
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

                    Dim MyRegKey As Microsoft.Win32.RegistryKey

                    'open remote hklm hive
                    Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, lbPCName.Items(i))


                    'open the key
                    MyRegKey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

                    'set values to keys
                    MyRegKey.SetValue("DefaultUserName", lbPCName.Items(i))
                    MyRegKey.SetValue("AltDefaultUserName", lbPCName.Items(i))
                    MyRegKey.SetValue("DefaultDomainName", "SPEEDYCASH")
                    MyRegKey.SetValue("AltDefaultDomainName", "SPEEDYCASH")
                    MyRegKey.SetValue("CachePrimaryDomain", "SPEEDYCASH")
                    MyRegKey.SetValue("AutoAdminLogon", "1")
                    MyRegKey.SetValue("DefaultPassword", "")
                    MyRegKey.SetValue("ForceAutoLogon", "1")

                    'close registry
                    MyRegKey.Close()


                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
            Next

            ' display message box to end user
            MessageBox.Show("Autologon has been enabled")
            lbPCName.Items.Clear()

        Else
            For i As Integer = 0 To Me.lbPCName.Items.Count - 1
                Try

                    Dim MyRegKey As Microsoft.Win32.RegistryKey

                    'open remote hklm hive
                    Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, lbPCName.Items(i))


                    'open the key
                    MyRegKey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

                    'set values to keys
                    MyRegKey.SetValue("DefaultUserName", lbPCName.Items(i))
                    MyRegKey.SetValue("AltDefaultUserName", lbPCName.Items(i))
                    MyRegKey.SetValue("DefaultDomainName", "SPEEDYCASH")
                    MyRegKey.SetValue("AltDefaultDomainName", "SPEEDYCASH")
                    MyRegKey.SetValue("CachePrimaryDomain", "SPEEDYCASH")
                    MyRegKey.SetValue("AutoAdminLogon", "1")
                    MyRegKey.SetValue("DefaultPassword", "")
                    MyRegKey.SetValue("ForceAutoLogon", "1")

                    'close registry
                    MyRegKey.Close()


                Catch ex As Exception
                    
                End Try
            Next

            ' display message box to end user
            MessageBox.Show("Autologon has been enabled")
            lbPCName.Items.Clear()

        End If




    End Sub

    Private Sub New_Autologon_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub New_Autologon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        


    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()

    End Sub

    Private Sub btnTransfer_Click(sender As Object, e As EventArgs) Handles btnTransfer.Click
        lbPCName.Items.AddRange(txtPC.Lines)
        txtPC.Clear()
        btnEnable.Enabled = True
        btnDisable.Enabled = True

    End Sub

    Private Sub btnDisable_Click(sender As Object, e As EventArgs) Handles btnDisable.Click
        If chkWin7.Checked = True Then
            For i As Integer = 0 To Me.lbPCName.Items.Count - 1
                Try
                    Dim objWMIService, objService
                    Dim colListOfServices, strComputer, strService, strInput
                    strInput = False
                    ' Creates the Input Message Box
                    Do
                        strComputer = lbPCName.Items(i)
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

                    Dim MyRegKey As Microsoft.Win32.RegistryKey

                    'open remote hklm hive
                    Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, lbPCName.Items(i))


                    'open the key
                    MyRegKey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

                    'set values to keys
                    MyRegKey.SetValue("DefaultUserName", "")
                    MyRegKey.SetValue("AltDefaultUserName", "")
                    MyRegKey.SetValue("DefaultDomainName", "")
                    MyRegKey.SetValue("AltDefaultDomainName", "")
                    MyRegKey.SetValue("CachePrimaryDomain", "")
                    MyRegKey.SetValue("AutoAdminLogon", "0")
                    MyRegKey.SetValue("DefaultPassword", "")
                    MyRegKey.SetValue("ForceAutoLogon", "0")

                    'close registry
                    MyRegKey.Close()


                Catch ex As Exception

                End Try
            Next

            ' display message box to end user
            MessageBox.Show("Autologon has been enabled")
            lbPCName.ClearSelected()
        Else
            For i As Integer = 0 To Me.lbPCName.Items.Count - 1
                Try

                    Dim MyRegKey As Microsoft.Win32.RegistryKey

                    'open remote hklm hive
                    Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, lbPCName.Items(i))


                    'open the key
                    MyRegKey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

                    'set values to keys
                    MyRegKey.SetValue("DefaultUserName", "")
                    MyRegKey.SetValue("AltDefaultUserName", "")
                    MyRegKey.SetValue("DefaultDomainName", "")
                    MyRegKey.SetValue("AltDefaultDomainName", "")
                    MyRegKey.SetValue("CachePrimaryDomain", "")
                    MyRegKey.SetValue("AutoAdminLogon", "0")
                    MyRegKey.SetValue("DefaultPassword", "")
                    MyRegKey.SetValue("ForceAutoLogon", "0")

                    'close registry
                    MyRegKey.Close()


                Catch ex As Exception

                End Try
            Next

            ' display message box to end user
            MessageBox.Show("Autologon has been enabled")
            lbPCName.ClearSelected()
        End If
    End Sub
End Class
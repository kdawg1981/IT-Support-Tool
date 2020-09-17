Imports Microsoft.Win32.Registry
Imports System.IO



Public Class frmLogon

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEnable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnable.Click
        ' declare the variable
        Dim wstn As String = txtWSTN.Text
        Dim login As String = txtLogin.Text

        Dim MyRegKey As Microsoft.Win32.RegistryKey

        'open remote hklm hive
        Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, wstn)


        'open the key
        MyRegKey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

        'set values to keys
        MyRegKey.SetValue("DefaultUserName", login)
        MyRegKey.SetValue("AltDefaultUserName", login)
        MyRegKey.SetValue("DefaultDomainName", "SPEEDYCASH")
        MyRegKey.SetValue("AltDefaultDomainName", "SPEEDYCASH")
        MyRegKey.SetValue("CachePrimaryDomain", "SPEEDYCASH")
        MyRegKey.SetValue("AutoAdminLogon", "1")
        MyRegKey.SetValue("DefaultPassword", "")
        MyRegKey.SetValue("ForceAutoLogon", "1")

        'close registry
        MyRegKey.Close()

        ' display message box to end user
        MessageBox.Show("Autologon has been enabled")
        txtWSTN.Text = ""
        txtLogin.Text = ""
    End Sub

    Private Sub btnDisable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisable.Click
        Dim wstn As String = txtWSTN.Text
        Dim login As String = txtLogin.Text

        Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, wstn)

        Dim myregkey As Microsoft.Win32.RegistryKey

        'open the key
        myregkey = Reg.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon", True)

        'set values to keys
        myregkey.SetValue("DefaultUserName", "")
        myregkey.SetValue("AltDefaultUserName", "")
        myregkey.SetValue("DefaultDomainName", "")
        myregkey.SetValue("AltDefaultDomainName", "")
        myregkey.SetValue("CachePrimaryDomain", "")
        myregkey.SetValue("AutoAdminLogon", "0")
        myregkey.SetValue("DefaultPassword", "")
        myregkey.SetValue("ForceAutoLogon", "0")

        'close registry
        myregkey.Close()
        MessageBox.Show("Autologon has been disabled")

        txtLogin.Text = ""
        txtWSTN.Text = ""
    End Sub

    Private Sub frmLogon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        


    End Sub

    Private Sub txtLogin_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLogin.TextChanged
        Dim login As String = txtLogin.Text
        'If login.Contains("s") Then
        '    btnEnable.Enabled = True
        'ElseIf login.Contains("S") Then
        '    btnEnable.Enabled = True
        'Else
        '    btnEnable.Enabled = False
        'End If

        Select Case True
            Case login.Contains("s")
                btnEnable.Enabled = True
            Case login.Contains("S")
                btnEnable.Enabled = True
            Case login.Contains("media")
                btnEnable.Enabled = True

        End Select
        
    End Sub
End Class
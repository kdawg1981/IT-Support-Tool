Imports Microsoft.Win32.Registry
Imports Microsoft.Win32.RegistryKey


Public Class PCName

    Private Sub btnComputer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnComputer.Click
        Dim machinename As String = txtPC.Text
        Dim Newname As String = txtNewPCNAme.Text
        Dim myregkey As Microsoft.Win32.RegistryKey
        Dim myregkey2 As Microsoft.Win32.RegistryKey

        Dim reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, machinename)
        myregkey = reg.OpenSubKey("system\currentcontrolset\control\computername\computername\", True)
        myregkey2 = reg.OpenSubKey("system\currentcontrolset\control\computername\activecomputername", True)

        myregkey.SetValue("ComputerName", Newname)
        myregkey2.SetValue("ComputerName", Newname)
        myregkey.Close()

        MessageBox.Show("Name changed")

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class

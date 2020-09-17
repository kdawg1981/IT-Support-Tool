Public Class MBCalc

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        Dim machinename As String = txthost.Text
        Dim printer As String = mtxtPrinter.Text
        Dim register As String = txtRegister.Text
        Dim myregkey As Microsoft.Win32.RegistryKey
        Dim myregkey2 As Microsoft.Win32.RegistryKey
        Dim myregkey3 As Microsoft.Win32.RegistryKey
        txthost.Text = ""
        mtxtPrinter.Text = ""
        txtRegister.Text = ""


        'Open registry
        Dim Reg = Microsoft.Win32.RegistryKey.OpenRemoteBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, machinename)

        'open the key
        myregkey = Reg.OpenSubKey("software\MBit3\Mars\Receipt\", True)
        myregkey2 = Reg.OpenSubKey("software\MBit3\Mars\Register\", True)
        myregkey3 = Reg.OpenSubKey("software\MBit3\Mars\Register\", True)


        'set values to keys
        myregkey.SetValue("Printername", printer)
        myregkey2.SetValue("PrinterName", printer)
        myregkey3.SetValue("RegisterNumber", register)


        'close registry
        myregkey.Close()
        myregkey2.Close()

        'Message box
        MsgBox("Mars Calc Fixed", vbOKOnly)
    End Sub

    Private Sub txtprinter_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If mtxtPrinter.Text.Length = 3 Then
            txtRegister.Focus()

        End If
    End Sub

    Private Sub txtRegister_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRegister.TextChanged
        If txtRegister.Text.Length = 2 Then
            btnFix.Focus()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class
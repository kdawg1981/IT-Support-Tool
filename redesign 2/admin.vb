Public Class frmPWD

    Private Sub frmPWD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMove.Click
        lbHost.Items.AddRange(txtHost.Lines)
        txtHost.Clear()


    End Sub
    Public Sub Corp()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                Dim objCorp As New System.Diagnostics.Process
                objCorp.StartInfo.FileName = "Pspasswd.exe"
                objCorp.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "administrator Time2fix!"
                objCorp.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objCorp.Start()
                objCorp.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Password Changed", "IT Notification")
        lbHost.Items.Clear()
        rdoCorp.Checked = False
    End Sub
    Public Sub SRC()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                Dim objStore As New System.Diagnostics.Process
                objStore.StartInfo.FileName = "Pspasswd.exe"
                objStore.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "administrator Cur0#!"
                objStore.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objStore.Start()
                objStore.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Password Changed", "IT Notification")
        lbHost.Items.Clear()
        rdoStore.Checked = False
    End Sub
    Public Sub CMoney()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                Dim objCash As New System.Diagnostics.Process
                objCash.StartInfo.FileName = "Pspasswd.exe"
                objCash.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "administrator sAcuzeC5"
                objCash.StartInfo.WindowStyle = ProcessWindowStyle.Minimized

                objCash.Start()
                objCash.WaitForExit()
                
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Password Changed", "IT Notification")
        lbHost.Items.Clear()
        rdoCash.Checked = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If rdoCorp.Checked = True Then
            Corp()
        ElseIf rdoStore.Checked = True Then
            SRC()
        ElseIf rdoCash.Checked = True Then
            CMoney()
        End If

    End Sub
End Class
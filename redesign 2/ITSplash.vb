Imports System.DirectoryServices.AccountManagement


Public Class ITSplash

    Private Sub ITSplash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        Dim userFullName As String = UserPrincipal.Current.DisplayName
        lblUsername.Text = userFullName

        If lblUsername.Text = "Doug Ford" Then
            MsgBox("Access Denied")
            End
        End If
    End Sub

    Private Sub lblUsername_Click(sender As Object, e As EventArgs) Handles lblUsername.Click

    End Sub
End Class
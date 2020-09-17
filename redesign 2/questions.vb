Public Class frmQuestions

    Private Sub btncopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncopy.Click
        Clipboard.SetText(txtQuestions.SelectedText)

    End Sub
End Class
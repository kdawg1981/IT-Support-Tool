Public Class Citrix

    Private Sub Citrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        For i As Integer = 0 To Me.ListBox1.Items.Count - 1
            Try
                Dim citrix_process As New Process
                Dim startinfo As New System.Diagnostics.ProcessStartInfo
                startinfo.FileName = "portqry"
                startinfo.Arguments = "-n" & Space(1) & ListBox1.Items(i).ToString & Space(1) & "-e 1494"
                startinfo.RedirectStandardInput = True
                startinfo.RedirectStandardOutput = True
                startinfo.UseShellExecute = False
                startinfo.CreateNoWindow = True
                citrix_process.StartInfo = startinfo
                citrix_process.Start()
                Dim SR As System.IO.StreamReader = citrix_process.StandardOutput
                Dim SW As System.IO.StreamWriter = citrix_process.StandardInput
                SW.WriteLine(txtOutput.Text)
                txtOutput.Text = SR.ReadToEnd

                If txtOutput.Text.Contains("NOT LISTENING") Then
                    MsgBox(ListBox1.Items(i).ToString & " is not accepting connections!")
                Else
                    MsgBox(ListBox1.Items(i).ToString & " is Up! ")
                End If

                'If txtOutput.Text.Contains("LISTENING") Then
                '    lblResult.Text = "Server is Up"
                'Else
                '    lblResult.Text = "Server is not accepting connections"
                'End If
                'SW.Close()
                'SR.Close()
            Catch ex As Exception

            End Try
        Next


    End Sub

    Private Sub btn_test_Click(sender As Object, e As EventArgs) Handles btn_test.Click
        For i As Integer = 0 To Me.lbUK.Items.Count - 1
            Try
                Dim citrix_process As New Process
                Dim startinfo As New System.Diagnostics.ProcessStartInfo
                startinfo.FileName = "portqry"
                startinfo.Arguments = "-n" & Space(1) & lbUK.Items(i).ToString & Space(1) & "-e 1494"
                startinfo.RedirectStandardInput = True
                startinfo.RedirectStandardOutput = True
                startinfo.UseShellExecute = False
                startinfo.CreateNoWindow = True
                citrix_process.StartInfo = startinfo
                citrix_process.Start()
                Dim SR As System.IO.StreamReader = citrix_process.StandardOutput
                Dim SW As System.IO.StreamWriter = citrix_process.StandardInput
                SW.WriteLine(txtOutputUK.Text)
                txtOutputUK.Text = SR.ReadToEnd

                If txtOutputUK.Text.Contains("NOT LISTENING") Then
                    MsgBox(lbUK.Items(i).ToString & " is not accepting connections!")
                Else
                    MsgBox(lbUK.Items(i).ToString & " is up!")
                End If

                'If txtOutput.Text.Contains("LISTENING") Then
                '    lblResult.Text = "Server is Up"
                'Else
                '    lblResult.Text = "Server is not accepting connections"
                'End If
                'SW.Close()
                'SR.Close()
            Catch ex As Exception

            End Try
        Next
    End Sub
End Class

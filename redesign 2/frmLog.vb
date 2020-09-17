Public Class frmLog

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' reads log file

        Dim readFile As IO.StreamReader
        Dim strInfo As String

        ' Verify that the file exists
        If IO.File.Exists("\\ictsupport\data\scripts\autologon\beta\log.txt") Then
            ' open the file for input
            readFile = IO.File.OpenText("\\ictsupport\data\scripts\autologon\beta\log.txt")
            ' process loop instructions until end of file
            Do Until readFile.Peek = -1
                strInfo = readFile.ReadLine
                lstLog.Items.Add(strInfo)
            Loop
            readFile.Close()
            ' select the first line in the list box
            lstLog.SelectedIndex = 0

        Else
            MessageBox.Show("Can't find the Log.txt file", "Log File", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub
End Class
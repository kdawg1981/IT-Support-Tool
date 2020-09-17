Imports System.IO

Public Class MediaSetup

    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click
        Dim host As String = txthost.Text
        Dim objviewer As New System.Diagnostics.Process
        Dim objlogon As New System.Diagnostics.Process
        Dim objmedia As New System.Diagnostics.Process
        Dim objcacls As New System.Diagnostics.Process

        'INSTALL MICROSOFT POWERPOINT VIEWER

        Try
            NotifyIcon1.BalloonTipText = "Setting up Media Station"
            NotifyIcon1.BalloonTipTitle = "IT Notification"
            NotifyIcon1.ShowBalloonTip(100)
            objviewer.StartInfo.FileName = "psexec.exe"
            objviewer.StartInfo.Arguments = "-i \\" & host & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\Media\media.bat"
            objviewer.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
            objviewer.Start()
            objviewer.WaitForExit()


        Catch ex As Exception

        End Try
        MessageBox.Show("Media PC has been Setup", "IT Notification")
    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
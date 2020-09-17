Public Class frmSoftware

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        lbHost.Items.AddRange(txtHost.Lines)
        txtHost.Clear()
        btnInstall.Enabled = True
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstall.Click
        BW1.RunWorkerAsync()

        ' When selected radio button selected perform the function
        If LBSoftware.SelectedItem = "Cisco Softphone" Then
            CIP()
        ElseIf LBSoftware.SelectedItem = "McAfee Antivirus" Then
            McAfee()
        ElseIf LBSoftware.SelectedItem = "MS Office 2010" Then
            Off2k10()
        ElseIf LBSoftware.SelectedItem = "Adobe Reader XI" Then
            adobeReader()
        ElseIf LBSoftware.SelectedItem = "Java Install" Then
            Java()
        ElseIf LBSoftware.SelectedItem = "Firefox" Then
            firefox()
        ElseIf LBSoftware.SelectedItem = "Chrome" Then
            Chrome()
        ElseIf LBSoftware.SelectedItem = ".Net Install 4" Then
            DotNet()
        ElseIf LBSoftware.SelectedItem = ".Net Install 4.5" Then

        ElseIf LBSoftware.SelectedItem = "Adobe Flash" Then
            adobeflash()
        ElseIf LBSoftware.SelectedItem = "Lync 2010" Then
            Lync2010()
        ElseIf LBSoftware.SelectedItem = "Lync 2013" Then
            Lync2013()
        ElseIf LBSoftware.SelectedItem = "MS Visio 2010" Then

        ElseIf LBSoftware.SelectedItem = "CutePDF Writer" Then
            CutePDF()
        ElseIf LBSoftware.SelectedItem = "UltraVNC" Then
            ultravnc()
        ElseIf LBSoftware.SelectedItem = "Dameware Update" Then
            Dameware()
        ElseIf LBSoftware.SelectedItem = "NICE Reporter/Player" Then
            NICE()

        End If

    End Sub
    Public Sub NICE()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing Nice Software"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\NiceReportPlayer.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Nice Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub Dameware()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Updating Dameware"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\dameware\update.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Dameware Updated!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub ultravnc()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing UltraVNC"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictfile01\RemoteAppDeployment\UltraVNC\InstallUltraVNC.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("UltraVNC Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub CutePDF()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of CutePDF from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing CutePDF"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\icttech01\RemoteAppDeployment\Install_CutePDF\Install_CutePDF_fromLocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("CutePDF Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub Chrome()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Chrome from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Google Chrome"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\browsers\chrome.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Chrome has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()

    End Sub
    Public Sub firefox()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Firefox from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Firefox"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\browsers\firefox.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Firefox has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()

    End Sub
    Public Sub CIP()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of CIP from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Cisco Communicator"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "-i \\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 msiexec /i \\uknas01\Recovery\Special Applications\CiscoIPCommunicator\CiscoIPCommunicatorSetup.msi /qb /norestart"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("CIP has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()

    End Sub
    Public Sub Java()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of java from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Running Java from Server"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\java7\java.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Java has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()

    End Sub
    Public Sub adobeReader()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Adobe 
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Adobe Reader"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 msiexec.exe /i \\icttech01\RemoteAppDeployment\AdobeReader\AdbeRdr11000_en_US.MSI /quiet /passive /norestart"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Adobe Reader has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub adobeflash()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                NotifyIcon1.BalloonTipText = "Running Flash Install"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\scripts\autologon\development\flash\flash.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Adobe Flash has been installed", "IT Notification")
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub FileConverter()
        'For i As Integer = 0 To Me.lbHost.Items.Count - 1
        '    Try
        '        NotifyIcon1.BalloonTipText = "Running FileConverter Installer"
        '        NotifyIcon1.BalloonTipTitle = "IT Support Notification"
        '        NotifyIcon1.ShowBalloonTip(50)
        '        Dim objprocess As New System.Diagnostics.Process
        '        objprocess.StartInfo.FileName = "psexec.exe"
        '        objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\MSOffice2007FileConverter\FileFormatConverters.exe /passive"
        '        objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
        '        objprocess.Start()
        '        objprocess.WaitForExit()

        '    Catch ex As Exception

        '    End Try
        'Next
        'MessageBox.Show("File Converter has been installed", "IT Notification")
        'lbHost.Items.Clear()
    End Sub
    Public Sub MSOffice()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Office from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Running Office Installer"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\msoffice2k3\office2k3.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try
        Next
        ' Show messagebox and clear the fields
        MessageBox.Show("Office has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()
    End Sub
    Public Sub McAfee()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of McAfee from
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing McAfee"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\icttech01\RemoteAppDeployment\Install_McAfee\install_McAfee_fromlocal.batt"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("McAfee has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub DotNet()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of .Net from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Running DotNet from Server"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\dotnet\dotnet4.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
                'objprocess.Close()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show(".Net has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub OCS()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing OCS"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\ocs\ocs.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("OCS has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub Off2k10()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Office 2010 from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing Office 2010"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\office2k10\off2k10.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Office 2010 has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub Lync2010()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Lync2010 from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing Lync 2010"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\Lync 2010\lync.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Lync 2010 has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub Lync2013()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Lync2013 from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing Lync 2013"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\Lync 2013\lync13.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Lync 2013 has been installed", "IT Notification")

        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub

    Private Sub frmSoftware_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            btnInstall.PerformClick()

        End If
    End Sub

    Private Sub frmSoftware_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnInstall.Enabled = False

    End Sub

    Private Sub txtHost_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHost.TextChanged
        Dim change As String = txtHost.Text
        If change.Contains("S") Then

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub
End Class
Imports System.IO


Public Class frmStore


    Private Sub btnInstall_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInstall.Click
        BW1.RunWorkerAsync()


        If LBSoftware.SelectedItem = "Java Install" Then
            Java()
        ElseIf LBSoftware.SelectedItem = ".Net Install" Then
            DotNet()
        ElseIf LBSoftware.SelectedItem = "Adobe Flash" Then
            adobeflash()
        ElseIf LBSoftware.SelectedItem = "Copy E-Sig Files" Then
            Esig()
        ElseIf LBSoftware.SelectedItem = "MB Applications" Then
            MBApps()
        ElseIf LBSoftware.SelectedItem = "Adobe Reader XI" Then
            adobeReader()
        ElseIf LBSoftware.SelectedItem = "McAfee" Then
            McAfee()
        ElseIf LBSoftware.SelectedItem = "CutePDF Writer" Then
            CutePDF()
        ElseIf LBSoftware.SelectedItem = "WUMO (Updated)" Then
            WUMO()
        ElseIf LBSoftware.SelectedItem = "MB Calculator Setup" Then
            MBCalc()
        ElseIf LBSoftware.SelectedItem = "IE8 Setup" Then
            IE8()
        ElseIf LBSoftware.SelectedItem = "UltraVNC" Then
            VNC()
        ElseIf LBSoftware.SelectedItem = "Update Visionx Files" Then
            Visionx()
        ElseIf LBSoftware.SelectedItem = "Dameware Update" Then
            Dameware()
        ElseIf LBSoftware.SelectedItem = "MS Office 2010 Std" Then
            Office2010()
        ElseIf LBSoftware.SelectedItem = "XenApp" Then
            XenApp()
        ElseIf LBSoftware.SelectedItem = "Cisco Softphone" Then
            CIP()
        ElseIf LBSoftware.SelectedItem = "Cisco VPN" Then
            'VPN()
        ElseIf LBSoftware.SelectedItem = "OpenOffice" Then
            OpenOffice()

        End If

    End Sub
    Public Sub OpenOffice()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of CIP from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Open Office 4"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\OO4\OpenOffice.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Normal

                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
        MessageBox.Show("Open Office has been installed", "IT Notification")
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()
    End Sub
    Public Sub VPN()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of CIP from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Cisco VPN Client x64"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\CiscoVPN.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Cisco VPN Client has been installed", "IT Notification")
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
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & Space(1) & "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\CiscoIP.bat"
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
    Public Sub XenApp()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Office from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing XenApp"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) & "-u speedycash\MBConvert -p MBconverT123 -e -c -n 50 -f -h -d \\icttech01\RemoteAppDeployment\Install_XenApp\Install_XenApp_FromLocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Next
        MessageBox.Show("XenApp Installed! Please Document all stations with connection problems!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()
    End Sub
    Public Sub Office2010()

        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Office from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing Office 2010"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) & "-u speedycash\MBConvert -p MBconverT123 -e -c -n 50 -f -h -d \\icttech01\RemoteAppDeployment\Office2010\Install_Office2010_FromLocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("MS Office 2010 Std Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 -e -c -f -n 30 -h -s -d \\icttech01\RemoteAppDeployment\Java\InstallJavaFromLocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("Java Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\Adobe Reader\readernas.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try

        Next
        ' Display Message box
        MessageBox.Show("Adobe Reader Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()

    End Sub
    Public Sub adobeflash()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                NotifyIcon1.BalloonTipText = "Running Flash Install"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 -e -c -n 50 -f -h -d \\icttech01\RemoteAppDeployment\AdobeFlash\Install_AdobeFlash_FromLocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()

            Catch ex As Exception

            End Try
        Next
        ' Display message box
        MessageBox.Show("Adobe Flash Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        lbHost.Items.Clear()
        LBSoftware.ClearSelected()
    End Sub
    Public Sub Esig()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of java from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Copying E-Signature Files"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\e-signature.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Esig Files Copied!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()

        'MessageBox.Show("E-signature files Copied", "IT Notification")
    End Sub
    Public Sub MBApps()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of Moneybox Apps
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing MBApps"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\development\mbapps.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()


            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("Moneybox Apps Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub McAfee()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try

                'uninstall and reinstall of McAfee from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Installing McAfee"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "PsExec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                        "-u speedycash\MBConvert -p MBconverT123 \\icttech01\RemoteAppDeployment\Install_McAfee\install_McAfee_fromlocal.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("McAfee Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub WUMO()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of CutePDF from NAS
                'show Notification
                NotifyIcon1.BalloonTipText = "Running WUMO Process"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\wumo\wumo.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try
        Next
        MessageBox.Show("WUMO Process Complete!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
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
    Public Sub DotNet()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of .net from server
                'show Notification
                NotifyIcon1.BalloonTipText = "Running DotNet from Server"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\dotnet\dotnet4.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
                'objprocess.Close()

            Catch ex As Exception

            End Try

        Next
        MessageBox.Show(".Net Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub MBCalc()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing MBCalc"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\mbcalc.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("MBCalc Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub IE8()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing IE 8"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\browsers\IE8-WindowsXP-x86-ENU.exe /quiet /update-no /norestart"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("IE 8 Installed!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub
    Public Sub VNC()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Installing UltraVNC"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\icttech01\RemoteAppDeployment\UltraVNC\InstallUltraVNC.bat"
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
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
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
    Public Sub Visionx()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            Try
                'uninstall and reinstall of OCS from server
                'show(Notification)
                NotifyIcon1.BalloonTipText = "Updating VisionX Files"
                NotifyIcon1.BalloonTipTitle = "IT Support Notification"
                NotifyIcon1.ShowBalloonTip(50)
                Dim objprocess As New System.Diagnostics.Process
                objprocess.StartInfo.FileName = "psexec.exe"
                objprocess.StartInfo.Arguments = "\\" & lbHost.Items(i).ToString & ".speedycash.ict" & Space(1) &
                    "-u speedycash\MBConvert -p MBconverT123 \\ictsupport\data\Scripts\AutoLogon\Development\Visionx\visionx.bat"
                objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Minimized
                objprocess.Start()
                objprocess.WaitForExit()
            Catch ex As Exception

            End Try

        Next
        MessageBox.Show("VisionX Updated!", "IT Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        LBSoftware.ClearSelected()
        lbHost.Items.Clear()
    End Sub

    Private Sub frmStore_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' Pressing Function key to start the installation

        If e.KeyCode = Keys.F1 Then
            btnInstall.PerformClick()

        End If

    End Sub

    Private Sub frmStore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Install button disabled on form load
        'mtxtIP.Enabled = False
        btnInstall.Enabled = False






    End Sub

    Private Sub btnTransfer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransfer.Click
        lbHost.Items.AddRange(txtHost.Lines)
        txtHost.Clear()
        btnInstall.Enabled = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClearList.Click
        lbHost.Items.Clear()
        txtHost.Clear()

    End Sub

    Private Sub btnLoadList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sr As StreamReader
        sr = New StreamReader(txtFile.Text)
        Dim line = sr.ReadToEnd
        txtHost.Text = line
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        OpenFileDialog1.Title = "Please Select a File"
        OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Filter = "txt files (*.txt)|*.txt"
        OpenFileDialog1.FilterIndex = 2
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sr As StreamReader = New StreamReader(OpenFileDialog1.OpenFile())
            If (sr IsNot Nothing) Then
                Dim line = sr.ReadToEnd
                txtHost.Text = line
                sr.Close()

            End If
        End If

    End Sub

    Private Sub OpenFileDialog1_FileOk(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Dim strm As System.IO.FileStream

        strm = OpenFileDialog1.OpenFile
        txtFile.Text = OpenFileDialog1.FileName.ToString

    End Sub

    Private Sub btnSaveList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveList.Click
        SaveFileDialog1.Title = "Please Save File"
        SaveFileDialog1.InitialDirectory = "C:\"
        SaveFileDialog1.Filter = "txt files (*.txt)|*.txt"
        SaveFileDialog1.FilterIndex = 2
        SaveFileDialog1.RestoreDirectory = True

        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim sw As StreamWriter = New StreamWriter(SaveFileDialog1.OpenFile())
            If (sw IsNot Nothing) Then
                sw.WriteLine(txtHost.Text)
                sw.Close()

            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub chkSoftware_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class
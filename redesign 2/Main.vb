Imports System.IO
Imports System.Management
Imports System.DirectoryServices.AccountManagement
Imports System.Deployment




Public Class frmSupport

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ' Display's message box when clicking on exit
        Dim name As String = UserPrincipal.Current.DisplayName
        If MsgBox("Thank you and Have a Nice Day " & name & "!", MsgBoxStyle.OkCancel, "IT Support") = MsgBoxResult.Ok Then
            Close()
        Else
            Me.Show()

        End If

    End Sub

    Private Sub frmSupport_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        ' The use of function keys on the main form
        Select Case e.KeyCode
            Case Keys.F8
                ToolStripButton1.PerformClick()
            Case Keys.F9
                tsPrinterSetup.PerformClick()
            Case Keys.F10
                tsAdmin.PerformClick()
        End Select
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fade_in()

        Dim userFullName As String = UserPrincipal.Current.DisplayName

        'File.WriteAllText(save, username)
        TSlblUsername.Text = userFullName
        TSlblmachineName.Text = Environment.MachineName
        TSlblDate_time.Text = DateAndTime.Now




        ' Output to log file
        Dim username = Environment.UserName
        Dim outFile As IO.StreamWriter
        Dim strName As String =
            "USERNAME" & Strings.Space(11) & "Date: "
        Dim strDate As String
        strDate = DateAndTime.Now
        outFile = IO.File.AppendText("\\ictsupport\data\scripts\autologon\beta\log.txt")
        outFile.WriteLine(strName.PadRight(11) & strDate)

        outFile.WriteLine(username)
        outFile.Close()

    End Sub

    Public Sub fade_in()
        For FadeIn = 0.0 To 1.1 Step 0.1
            Me.Opacity = FadeIn
            Me.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Private Sub TOOLSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TOOLSToolStripMenuItem.Click
        ' Display message box to enable registry if doing so on a windows 7 machine
        If MsgBox("Is this a Windows 7 PC?", MsgBoxStyle.YesNo, "IT Support") = MsgBoxResult.Yes Then
            Registry.MdiParent = Me
            Registry.Show()
        Else
            frmLogon.MdiParent = Me
            frmLogon.Show()
        End If


    End Sub

    Private Sub RecycleIssuetrakToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecycleIssuetrakToolStripMenuItem.Click
        ' Command to recycle issuetrak system

        Dim objprocess As New System.Diagnostics.Process
        Dim objkill As New System.Diagnostics.Process
        objprocess.StartInfo.FileName = "psexec.exe"
        objprocess.StartInfo.Arguments = "\\ictsupport c:\windows\system32\inetsrv\appcmd recycle apppool DefaultAppPool"
        objprocess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        objprocess.Start()
        objprocess.WaitForExit()
        objprocess.Close()

        objkill.StartInfo.FileName = "psexec.exe"
        objkill.StartInfo.Arguments = "\\ictsupport taskkill /f /im wscript.exe"
        objkill.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
        objkill.Start()
        objkill.WaitForExit()
        objkill.Close()

        MessageBox.Show("Issuetrak has been recycled", "Notification")

    End Sub

    Private Sub KB485QuestionsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KB485QuestionsToolStripMenuItem.Click
        frmQuestions.MdiParent = Me
        frmQuestions.Show()

    End Sub

    Private Sub JamsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JamsToolStripMenuItem.Click
        Dim jams As String = "http://ictsched01/jams/"
        Process.Start(jams)
    End Sub

    Private Sub tsAdmin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsAdmin.Click
        frmPWD.MdiParent = Me
        frmPWD.Show()

    End Sub

    Private Sub MarsCalcFixToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarsCalcFixToolStripMenuItem.Click
        MBCalc.MdiParent = Me
        MBCalc.Show()

    End Sub

    Private Sub StartRegistrySVCToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartRegistrySVCToolStripMenuItem.Click
        Registry.MdiParent = Me
        Registry.Show()
    End Sub

    Private Sub GetServiceTagToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MediaStationSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaStationSetupToolStripMenuItem.Click
        MediaSetup.MdiParent = Me
        MediaSetup.Show()

    End Sub

    Private Sub niSupport_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub ScannerStationSetupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ScannerStationSetupToolStripMenuItem.Click
        Scanner.MdiParent = Me
        Scanner.Show()

    End Sub

    Private Sub CorporateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CorporateToolStripMenuItem.Click
        frmSoftware.MdiParent = Me
        frmSoftware.Show()

    End Sub

    Private Sub StoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StoreToolStripMenuItem.Click
        frmStore.MdiParent = Me
        frmStore.Show()

    End Sub

    Private Sub StoreWoNASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub StoreWNASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripDropDownButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsPrinterSetup.Click

    End Sub

    Private Sub GetListOfInstalledSoftwareToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        frmLog.MdiParent = Me
        frmLog.Show()

    End Sub

    Private Sub ViewPrintersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GetComputerSystemInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetComputerSystemInfoToolStripMenuItem.Click
        ComputerInfo.MdiParent = Me
        ComputerInfo.Show()

    End Sub

    Private Sub FPNSETUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FPNSETUPToolStripMenuItem.Click
        New_Forms_Print.MdiParent = Me
        New_Forms_Print.Show()
    End Sub

    Private Sub RPNSETUPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RPNSETUPToolStripMenuItem.Click
        RPN.MdiParent = Me
        RPN.Show()

    End Sub

    Private Sub EasyVistaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EasyVistaToolStripMenuItem.Click
        Dim EV As String = "http://sos/"
        Process.Start(EV)
    End Sub

    Private Sub Form2TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Form2TestToolStripMenuItem.Click
        

    End Sub
End Class

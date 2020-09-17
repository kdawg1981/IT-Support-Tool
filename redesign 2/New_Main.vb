Imports System.IO
Imports System.Management
Imports System.DirectoryServices.AccountManagement
Imports System.Deployment
Imports System.Reflection


Public Class New_Main

    Private Sub Button8_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub New_Main_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' The use of function keys on the main form
        Select Case e.KeyCode
            Case Keys.F2
                btnAuto.PerformClick()
            Case Keys.F3
                btnMars.PerformClick()
            Case Keys.F4
                btnIssue.PerformClick()
            Case Keys.F5
                btnSystem.PerformClick()
            Case Keys.F6
                btnPrinter.PerformClick()
            Case Keys.F7
                btnCitrix.PerformClick()
            Case Keys.F8
                btnSrc.PerformClick()
            Case Keys.F9
                btn485Q.PerformClick()
            Case Keys.F10
                btnMediaFile.PerformClick()
        End Select
    End Sub

    Private Sub New_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Displays username at the bottom of the screen
        Dim userFullName As String = UserPrincipal.Current.DisplayName
        Dim myAssemblyname As New AssemblyName
        myAssemblyname.Version = New Version("3.0.0.3")

        Label1.Text = "IT Support Tool For" & Space(1) & userFullName
        lblName.Text = userFullName
        lblComputer.Text = Environment.MachineName
        lblDateTime.Text = DateAndTime.Now
        lblVersion.Text = "Version: " & myAssemblyname.Version.Major & "." & myAssemblyname.Version.Minor & "." & myAssemblyname.Version.Build & "." & myAssemblyname.Version.Revision






    End Sub

    Private Sub btnAuto_Click(sender As Object, e As EventArgs) Handles btnAuto.Click
        New_Autologon.Show()

    End Sub

    Private Sub btnMars_Click(sender As Object, e As EventArgs) Handles btnMars.Click
        MBCalc.Show()

    End Sub

    Private Sub btnSystem_Click(sender As Object, e As EventArgs) Handles btnSystem.Click
        frmComputer_Info.Show()

    End Sub

    Private Sub btnPrinter_Click(sender As Object, e As EventArgs) Handles btnPrinter.Click
        New_Forms_Print.Show()

    End Sub

    Private Sub btnCorp_Click(sender As Object, e As EventArgs)
        frmSoftware.Show()

    End Sub

    Private Sub btnSrc_Click(sender As Object, e As EventArgs) Handles btnSrc.Click
        frmStore.Show()

    End Sub

    Private Sub btnCitrix_Click(sender As Object, e As EventArgs) Handles btnCitrix.Click
        Citrix.Show()

    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Private Sub New_Main_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub New_Main_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub New_Main_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        AeroForm.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub btnOutage_Click(sender As Object, e As EventArgs) Handles btnOutage.Click
        Outage_Email.Show()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn485Q.Click
        frmQuestions.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnMediaFile.Click
        'new_store_push.Show()
        UK_Media_File_Push.Show()

    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs)
        Me.WindowState = FormWindowState.Minimized




    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub RedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedToolStripMenuItem.Click
        Me.BackColor = Color.DarkRed



    End Sub

    Private Sub BlueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BlueToolStripMenuItem.Click
        Me.BackColor = Color.DarkBlue

    End Sub

    Private Sub GreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GreenToolStripMenuItem.Click
        Me.BackColor = Color.DarkGreen

    End Sub

    Private Sub DefaultToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DefaultToolStripMenuItem.Click
        Me.BackColor = Color.Black
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
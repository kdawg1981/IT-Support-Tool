Public Class New_Forms_Print

    Private Sub btnMove_Click(sender As Object, e As EventArgs) Handles btnMove.Click
        lbHost.Items.AddRange(txtHost.Lines)
        txtHost.Clear()
        btnInstall.Enabled = True
    End Sub
    Public Sub RPN()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            If chkWin7.Checked = True Then

                Try
                    Dim Computer, DriverName, DriverInf7, IPAddress, PortName, PrinterName
                    Dim WMI, NewPort, NewDriver, NewPrinter, Result

                    ' Enter Details of Printer 
                    ' Computer on which to create the printer. 
                    Computer = lbHost.Items(i).ToString
                    ' The printer driver's name. 
                    DriverName = "CITIZEN CT-S4000"
                    ' The full path and filename of the .inf file.
                    DriverInf7 = "C:\Windows\inf\AddOn\CT-S4000\cts4000.inf"
                    ' The printer's IP address. 
                    IPAddress = txt_IP.Text
                    ' The printer's Name. 
                    PrinterName = txt_Name.Text
                    ' End of Details entering 

                    ' The port name that will be created. 
                    PortName = "IP_" & IPAddress

                    ' Establish WMI connection to specified computer. 
                    ' Note that the loaddriver privilege is required to add the driver. 
                    WMI = GetObject("winmgmts:{impersonationlevel=impersonate" _
                      & ",(loaddriver)}!\\" & Computer & "\root\cimv2")

                    ' Step A: Install the printer's driver. 
                    NewDriver = WMI.Get("Win32_PrinterDriver")
                    NewDriver.Name = DriverName
                    NewDriver.InfName = DriverInf7
                    Result = NewDriver.AddPrinterDriver(NewDriver)

                    MsgBox("Added printer driver: " & DriverName)

                    ' Step B: Create a TCP/IP printer port for the printer. 
                    NewPort = WMI.Get("Win32_TCPIPPrinterPort").SpawnInstance_
                    NewPort.HostAddress = IPAddress
                    NewPort.Name = PortName
                    NewPort.Protocol = 1  ' 1 = Raw, 2 = LPR 
                    NewPort.Put_()

                    MsgBox("Created printer port: " & PortName)

                    ' Step C: Add the printer. 
                    NewPrinter = WMI.Get("Win32_Printer").SpawnInstance_
                    NewPrinter.DriverName = DriverName
                    NewPrinter.DeviceID = PrinterName
                    NewPrinter.PortName = PortName
                    NewPrinter.Put_()


                    MsgBox("Created printer: " & PrinterName)


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            Else
                Try
                    Dim Computer, DriverName, DriverInf, IPAddress, PortName, PrinterName
                    Dim WMI, NewPort, NewDriver, NewPrinter, Result

                    ' Enter Details of Printer 
                    ' Computer on which to create the printer. 
                    Computer = lbHost.Items(i).ToString
                    ' The printer driver's name. 
                    DriverName = "CITIZEN CT-S4000"
                    ' The full path and filename of the .inf file.
                    DriverInf = "C:\drivers\printers\cbm - rp\CBM-4000-etho\Driver\32bit(x86)\CT-S4000\cts4000.inf"
                    ' The printer's IP address. 
                    IPAddress = txt_IP.Text
                    ' The printer's Name. 
                    PrinterName = txt_Name.Text
                    ' End of Details entering 

                    ' The port name that will be created. 
                    PortName = "IP_" & IPAddress

                    ' Establish WMI connection to specified computer. 
                    ' Note that the loaddriver privilege is required to add the driver. 
                    WMI = GetObject("winmgmts:{impersonationlevel=impersonate" _
                      & ",(loaddriver)}!\\" & Computer & "\root\cimv2")

                    ' Step A: Install the printer's driver. 
                    NewDriver = WMI.Get("Win32_PrinterDriver")
                    NewDriver.Name = DriverName
                    NewDriver.InfName = DriverInf
                    Result = NewDriver.AddPrinterDriver(NewDriver)

                    MsgBox("Added printer driver: " & DriverName)

                    ' Step B: Create a TCP/IP printer port for the printer. 
                    NewPort = WMI.Get("Win32_TCPIPPrinterPort").SpawnInstance_
                    NewPort.HostAddress = IPAddress
                    NewPort.Name = PortName
                    NewPort.Protocol = 1  ' 1 = Raw, 2 = LPR 
                    NewPort.Put_()

                    MsgBox("Created printer port: " & PortName)

                    ' Step C: Add the printer. 
                    NewPrinter = WMI.Get("Win32_Printer").SpawnInstance_
                    NewPrinter.DriverName = DriverName
                    NewPrinter.DeviceID = PrinterName
                    NewPrinter.PortName = PortName
                    NewPrinter.Put_()


                    MsgBox("Created printer: " & PrinterName)


                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End If
        Next
        MsgBox("Receipt Printers have been installed")
        lbHost.Items.Clear()
        txt_IP.Text = ""
        txt_Name.Text = ""
    End Sub
    Public Sub FPN()
        For i As Integer = 0 To Me.lbHost.Items.Count - 1
            If chkWin7.Checked = True Then

                Try
                    Dim Computer, DriverName, DriverInf7, IPAddress, PortName, PrinterName
                    Dim WMI, NewPort, NewDriver, NewPrinter, Result

                    ' Enter Details of Printer 
                    ' Computer on which to create the printer. 
                    Computer = lbHost.Items(i).ToString
                    ' The printer driver's name. 
                    DriverName = "Dell 5330dn Mono Laser Printer"
                    ' The full path and filename of the .inf file. 
                    DriverInf7 = "C:\Windows\inf\AddOn\Printers\Dell 5330dn\sdu1m.inf"
                    ' The printer's IP address. 
                    IPAddress = txt_IP.Text
                    ' The printer's Name. 
                    PrinterName = txt_Name.Text
                    ' End of Details entering 

                    ' The port name that will be created. 
                    PortName = "IP_" & IPAddress

                    ' Establish WMI connection to specified computer. 
                    ' Note that the loaddriver privilege is required to add the driver. 
                    WMI = GetObject("winmgmts:{impersonationlevel=impersonate" _
                      & ",(loaddriver)}!\\" & Computer & "\root\cimv2")

                    ' Step A: Install the printer's driver. 
                    NewDriver = WMI.Get("Win32_PrinterDriver")
                    NewDriver.Name = DriverName
                    NewDriver.InfName = DriverInf7
                    Result = NewDriver.AddPrinterDriver(NewDriver)

                    MsgBox("Added printer driver: " & DriverName)

                    ' Step B: Create a TCP/IP printer port for the printer. 
                    NewPort = WMI.Get("Win32_TCPIPPrinterPort").SpawnInstance_
                    NewPort.HostAddress = IPAddress
                    NewPort.Name = PortName
                    NewPort.Protocol = 1  ' 1 = Raw, 2 = LPR 
                    NewPort.Put_()

                    MsgBox("Created printer port: " & PortName)

                    ' Step C: Add the printer. 
                    NewPrinter = WMI.Get("Win32_Printer").SpawnInstance_
                    NewPrinter.DriverName = DriverName
                    NewPrinter.DeviceID = PrinterName
                    NewPrinter.PortName = PortName
                    NewPrinter.Put_()

                    MsgBox("Created printer: " & PrinterName)

                Catch ex As Exception

                End Try
            Else
                Try
                    Dim Computer, DriverName, DriverInf, IPAddress, PortName, PrinterName
                    Dim WMI, NewPort, NewDriver, NewPrinter, Result

                    ' Enter Details of Printer 
                    ' Computer on which to create the printer. 
                    Computer = lbHost.Items(i).ToString
                    ' The printer driver's name. 
                    DriverName = "Dell 5330dn Mono Laser Printer"
                    ' The full path and filename of the .inf file. 
                    DriverInf = "C:\drivers\printers\dell\5330\sdu1m.inf"
                    ' The printer's IP address. 
                    IPAddress = txt_IP.Text
                    ' The printer's Name. 
                    PrinterName = txt_Name.Text
                    ' End of Details entering 

                    ' The port name that will be created. 
                    PortName = "IP_" & IPAddress

                    ' Establish WMI connection to specified computer. 
                    ' Note that the loaddriver privilege is required to add the driver. 
                    WMI = GetObject("winmgmts:{impersonationlevel=impersonate" _
                      & ",(loaddriver)}!\\" & Computer & "\root\cimv2")

                    ' Step A: Install the printer's driver. 
                    NewDriver = WMI.Get("Win32_PrinterDriver")
                    NewDriver.Name = DriverName
                    NewDriver.InfName = DriverInf
                    Result = NewDriver.AddPrinterDriver(NewDriver)

                    MsgBox("Added printer driver: " & DriverName)

                    ' Step B: Create a TCP/IP printer port for the printer. 
                    NewPort = WMI.Get("Win32_TCPIPPrinterPort").SpawnInstance_
                    NewPort.HostAddress = IPAddress
                    NewPort.Name = PortName
                    NewPort.Protocol = 1  ' 1 = Raw, 2 = LPR 
                    NewPort.Put_()

                    MsgBox("Created printer port: " & PortName)

                    ' Step C: Add the printer. 
                    NewPrinter = WMI.Get("Win32_Printer").SpawnInstance_
                    NewPrinter.DriverName = DriverName
                    NewPrinter.DeviceID = PrinterName
                    NewPrinter.PortName = PortName
                    NewPrinter.Put_()

                    MsgBox("Created printer: " & PrinterName)

                Catch ex As Exception

                End Try
            End If


        Next
        MsgBox("Form Printers have been installed")
        lbHost.Items.Clear()
        txt_IP.Text = ""
        txt_Name.Text = ""
        chkWin7.Checked = False


    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        
        If rdoFPN.Checked = True Then
            FPN()
        ElseIf rdoRPN.Checked = True Then
            RPN()

        End If

    End Sub

    Private Sub btn_Close_Click(sender As Object, e As EventArgs) Handles btn_Close.Click
        Me.Close()

    End Sub

    Private Sub New_Forms_Print_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub New_Forms_Print_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub New_Forms_Print_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex

        End If
    End Sub

    Private Sub New_Forms_Print_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub
End Class
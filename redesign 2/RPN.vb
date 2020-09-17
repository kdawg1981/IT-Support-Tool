Public Class RPN

    Private Sub btnSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetup.Click
        Dim Computer, DriverName, DriverInf, IPAddress, PortName, PrinterName
        Dim WMI, NewPort, NewDriver, NewPrinter, Result

        ' Enter Details of Printer 
        ' Computer on which to create the printer. 
        Computer = txtHost.Text
        ' The printer driver's name. 
        DriverName = "CITIZEN CT-S4000"
        ' The full path and filename of the .inf file. 
        DriverInf = "C:\drivers\printers\cbm - rp\CBM-4000-etho\Driver\32bit(x86)\CT-S4000\cts4000.inf"
        ' The printer's IP address. 
        IPAddress = txtPrintIP.Text
        ' The printer's Name. 
        PrinterName = txtPrintName.Text
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

        txtHost.Text = ""
        txtPrintIP.Text = ""
        txtPrintName.Text = ""
    End Sub
End Class
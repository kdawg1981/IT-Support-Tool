Imports System
Imports System.ComponentModel
Imports System.Management
Imports System.Collections
Imports System.Globalization
Imports System.ComponentModel.Design.Serialization
Imports System.Reflection

Namespace ROOT.CIMV2
    
    'Functions ShouldSerialize<PropertyName> are functions used by VS property browser to check if a particular property has to be serialized. These functions are added for all ValueType properties ( properties of type Int32, BOOL etc.. which cannot be set to null). These functions use Is<PropertyName>Null function. These functions are also used in the TypeConverter implementation for the properties to check for NULL value of property so that an empty value can be shown in Property browser in case of Drag and Drop in Visual studio.
    'Functions Is<PropertyName>Null() are used to check if a property is NULL.
    'Functions Reset<PropertyName> are added for Nullable Read/Write properties. These functions are used by VS designer in property browser to set a property to NULL.
    'Every property added to the class for WMI property has attributes set to define its behavior in Visual Studio designer and also to define a TypeConverter to be used.
    'Datetime conversion functions ToDateTime and ToDmtfDateTime are added to the class to convert DMTF datetime to System.DateTime and vice-versa.
    'An Early Bound class generated for the WMI class.Win32_Printer
    Public Class Printer
        Inherits System.ComponentModel.Component
        
        'Private property to hold the WMI namespace in which the class resides.
        Private Shared CreatedWmiNamespace As String = "ROOT\CIMV2"
        
        'Private property to hold the name of WMI class which created this class.
        Private Shared CreatedClassName As String = "Win32_Printer"
        
        'Private member variable to hold the ManagementScope which is used by the various methods.
        Private Shared statMgmtScope As System.Management.ManagementScope = Nothing
        
        Private PrivateSystemProperties As ManagementSystemProperties
        
        'Underlying lateBound WMI object.
        Private PrivateLateBoundObject As System.Management.ManagementObject
        
        'Member variable to store the 'automatic commit' behavior for the class.
        Private AutoCommitProp As Boolean
        
        'Private variable to hold the embedded property representing the instance.
        Private embeddedObj As System.Management.ManagementBaseObject
        
        'The current WMI object used
        Private curObj As System.Management.ManagementBaseObject
        
        'Flag to indicate if the instance is an embedded object.
        Private isEmbedded As Boolean
        
        'Below are different overloads of constructors to initialize an instance of the class with a WMI object.
        Public Sub New()
            MyBase.New
            Me.InitializeObject(Nothing, Nothing, Nothing)
        End Sub
        
        Public Sub New(ByVal keyDeviceID As String)
            MyBase.New
            Me.InitializeObject(Nothing, New System.Management.ManagementPath(Printer.ConstructPath(keyDeviceID)), Nothing)
        End Sub
        
        Public Sub New(ByVal mgmtScope As System.Management.ManagementScope, ByVal keyDeviceID As String)
            MyBase.New
            Me.InitializeObject(CType(mgmtScope,System.Management.ManagementScope), New System.Management.ManagementPath(Printer.ConstructPath(keyDeviceID)), Nothing)
        End Sub
        
        Public Sub New(ByVal path As System.Management.ManagementPath, ByVal getOptions As System.Management.ObjectGetOptions)
            MyBase.New
            Me.InitializeObject(Nothing, path, getOptions)
        End Sub
        
        Public Sub New(ByVal mgmtScope As System.Management.ManagementScope, ByVal path As System.Management.ManagementPath)
            MyBase.New
            Me.InitializeObject(mgmtScope, path, Nothing)
        End Sub
        
        Public Sub New(ByVal path As System.Management.ManagementPath)
            MyBase.New
            Me.InitializeObject(Nothing, path, Nothing)
        End Sub
        
        Public Sub New(ByVal mgmtScope As System.Management.ManagementScope, ByVal path As System.Management.ManagementPath, ByVal getOptions As System.Management.ObjectGetOptions)
            MyBase.New
            Me.InitializeObject(mgmtScope, path, getOptions)
        End Sub
        
        Public Sub New(ByVal theObject As System.Management.ManagementObject)
            MyBase.New
            Initialize
            If (CheckIfProperClass(theObject) = true) Then
                PrivateLateBoundObject = theObject
                PrivateSystemProperties = New ManagementSystemProperties(PrivateLateBoundObject)
                curObj = PrivateLateBoundObject
            Else
                Throw New System.ArgumentException("Class name does not match.")
            End If
        End Sub
        
        Public Sub New(ByVal theObject As System.Management.ManagementBaseObject)
            MyBase.New
            Initialize
            If (CheckIfProperClass(theObject) = true) Then
                embeddedObj = theObject
                PrivateSystemProperties = New ManagementSystemProperties(theObject)
                curObj = embeddedObj
                isEmbedded = true
            Else
                Throw New System.ArgumentException("Class name does not match.")
            End If
        End Sub
        
        'Property returns the namespace of the WMI class.
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property OriginatingNamespace() As String
            Get
                Return "ROOT\CIMV2"
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property ManagementClassName() As String
            Get
                Dim strRet As String = CreatedClassName
                If (Not (curObj) Is Nothing) Then
                    If (Not (curObj.ClassPath) Is Nothing) Then
                        strRet = CType(curObj("__CLASS"),String)
                        If ((strRet Is Nothing)  _
                                    OrElse (strRet Is String.Empty)) Then
                            strRet = CreatedClassName
                        End If
                    End If
                End If
                Return strRet
            End Get
        End Property
        
        'Property pointing to an embedded object to get System properties of the WMI object.
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property SystemProperties() As ManagementSystemProperties
            Get
                Return PrivateSystemProperties
            End Get
        End Property
        
        'Property returning the underlying lateBound object.
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property LateBoundObject() As System.Management.ManagementBaseObject
            Get
                Return curObj
            End Get
        End Property
        
        'ManagementScope of the object.
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public Property Scope() As System.Management.ManagementScope
            Get
                If (isEmbedded = false) Then
                    Return PrivateLateBoundObject.Scope
                Else
                    Return Nothing
                End If
            End Get
            Set
                If (isEmbedded = false) Then
                    PrivateLateBoundObject.Scope = value
                End If
            End Set
        End Property
        
        'Property to show the commit behavior for the WMI object. If true, WMI object will be automatically saved after each property modification.(ie. Put() is called after modification of a property).
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public Property AutoCommit() As Boolean
            Get
                Return AutoCommitProp
            End Get
            Set
                AutoCommitProp = value
            End Set
        End Property
        
        'The ManagementPath of the underlying WMI object.
        <Browsable(true)>  _
        Public Property Path() As System.Management.ManagementPath
            Get
                If (isEmbedded = false) Then
                    Return PrivateLateBoundObject.Path
                Else
                    Return Nothing
                End If
            End Get
            Set
                If (isEmbedded = false) Then
                    If (CheckIfProperClass(Nothing, value, Nothing) <> true) Then
                        Throw New System.ArgumentException("Class name does not match.")
                    End If
                    PrivateLateBoundObject.Path = value
                End If
            End Set
        End Property
        
        'Public static scope property which is used by the various methods.
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public Shared Property StaticScope() As System.Management.ManagementScope
            Get
                Return statMgmtScope
            End Get
            Set
                statMgmtScope = value
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsAttributesNull() As Boolean
            Get
                If (curObj("Attributes") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Attributes property indicates the attributes of the Win32 printing device. Th"& _ 
            "ese attributes are represented through a combination of flags. Attributes of the"& _ 
            " printer include:"&Global.Microsoft.VisualBasic.ChrW(10)&"Queued  - Print jobs are buffered and queued."&Global.Microsoft.VisualBasic.ChrW(10)&" Direct  - Speci"& _ 
            "fies that the document should be sent directly to the printer.  This is used if "& _ 
            "print job are not being properly queued."&Global.Microsoft.VisualBasic.ChrW(10)&"Default - The printer is the default pr"& _ 
            "inter on the computer."&Global.Microsoft.VisualBasic.ChrW(10)&"Shared - Available as a shared network resource."&Global.Microsoft.VisualBasic.ChrW(10)&"Network "& _ 
            "- Attached to the network."&Global.Microsoft.VisualBasic.ChrW(10)&"Hidden - Hidden from some users on the network."&Global.Microsoft.VisualBasic.ChrW(10)&"Local"& _ 
            " - Directly connected to this computer."&Global.Microsoft.VisualBasic.ChrW(10)&"EnableDevQ - Enable the queue on the pri"& _ 
            "nter if available."&Global.Microsoft.VisualBasic.ChrW(10)&"KeepPrintedJobs - Specifies that the spooler should not delet"& _ 
            "e documents after they are printed."&Global.Microsoft.VisualBasic.ChrW(10)&"DoCompleteFirst - Start jobs that are finish"& _ 
            "ed spooling first."&Global.Microsoft.VisualBasic.ChrW(10)&"WorkOffline - Queue print jobs when printer is not available."& _ 
            ""&Global.Microsoft.VisualBasic.ChrW(10)&"EnableBIDI - Enable bi-directional printing."&Global.Microsoft.VisualBasic.ChrW(10)&"RawOnly - Allow only raw data type"& _ 
            " jobs to be spooled."&Global.Microsoft.VisualBasic.ChrW(10)&"Published - Indicates whether the printer is published in t"& _ 
            "he network directory service."&Global.Microsoft.VisualBasic.ChrW(10)),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Attributes() As AttributesValues
            Get
                If (curObj("Attributes") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(16384),AttributesValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("Attributes")),AttributesValues)
            End Get
            Set
                If (AttributesValues.NULL_ENUM_VALUE = value) Then
                    curObj("Attributes") = Nothing
                Else
                    curObj("Attributes") = value
                End If
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsAvailabilityNull() As Boolean
            Get
                If (curObj("Availability") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The availability and status of the device.  For example, the Availability propert"& _ 
            "y indicates that the device is running and has full power (value=3), or is in a "& _ 
            "warning (4), test (5), degraded (10) or power save state (values 13-15 and 17). "& _ 
            "Regarding the power saving states, these are defined as follows: Value 13 (""Powe"& _ 
            "r Save - Unknown"") indicates that the device is known to be in a power save mode"& _ 
            ", but its exact status in this mode is unknown; 14 (""Power Save - Low Power Mode"& _ 
            """) indicates that the device is in a power save state but still functioning, and"& _ 
            " may exhibit degraded performance; 15 (""Power Save - Standby"") describes that th"& _ 
            "e device is not functioning but could be brought to full power 'quickly'; and va"& _ 
            "lue 17 (""Power Save - Warning"") indicates that the device is in a warning state,"& _ 
            " though also in a power save mode."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property Availability() As AvailabilityValues
            Get
                If (curObj("Availability") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),AvailabilityValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("Availability")),AvailabilityValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Describes all of the job sheets that are available on the Printer. This can also "& _ 
            "be used to describe the banner that a Printer might provide at the beginning of "& _ 
            "each Job, or can describe other user specified options.")>  _
        Public ReadOnly Property AvailableJobSheets() As String()
            Get
                Return CType(curObj("AvailableJobSheets"),String())
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsAveragePagesPerMinuteNull() As Boolean
            Get
                If (curObj("AveragePagesPerMinute") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The AveragePagesPerMinute property specifies the rate (average number of pages pe"& _ 
            "r minute) that the printer is capable of sustaining."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property AveragePagesPerMinute() As UInteger
            Get
                If (curObj("AveragePagesPerMinute") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("AveragePagesPerMinute"),UInteger)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array of integers indicating Printer capabilities. Information such as ""Duplex"& _ 
            " Printing"" (value=3) or ""Transparency Printing"" (7) is specified in this propert"& _ 
            "y.")>  _
        Public ReadOnly Property Capabilities() As CapabilitiesValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("Capabilities"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As CapabilitiesValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),CapabilitiesValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array of free-form strings providing more detailed explanations for any of the"& _ 
            " Printer features indicated in the Capabilities array. Note, each entry of this "& _ 
            "array is related to the entry in the Capabilities array that is located at the s"& _ 
            "ame index.")>  _
        Public ReadOnly Property CapabilityDescriptions() As String()
            Get
                Return CType(curObj("CapabilityDescriptions"),String())
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Caption property is a short textual description (one-line string) of the obje"& _ 
            "ct.")>  _
        Public ReadOnly Property Caption() As String
            Get
                Return CType(curObj("Caption"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Identifies the available character sets for the output of text related to managin"& _ 
            "g the Printer. Strings provided in this property should conform to the semantics"& _ 
            " and syntax specified by section 4.1.2 (""Charset parameter"") in RFC 2046 (MIME P"& _ 
            "art 2) and contained in the IANA character-set registry. Examples include ""utf-8"& _ 
            """, ""us-ascii"" and ""iso-8859-1"".")>  _
        Public ReadOnly Property CharSetsSupported() As String()
            Get
                Return CType(curObj("CharSetsSupported"),String())
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Comment property specifies the comment of a print queue."&Global.Microsoft.VisualBasic.ChrW(10)&"Example: Color print"& _ 
            "er")>  _
        Public Property Comment() As String
            Get
                Return CType(curObj("Comment"),String)
            End Get
            Set
                curObj("Comment") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsConfigManagerErrorCodeNull() As Boolean
            Get
                If (curObj("ConfigManagerErrorCode") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates the Win32 Configuration Manager error code.  The following values may b"& _ 
            "e returned: "&Global.Microsoft.VisualBasic.ChrW(10)&"0"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is working properly. "&Global.Microsoft.VisualBasic.ChrW(10)&"1"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not configured"& _ 
            " correctly. "&Global.Microsoft.VisualBasic.ChrW(10)&"2"&Global.Microsoft.VisualBasic.ChrW(9)&"Windows cannot load the driver for this device. "&Global.Microsoft.VisualBasic.ChrW(10)&"3"&Global.Microsoft.VisualBasic.ChrW(9)&"The driver for"& _ 
            " this device might be corrupted, or your system may be running low on memory or "& _ 
            "other resources. "&Global.Microsoft.VisualBasic.ChrW(10)&"4"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not working properly. One of its drivers or y"& _ 
            "our registry might be corrupted. "&Global.Microsoft.VisualBasic.ChrW(10)&"5"&Global.Microsoft.VisualBasic.ChrW(9)&"The driver for this device needs a resource "& _ 
            "that Windows cannot manage. "&Global.Microsoft.VisualBasic.ChrW(10)&"6"&Global.Microsoft.VisualBasic.ChrW(9)&"The boot configuration for this device conflicts "& _ 
            "with other devices. "&Global.Microsoft.VisualBasic.ChrW(10)&"7"&Global.Microsoft.VisualBasic.ChrW(9)&"Cannot filter. "&Global.Microsoft.VisualBasic.ChrW(10)&"8"&Global.Microsoft.VisualBasic.ChrW(9)&"The driver loader for the device is mis"& _ 
            "sing. "&Global.Microsoft.VisualBasic.ChrW(10)&"9"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not working properly because the controlling firmware is"& _ 
            " reporting the resources for the device incorrectly. "&Global.Microsoft.VisualBasic.ChrW(10)&"10"&Global.Microsoft.VisualBasic.ChrW(9)&"This device cannot star"& _ 
            "t. "&Global.Microsoft.VisualBasic.ChrW(10)&"11"&Global.Microsoft.VisualBasic.ChrW(9)&"This device failed. "&Global.Microsoft.VisualBasic.ChrW(10)&"12"&Global.Microsoft.VisualBasic.ChrW(9)&"This device cannot find enough free resources tha"& _ 
            "t it can use. "&Global.Microsoft.VisualBasic.ChrW(10)&"13"&Global.Microsoft.VisualBasic.ChrW(9)&"Windows cannot verify this device's resources. "&Global.Microsoft.VisualBasic.ChrW(10)&"14"&Global.Microsoft.VisualBasic.ChrW(9)&"This device"& _ 
            " cannot work properly until you restart your computer. "&Global.Microsoft.VisualBasic.ChrW(10)&"15"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not wo"& _ 
            "rking properly because there is probably a re-enumeration problem. "&Global.Microsoft.VisualBasic.ChrW(10)&"16"&Global.Microsoft.VisualBasic.ChrW(9)&"Windows c"& _ 
            "annot identify all the resources this device uses. "&Global.Microsoft.VisualBasic.ChrW(10)&"17"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is asking for"& _ 
            " an unknown resource type. "&Global.Microsoft.VisualBasic.ChrW(10)&"18"&Global.Microsoft.VisualBasic.ChrW(9)&"Reinstall the drivers for this device. "&Global.Microsoft.VisualBasic.ChrW(10)&"19"&Global.Microsoft.VisualBasic.ChrW(9)&"Your r"& _ 
            "egistry might be corrupted. "&Global.Microsoft.VisualBasic.ChrW(10)&"20"&Global.Microsoft.VisualBasic.ChrW(9)&"Failure using the VxD loader. "&Global.Microsoft.VisualBasic.ChrW(10)&"21"&Global.Microsoft.VisualBasic.ChrW(9)&"System failure"& _ 
            ": Try changing the driver for this device. If that does not work, see your hardw"& _ 
            "are documentation. Windows is removing this device. "&Global.Microsoft.VisualBasic.ChrW(10)&"22"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is disabled."& _ 
            " "&Global.Microsoft.VisualBasic.ChrW(10)&"23"&Global.Microsoft.VisualBasic.ChrW(9)&"System failure: Try changing the driver for this device. If that doesn't wo"& _ 
            "rk, see your hardware documentation. "&Global.Microsoft.VisualBasic.ChrW(10)&"24"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not present, is not work"& _ 
            "ing properly, or does not have all its drivers installed. "&Global.Microsoft.VisualBasic.ChrW(10)&"25"&Global.Microsoft.VisualBasic.ChrW(9)&"Windows is still s"& _ 
            "etting up this device. "&Global.Microsoft.VisualBasic.ChrW(10)&"26"&Global.Microsoft.VisualBasic.ChrW(9)&"Windows is still setting up this device. "&Global.Microsoft.VisualBasic.ChrW(10)&"27"&Global.Microsoft.VisualBasic.ChrW(9)&"This dev"& _ 
            "ice does not have valid log configuration. "&Global.Microsoft.VisualBasic.ChrW(10)&"28"&Global.Microsoft.VisualBasic.ChrW(9)&"The drivers for this device are n"& _ 
            "ot installed. "&Global.Microsoft.VisualBasic.ChrW(10)&"29"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is disabled because the firmware of the device did"& _ 
            " not give it the required resources. "&Global.Microsoft.VisualBasic.ChrW(10)&"30"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is using an Interrupt Reque"& _ 
            "st (IRQ) resource that another device is using. "&Global.Microsoft.VisualBasic.ChrW(10)&"31"&Global.Microsoft.VisualBasic.ChrW(9)&"This device is not working p"& _ 
            "roperly because Windows cannot load the drivers required for this device."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property ConfigManagerErrorCode() As ConfigManagerErrorCodeValues
            Get
                If (curObj("ConfigManagerErrorCode") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(32),ConfigManagerErrorCodeValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("ConfigManagerErrorCode")),ConfigManagerErrorCodeValues)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsConfigManagerUserConfigNull() As Boolean
            Get
                If (curObj("ConfigManagerUserConfig") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates whether the device is using a user-defined configuration."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property ConfigManagerUserConfig() As Boolean
            Get
                If (curObj("ConfigManagerUserConfig") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("ConfigManagerUserConfig"),Boolean)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("CreationClassName indicates the name of the class or the subclass used in the cre"& _ 
            "ation of an instance. When used with the other key properties of this class, thi"& _ 
            "s property allows all instances of this class and its subclasses to be uniquely "& _ 
            "identified.")>  _
        Public ReadOnly Property CreationClassName() As String
            Get
                Return CType(curObj("CreationClassName"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies which finishings and other capabilities of the Printer are currently be"& _ 
            "ing used. An entry in this property should also be listed in the Capabilities ar"& _ 
            "ray.")>  _
        Public ReadOnly Property CurrentCapabilities() As CurrentCapabilitiesValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("CurrentCapabilities"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As CurrentCapabilitiesValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),CurrentCapabilitiesValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the current character set being used for the output of text relating to"& _ 
            " management of the Printer. The character set described by this property should "& _ 
            "also be listed in CharsetsSupported. The string specified by this property shoul"& _ 
            "d conform to the semantics and syntax specified by section 4.1.2 (""Charset param"& _ 
            "eter"") in RFC 2046 (MIME Part 2) and contained in the IANA character-set registr"& _ 
            "y. Examples include ""utf-8"", ""us-ascii"" and ""iso-8859-1"".")>  _
        Public ReadOnly Property CurrentCharSet() As String
            Get
                Return CType(curObj("CurrentCharSet"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsCurrentLanguageNull() As Boolean
            Get
                If (curObj("CurrentLanguage") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates the current printer language being used. A language that is being used "& _ 
            "by the Printer should also be listed in LanguagesSupported."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property CurrentLanguage() As CurrentLanguageValues
            Get
                If (curObj("CurrentLanguage") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),CurrentLanguageValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("CurrentLanguage")),CurrentLanguageValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the mime type currently being used by the Printer if the CurrentLanguag"& _ 
            "e is set to indicate a mime type is in use (value = 47).")>  _
        Public ReadOnly Property CurrentMimeType() As String
            Get
                Return CType(curObj("CurrentMimeType"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Identifies the current language being used by the Printer for management. The lan"& _ 
            "guage listed in the CurrentNaturalLanguage property should also be listed in Nat"& _ 
            "uralLanguagesSupported.")>  _
        Public ReadOnly Property CurrentNaturalLanguage() As String
            Get
                Return CType(curObj("CurrentNaturalLanguage"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the paper type that the Printer is currently using. The string should b"& _ 
            "e expressed in the form specified by ISO/IEC 10175 Document Printing Application"& _ 
            " (DPA) which is also summarized in Appendix C of RFC 1759 (Printer MIB).")>  _
        Public ReadOnly Property CurrentPaperType() As String
            Get
                Return CType(curObj("CurrentPaperType"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDefaultNull() As Boolean
            Get
                If (curObj("Default") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Default property indicates whether the printer is the default printer on the "& _ 
            "computer."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property [Default]() As Boolean
            Get
                If (curObj("Default") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Default"),Boolean)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies which finishings and other capabilities of the Printer will be used by "& _ 
            "default. An entry in DefaultCapabilities should also be listed in the Capabiliti"& _ 
            "es array.")>  _
        Public ReadOnly Property DefaultCapabilities() As DefaultCapabilitiesValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("DefaultCapabilities"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As DefaultCapabilitiesValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),DefaultCapabilitiesValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDefaultCopiesNull() As Boolean
            Get
                If (curObj("DefaultCopies") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The number of copies that will be produced for a single Job unless otherwise spec"& _ 
            "ified."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property DefaultCopies() As UInteger
            Get
                If (curObj("DefaultCopies") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("DefaultCopies"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDefaultLanguageNull() As Boolean
            Get
                If (curObj("DefaultLanguage") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates the default printer language. A language that is used as a default by t"& _ 
            "he Printer should also be listed in LanguagesSupported."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property DefaultLanguage() As DefaultLanguageValues
            Get
                If (curObj("DefaultLanguage") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),DefaultLanguageValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("DefaultLanguage")),DefaultLanguageValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the default mime type used by the Printer if the DefaultLanguage is set"& _ 
            " to indicate a mime type is in use (value=47).")>  _
        Public ReadOnly Property DefaultMimeType() As String
            Get
                Return CType(curObj("DefaultMimeType"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDefaultNumberUpNull() As Boolean
            Get
                If (curObj("DefaultNumberUp") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The number of print-stream pages that the Printer will render onto a single media"& _ 
            " sheet unless a Job specifies otherwise."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property DefaultNumberUp() As UInteger
            Get
                If (curObj("DefaultNumberUp") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("DefaultNumberUp"),UInteger)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the paper type that the Printer will use if a PrintJob does not specify"& _ 
            " a particular type. The string should be expressed in the form specified by ISO/"& _ 
            "IEC 10175 Document Printing Application (DPA) which is also summarized in Append"& _ 
            "ix C of RFC 1759 (Printer MIB).")>  _
        Public ReadOnly Property DefaultPaperType() As String
            Get
                Return CType(curObj("DefaultPaperType"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDefaultPriorityNull() As Boolean
            Get
                If (curObj("DefaultPriority") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The DefaultPriority property specifies the default priority value assigned to eac"& _ 
            "h print job."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property DefaultPriority() As UInteger
            Get
                If (curObj("DefaultPriority") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("DefaultPriority"),UInteger)
            End Get
            Set
                curObj("DefaultPriority") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Description property provides a textual description of the object. ")>  _
        Public ReadOnly Property Description() As String
            Get
                Return CType(curObj("Description"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDetectedErrorStateNull() As Boolean
            Get
                If (curObj("DetectedErrorState") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Printer error information."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property DetectedErrorState() As DetectedErrorStateValues
            Get
                If (curObj("DetectedErrorState") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(12),DetectedErrorStateValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("DetectedErrorState")),DetectedErrorStateValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The DeviceID property contains a string uniquely identifying the printer  with ot"& _ 
            "her devices on the system.")>  _
        Public ReadOnly Property DeviceID() As String
            Get
                Return CType(curObj("DeviceID"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDirectNull() As Boolean
            Get
                If (curObj("Direct") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Direct property indicates whether the print jobs should be sent directly to t"& _ 
            "he printer.  This means that no spool files are created for the print jobs."&Global.Microsoft.VisualBasic.ChrW(10)),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Direct() As Boolean
            Get
                If (curObj("Direct") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Direct"),Boolean)
            End Get
            Set
                curObj("Direct") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsDoCompleteFirstNull() As Boolean
            Get
                If (curObj("DoCompleteFirst") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The DoCompleteFirst property indicates whether the printer should start jobs that"& _ 
            " have finished spooling as opposed to the order of the job received."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property DoCompleteFirst() As Boolean
            Get
                If (curObj("DoCompleteFirst") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("DoCompleteFirst"),Boolean)
            End Get
            Set
                curObj("DoCompleteFirst") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The DriverName property specifies the name of the Win32 printer driver."&Global.Microsoft.VisualBasic.ChrW(10)&"Example: "& _ 
            "Windows NT Fax Driver")>  _
        Public Property DriverName() As String
            Get
                Return CType(curObj("DriverName"),String)
            End Get
            Set
                curObj("DriverName") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsEnableBIDINull() As Boolean
            Get
                If (curObj("EnableBIDI") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The EnableBIDI property indicates whether the printer can print bidirectionally."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property EnableBIDI() As Boolean
            Get
                If (curObj("EnableBIDI") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("EnableBIDI"),Boolean)
            End Get
            Set
                curObj("EnableBIDI") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsEnableDevQueryPrintNull() As Boolean
            Get
                If (curObj("EnableDevQueryPrint") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The EnableDevQueryPrint property indicates whether to hold documents in the queue"& _ 
            ", if document and printer setups do not match"),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property EnableDevQueryPrint() As Boolean
            Get
                If (curObj("EnableDevQueryPrint") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("EnableDevQueryPrint"),Boolean)
            End Get
            Set
                curObj("EnableDevQueryPrint") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsErrorClearedNull() As Boolean
            Get
                If (curObj("ErrorCleared") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("ErrorCleared is a boolean property indicating that the error reported in LastErro"& _ 
            "rCode property is now cleared."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property ErrorCleared() As Boolean
            Get
                If (curObj("ErrorCleared") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("ErrorCleared"),Boolean)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("ErrorDescription is a free-form string supplying more information about the error"& _ 
            " recorded in LastErrorCode property, and information on any corrective actions t"& _ 
            "hat may be taken.")>  _
        Public ReadOnly Property ErrorDescription() As String
            Get
                Return CType(curObj("ErrorDescription"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array providing supplemental information for the current error state, indicate"& _ 
            "d in DetectedErrorState.")>  _
        Public Property ErrorInformation() As String()
            Get
                Return CType(curObj("ErrorInformation"),String())
            End Get
            Set
                curObj("ErrorInformation") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsExtendedDetectedErrorStateNull() As Boolean
            Get
                If (curObj("ExtendedDetectedErrorState") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The ExtendedDetectedErrorState property reports standard error information.  Any "& _ 
            "additional information should be recorded in the DetecteErrorState property."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property ExtendedDetectedErrorState() As ExtendedDetectedErrorStateValues
            Get
                If (curObj("ExtendedDetectedErrorState") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(16),ExtendedDetectedErrorStateValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("ExtendedDetectedErrorState")),ExtendedDetectedErrorStateValues)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsExtendedPrinterStatusNull() As Boolean
            Get
                If (curObj("ExtendedPrinterStatus") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Status information for a Printer, beyond that specified in the LogicalDevice Avai"& _ 
            "lability property. Values include ""Idle"" (3) and an indication that the Device i"& _ 
            "s currently printing (4)."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property ExtendedPrinterStatus() As ExtendedPrinterStatusValues
            Get
                If (curObj("ExtendedPrinterStatus") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),ExtendedPrinterStatusValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("ExtendedPrinterStatus")),ExtendedPrinterStatusValues)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsHiddenNull() As Boolean
            Get
                If (curObj("Hidden") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Hidden property indicates whether the printer is hidden from network users."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Hidden() As Boolean
            Get
                If (curObj("Hidden") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Hidden"),Boolean)
            End Get
            Set
                curObj("Hidden") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsHorizontalResolutionNull() As Boolean
            Get
                If (curObj("HorizontalResolution") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Printer's horizontal resolution in Pixels per Inch."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property HorizontalResolution() As UInteger
            Get
                If (curObj("HorizontalResolution") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("HorizontalResolution"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsInstallDateNull() As Boolean
            Get
                If (curObj("InstallDate") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The InstallDate property is datetime value indicating when the object was install"& _ 
            "ed. A lack of a value does not indicate that the object is not installed."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property InstallDate() As Date
            Get
                If (Not (curObj("InstallDate")) Is Nothing) Then
                    Return ToDateTime(CType(curObj("InstallDate"),String))
                Else
                    Return Date.MinValue
                End If
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsJobCountSinceLastResetNull() As Boolean
            Get
                If (curObj("JobCountSinceLastReset") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Printer jobs processed since last reset.  These jobs may be processed from one or"& _ 
            " more PrintQueues."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property JobCountSinceLastReset() As UInteger
            Get
                If (curObj("JobCountSinceLastReset") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("JobCountSinceLastReset"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsKeepPrintedJobsNull() As Boolean
            Get
                If (curObj("KeepPrintedJobs") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The KeepPrintedJobs property indicates whether the print spooler should not delet"& _ 
            "e the jobs after they are completed."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property KeepPrintedJobs() As Boolean
            Get
                If (curObj("KeepPrintedJobs") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("KeepPrintedJobs"),Boolean)
            End Get
            Set
                curObj("KeepPrintedJobs") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array indicating the print languages natively supported.")>  _
        Public ReadOnly Property LanguagesSupported() As LanguagesSupportedValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("LanguagesSupported"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As LanguagesSupportedValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),LanguagesSupportedValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsLastErrorCodeNull() As Boolean
            Get
                If (curObj("LastErrorCode") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("LastErrorCode captures the last error code reported by the logical device."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property LastErrorCode() As UInteger
            Get
                If (curObj("LastErrorCode") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("LastErrorCode"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsLocalNull() As Boolean
            Get
                If (curObj("Local") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Local property indicates whether the printer is attached to the network.  A m"& _ 
            "asquerading printer is printer that is implemented as local printers but has a p"& _ 
            "ort that refers to a remote machine.  From the application perspective these hyb"& _ 
            "rid printers should be viewed as printer connections since that is their intende"& _ 
            "d behavior."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Local() As Boolean
            Get
                If (curObj("Local") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Local"),Boolean)
            End Get
            Set
                curObj("Local") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Location property specifies the physical location of the printer."&Global.Microsoft.VisualBasic.ChrW(10)&"Example: Bl"& _ 
            "dg. 38, Room 1164")>  _
        Public Property Location() As String
            Get
                Return CType(curObj("Location"),String)
            End Get
            Set
                curObj("Location") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsMarkingTechnologyNull() As Boolean
            Get
                If (curObj("MarkingTechnology") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the marking technology used by the Printer."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property MarkingTechnology() As MarkingTechnologyValues
            Get
                If (curObj("MarkingTechnology") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),MarkingTechnologyValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("MarkingTechnology")),MarkingTechnologyValues)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsMaxCopiesNull() As Boolean
            Get
                If (curObj("MaxCopies") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The maximum number of copies that can be produced by the Printer from a single Jo"& _ 
            "b."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property MaxCopies() As UInteger
            Get
                If (curObj("MaxCopies") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("MaxCopies"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsMaxNumberUpNull() As Boolean
            Get
                If (curObj("MaxNumberUp") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The maximum number of print-stream pages that the Printer can render onto a singl"& _ 
            "e media sheet."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property MaxNumberUp() As UInteger
            Get
                If (curObj("MaxNumberUp") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("MaxNumberUp"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsMaxSizeSupportedNull() As Boolean
            Get
                If (curObj("MaxSizeSupported") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Specifies the largest Job (as a byte stream) that the Printer will accept in unit"& _ 
            "s of Kbytes. A value of zero indicates that no limit has been set."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property MaxSizeSupported() As UInteger
            Get
                If (curObj("MaxSizeSupported") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("MaxSizeSupported"),UInteger)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array of free-form strings providing more detailed explanations of any mime ty"& _ 
            "pes that are supported by the Printer. If data is provided for this property, th"& _ 
            "en the value 47, ""Mime"", should be included in the LanguagesSupported property.")>  _
        Public ReadOnly Property MimeTypesSupported() As String()
            Get
                Return CType(curObj("MimeTypesSupported"),String())
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Name property defines the label by which the object is known. When subclassed"& _ 
            ", the Name property can be overridden to be a Key property.")>  _
        Public ReadOnly Property Name() As String
            Get
                Return CType(curObj("Name"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Identifies the available languages for strings used by the Printer for the output"& _ 
            " of management information. The strings should conform to RFC 1766, for example "& _ 
            """en"" is used for English.")>  _
        Public ReadOnly Property NaturalLanguagesSupported() As String()
            Get
                Return CType(curObj("NaturalLanguagesSupported"),String())
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsNetworkNull() As Boolean
            Get
                If (curObj("Network") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Network property indicates whether the printer is a network printer."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Network() As Boolean
            Get
                If (curObj("Network") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Network"),Boolean)
            End Get
            Set
                curObj("Network") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An integer array indicating the types of paper supported.")>  _
        Public ReadOnly Property PaperSizesSupported() As PaperSizesSupportedValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("PaperSizesSupported"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As PaperSizesSupportedValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),PaperSizesSupportedValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("An array of free-form strings specifying the types of paper that are currently av"& _ 
            "ailable on the Printer. Each string should be expressed in the form specified by"& _ 
            " ISO/IEC 10175 Document Printing Application (DPA) which is also summarized in A"& _ 
            "ppendix C of RFC 1759 (Printer MIB). Examples of valid strings are ""iso-a4-color"& _ 
            "ed"" and ""na-10x14-envelope"". By definition a paper size that is available and li"& _ 
            "sted in PaperTypesAvailable should also appear in the PaperSizesSupported proper"& _ 
            "ty.")>  _
        Public ReadOnly Property PaperTypesAvailable() As String()
            Get
                Return CType(curObj("PaperTypesAvailable"),String())
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Parameters property specifies optional parameters for the print processor."&Global.Microsoft.VisualBasic.ChrW(10)&"Ex"& _ 
            "ample: Copies=2")>  _
        Public Property Parameters() As String
            Get
                Return CType(curObj("Parameters"),String)
            End Get
            Set
                curObj("Parameters") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates the Win32 Plug and Play device ID of the logical device.  Example: *PNP"& _ 
            "030b")>  _
        Public ReadOnly Property PNPDeviceID() As String
            Get
                Return CType(curObj("PNPDeviceID"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The PortName property identifies the ports that can be used to transmit data to t"& _ 
            "he printer. If a printer is connected to more than one port, the names of each p"& _ 
            "ort are separated by commas. Under Windows 95, only one port can be specified. "&Global.Microsoft.VisualBasic.ChrW(10)& _ 
            "Example: LPT1:, LPT2:, LPT3:")>  _
        Public Property PortName() As String
            Get
                Return CType(curObj("PortName"),String)
            End Get
            Set
                curObj("PortName") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Indicates the specific power-related capabilities of the logical device. The arra"& _ 
            "y values, 0=""Unknown"", 1=""Not Supported"" and 2=""Disabled"" are self-explanatory. "& _ 
            "The value, 3=""Enabled"" indicates that the power management features are currentl"& _ 
            "y enabled but the exact feature set is unknown or the information is unavailable"& _ 
            ". ""Power Saving Modes Entered Automatically"" (4) describes that a device can cha"& _ 
            "nge its power state based on usage or other criteria. ""Power State Settable"" (5)"& _ 
            " indicates that the SetPowerState method is supported. ""Power Cycling Supported"""& _ 
            " (6) indicates that the SetPowerState method can be invoked with the PowerState "& _ 
            "input variable set to 5 (""Power Cycle""). ""Timed Power On Supported"" (7) indicate"& _ 
            "s that the SetPowerState method can be invoked with the PowerState input variabl"& _ 
            "e set to 5 (""Power Cycle"") and the Time parameter set to a specific date and tim"& _ 
            "e, or interval, for power-on.")>  _
        Public ReadOnly Property PowerManagementCapabilities() As PowerManagementCapabilitiesValues()
            Get
                Dim arrEnumVals As System.Array = CType(curObj("PowerManagementCapabilities"),System.Array)
                Dim enumToRet((arrEnumVals.Length) - 1) As PowerManagementCapabilitiesValues
                Dim counter As Integer = 0
                counter = 0
                Do While (counter < arrEnumVals.Length)
                    enumToRet(counter) = CType(System.Convert.ToInt32(arrEnumVals.GetValue(counter)),PowerManagementCapabilitiesValues)
                    counter = (counter + 1)
                Loop
                Return enumToRet
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsPowerManagementSupportedNull() As Boolean
            Get
                If (curObj("PowerManagementSupported") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Boolean indicating that the Device can be power managed - ie, put into a power sa"& _ 
            "ve state. This boolean does not indicate that power management features are curr"& _ 
            "ently enabled, or if enabled, what features are supported. Refer to the PowerMan"& _ 
            "agementCapabilities array for this information. If this boolean is false, the in"& _ 
            "teger value 1, for the string, ""Not Supported"", should be the only entry in the "& _ 
            "PowerManagementCapabilities array."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property PowerManagementSupported() As Boolean
            Get
                If (curObj("PowerManagementSupported") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("PowerManagementSupported"),Boolean)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The PrinterPaperNames property indicates the list of paper sizes supported by the"& _ 
            " printer. The printer-specified names are used to represent supported paper size"& _ 
            "s."&Global.Microsoft.VisualBasic.ChrW(10)&"Example: B5 (JIS).")>  _
        Public ReadOnly Property PrinterPaperNames() As String()
            Get
                Return CType(curObj("PrinterPaperNames"),String())
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsPrinterStateNull() As Boolean
            Get
                If (curObj("PrinterState") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("This property has been deprecated in favor of PrinterStatus, DetectedErrorState a"& _ 
            "nd ErrorInformation CIM properties that more clearly indicate the state and erro"& _ 
            "r status of the printer. The PrinterState property specifies a values indicating"& _ 
            " one of the possible states relating to this printer."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property PrinterState() As PrinterStateValues
            Get
                If (curObj("PrinterState") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(25),PrinterStateValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("PrinterState")),PrinterStateValues)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsPrinterStatusNull() As Boolean
            Get
                If (curObj("PrinterStatus") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Status information for a Printer, beyond that specified in the LogicalDevice Avai"& _ 
            "lability property. Values include ""Idle"" (3) and an indication that the Device i"& _ 
            "s currently printing (4)."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property PrinterStatus() As PrinterStatusValues
            Get
                If (curObj("PrinterStatus") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),PrinterStatusValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("PrinterStatus")),PrinterStatusValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The PrintJobDataType property indicates the default data type that will be used f"& _ 
            "or a print job.")>  _
        Public Property PrintJobDataType() As String
            Get
                Return CType(curObj("PrintJobDataType"),String)
            End Get
            Set
                curObj("PrintJobDataType") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The PrintProcessor property specifies the name of the print spooler that handles "& _ 
            "print jobs."&Global.Microsoft.VisualBasic.ChrW(10)&"Example: SPOOLSS.DLL.")>  _
        Public Property PrintProcessor() As String
            Get
                Return CType(curObj("PrintProcessor"),String)
            End Get
            Set
                curObj("PrintProcessor") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsPriorityNull() As Boolean
            Get
                If (curObj("Priority") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Priority property specifies the priority of the  printer. The jobs on a highe"& _ 
            "r priority printer are scheduled first."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Priority() As UInteger
            Get
                If (curObj("Priority") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("Priority"),UInteger)
            End Get
            Set
                curObj("Priority") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsPublishedNull() As Boolean
            Get
                If (curObj("Published") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Published property indicates whether the printer is published in the network "& _ 
            "directory service."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Published() As Boolean
            Get
                If (curObj("Published") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Published"),Boolean)
            End Get
            Set
                curObj("Published") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsQueuedNull() As Boolean
            Get
                If (curObj("Queued") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Queued property indicates whether the printer buffers and queues print jobs."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property Queued() As Boolean
            Get
                If (curObj("Queued") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Queued"),Boolean)
            End Get
            Set
                curObj("Queued") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsRawOnlyNull() As Boolean
            Get
                If (curObj("RawOnly") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The RawOnly property indicates whether the printer accepts only raw data to be sp"& _ 
            "ooled."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property RawOnly() As Boolean
            Get
                If (curObj("RawOnly") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("RawOnly"),Boolean)
            End Get
            Set
                curObj("RawOnly") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The SeparatorFile property specifies the name of the file used to create a separa"& _ 
            "tor page. This page is used to separate print jobs sent to the printer.")>  _
        Public Property SeparatorFile() As String
            Get
                Return CType(curObj("SeparatorFile"),String)
            End Get
            Set
                curObj("SeparatorFile") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The ServerName property identifies the server that controls the printer. If this "& _ 
            "string is NULL, the printer is controlled locally. ")>  _
        Public ReadOnly Property ServerName() As String
            Get
                Return CType(curObj("ServerName"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsSharedNull() As Boolean
            Get
                If (curObj("Shared") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Shared property indicates whether the printer is available as a shared networ"& _ 
            "k resource."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property [Shared]() As Boolean
            Get
                If (curObj("Shared") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("Shared"),Boolean)
            End Get
            Set
                curObj("Shared") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The ShareName property indicates the share name of the Win32 printing device."&Global.Microsoft.VisualBasic.ChrW(10)&"Exa"& _ 
            "mple: \\PRINTSERVER1\PRINTER2")>  _
        Public Property ShareName() As String
            Get
                Return CType(curObj("ShareName"),String)
            End Get
            Set
                curObj("ShareName") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsSpoolEnabledNull() As Boolean
            Get
                If (curObj("SpoolEnabled") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The SpoolEnabled property shows whether spooling is enabled for this printer. "&Global.Microsoft.VisualBasic.ChrW(10)&"Va"& _ 
            "lues:TRUE or FALSE. "&Global.Microsoft.VisualBasic.ChrW(10)&"The SpoolEnabled property has been deprecated.  There is no"& _ 
            " replacementvalue and this property is now considered obsolete."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property SpoolEnabled() As Boolean
            Get
                If (curObj("SpoolEnabled") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("SpoolEnabled"),Boolean)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsStartTimeNull() As Boolean
            Get
                If (curObj("StartTime") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The StartTime property specifies the earliest time the printer can print a job (i"& _ 
            "f the printer has been limited to print only at certain times). This value is ex"& _ 
            "pressed as time elapsed since 12:00 AM GMT (Greenwich mean time)."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property StartTime() As Date
            Get
                If (Not (curObj("StartTime")) Is Nothing) Then
                    Return ToDateTime(CType(curObj("StartTime"),String))
                Else
                    Return Date.MinValue
                End If
            End Get
            Set
                curObj("StartTime") = ToDmtfDateTime(CType(value,Date))
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The Status property is a string indicating the current status of the object. Vari"& _ 
            "ous operational and non-operational statuses can be defined. Operational statuse"& _ 
            "s are ""OK"", ""Degraded"" and ""Pred Fail"". ""Pred Fail"" indicates that an element ma"& _ 
            "y be functioning properly but predicting a failure in the near future. An exampl"& _ 
            "e is a SMART-enabled hard drive. Non-operational statuses can also be specified."& _ 
            " These are ""Error"", ""Starting"", ""Stopping"" and ""Service"". The latter, ""Service"","& _ 
            " could apply during mirror-resilvering of a disk, reload of a user permissions l"& _ 
            "ist, or other administrative work. Not all such work is on-line, yet the managed"& _ 
            " element is neither ""OK"" nor in one of the other states.")>  _
        Public ReadOnly Property Status() As String
            Get
                Return CType(curObj("Status"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsStatusInfoNull() As Boolean
            Get
                If (curObj("StatusInfo") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("StatusInfo is a string indicating whether the logical device is in an enabled (va"& _ 
            "lue = 3), disabled (value = 4) or some other (1) or unknown (2) state. If this p"& _ 
            "roperty does not apply to the logical device, the value, 5 (""Not Applicable""), s"& _ 
            "hould be used."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property StatusInfo() As StatusInfoValues
            Get
                If (curObj("StatusInfo") Is Nothing) Then
                    Return CType(System.Convert.ToInt32(0),StatusInfoValues)
                End If
                Return CType(System.Convert.ToInt32(curObj("StatusInfo")),StatusInfoValues)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The scoping System's CreationClassName.")>  _
        Public ReadOnly Property SystemCreationClassName() As String
            Get
                Return CType(curObj("SystemCreationClassName"),String)
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The scoping System's Name.")>  _
        Public ReadOnly Property SystemName() As String
            Get
                Return CType(curObj("SystemName"),String)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsTimeOfLastResetNull() As Boolean
            Get
                If (curObj("TimeOfLastReset") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Time of last reset of the Printer Device."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property TimeOfLastReset() As Date
            Get
                If (Not (curObj("TimeOfLastReset")) Is Nothing) Then
                    Return ToDateTime(CType(curObj("TimeOfLastReset"),String))
                Else
                    Return Date.MinValue
                End If
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsUntilTimeNull() As Boolean
            Get
                If (curObj("UntilTime") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The UntilTime property specifies the latest time the printer can print a job (if "& _ 
            "the printer has been limited to print only at certain times). This value is expr"& _ 
            "essed as time elapsed since 12:00 AM GMT (Greenwich mean time)."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property UntilTime() As Date
            Get
                If (Not (curObj("UntilTime")) Is Nothing) Then
                    Return ToDateTime(CType(curObj("UntilTime"),String))
                Else
                    Return Date.MinValue
                End If
            End Get
            Set
                curObj("UntilTime") = ToDmtfDateTime(CType(value,Date))
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsVerticalResolutionNull() As Boolean
            Get
                If (curObj("VerticalResolution") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("Printer's vertical resolution in Pixels per Inch."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public ReadOnly Property VerticalResolution() As UInteger
            Get
                If (curObj("VerticalResolution") Is Nothing) Then
                    Return System.Convert.ToUInt32(0)
                End If
                Return CType(curObj("VerticalResolution"),UInteger)
            End Get
        End Property
        
        <Browsable(false),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>  _
        Public ReadOnly Property IsWorkOfflineNull() As Boolean
            Get
                If (curObj("WorkOffline") Is Nothing) Then
                    Return true
                Else
                    Return false
                End If
            End Get
        End Property
        
        <Browsable(true),  _
         DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden),  _
         Description("The WorkOffline property indicates whether to queue print jobs on the computer if"& _ 
            " the printer is offline."),  _
         TypeConverter(GetType(WMIValueTypeConverter))>  _
        Public Property WorkOffline() As Boolean
            Get
                If (curObj("WorkOffline") Is Nothing) Then
                    Return System.Convert.ToBoolean(0)
                End If
                Return CType(curObj("WorkOffline"),Boolean)
            End Get
            Set
                curObj("WorkOffline") = value
                If ((isEmbedded = false)  _
                            AndAlso (AutoCommitProp = true)) Then
                    PrivateLateBoundObject.Put
                End If
            End Set
        End Property
        
        Private Overloads Function CheckIfProperClass(ByVal mgmtScope As System.Management.ManagementScope, ByVal path As System.Management.ManagementPath, ByVal OptionsParam As System.Management.ObjectGetOptions) As Boolean
            If ((Not (path) Is Nothing)  _
                        AndAlso (String.Compare(path.ClassName, Me.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) = 0)) Then
                Return true
            Else
                Return CheckIfProperClass(New System.Management.ManagementObject(mgmtScope, path, OptionsParam))
            End If
        End Function
        
        Private Overloads Function CheckIfProperClass(ByVal theObj As System.Management.ManagementBaseObject) As Boolean
            If ((Not (theObj) Is Nothing)  _
                        AndAlso (String.Compare(CType(theObj("__CLASS"),String), Me.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) = 0)) Then
                Return true
            Else
                Dim parentClasses As System.Array = CType(theObj("__DERIVATION"),System.Array)
                If (Not (parentClasses) Is Nothing) Then
                    Dim count As Integer = 0
                    count = 0
                    Do While (count < parentClasses.Length)
                        If (String.Compare(CType(parentClasses.GetValue(count),String), Me.ManagementClassName, true, System.Globalization.CultureInfo.InvariantCulture) = 0) Then
                            Return true
                        End If
                        count = (count + 1)
                    Loop
                End If
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeAttributes() As Boolean
            If (Me.IsAttributesNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetAttributes()
            curObj("Attributes") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeAvailability() As Boolean
            If (Me.IsAvailabilityNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeAveragePagesPerMinute() As Boolean
            If (Me.IsAveragePagesPerMinuteNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetComment()
            curObj("Comment") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeConfigManagerErrorCode() As Boolean
            If (Me.IsConfigManagerErrorCodeNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeConfigManagerUserConfig() As Boolean
            If (Me.IsConfigManagerUserConfigNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeCurrentLanguage() As Boolean
            If (Me.IsCurrentLanguageNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDefault() As Boolean
            If (Me.IsDefaultNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDefaultCopies() As Boolean
            If (Me.IsDefaultCopiesNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDefaultLanguage() As Boolean
            If (Me.IsDefaultLanguageNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDefaultNumberUp() As Boolean
            If (Me.IsDefaultNumberUpNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDefaultPriority() As Boolean
            If (Me.IsDefaultPriorityNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetDefaultPriority()
            curObj("DefaultPriority") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeDetectedErrorState() As Boolean
            If (Me.IsDetectedErrorStateNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeDirect() As Boolean
            If (Me.IsDirectNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetDirect()
            curObj("Direct") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeDoCompleteFirst() As Boolean
            If (Me.IsDoCompleteFirstNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetDoCompleteFirst()
            curObj("DoCompleteFirst") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetDriverName()
            curObj("DriverName") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeEnableBIDI() As Boolean
            If (Me.IsEnableBIDINull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetEnableBIDI()
            curObj("EnableBIDI") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeEnableDevQueryPrint() As Boolean
            If (Me.IsEnableDevQueryPrintNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetEnableDevQueryPrint()
            curObj("EnableDevQueryPrint") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeErrorCleared() As Boolean
            If (Me.IsErrorClearedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetErrorInformation()
            curObj("ErrorInformation") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeExtendedDetectedErrorState() As Boolean
            If (Me.IsExtendedDetectedErrorStateNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeExtendedPrinterStatus() As Boolean
            If (Me.IsExtendedPrinterStatusNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeHidden() As Boolean
            If (Me.IsHiddenNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetHidden()
            curObj("Hidden") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeHorizontalResolution() As Boolean
            If (Me.IsHorizontalResolutionNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        'Converts a given datetime in DMTF format to System.DateTime object.
        Shared Function ToDateTime(ByVal dmtfDate As String) As Date
            Dim initializer As Date = Date.MinValue
            Dim year As Integer = initializer.Year
            Dim month As Integer = initializer.Month
            Dim day As Integer = initializer.Day
            Dim hour As Integer = initializer.Hour
            Dim minute As Integer = initializer.Minute
            Dim second As Integer = initializer.Second
            Dim ticks As Long = 0
            Dim dmtf As String = dmtfDate
            Dim datetime As Date = Date.MinValue
            Dim tempString As String = String.Empty
            If (dmtf Is Nothing) Then
                Throw New System.ArgumentOutOfRangeException()
            End If
            If (dmtf.Length = 0) Then
                Throw New System.ArgumentOutOfRangeException()
            End If
            If (dmtf.Length <> 25) Then
                Throw New System.ArgumentOutOfRangeException()
            End If
            Try 
                tempString = dmtf.Substring(0, 4)
                If ("****" <> tempString) Then
                    year = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(4, 2)
                If ("**" <> tempString) Then
                    month = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(6, 2)
                If ("**" <> tempString) Then
                    day = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(8, 2)
                If ("**" <> tempString) Then
                    hour = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(10, 2)
                If ("**" <> tempString) Then
                    minute = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(12, 2)
                If ("**" <> tempString) Then
                    second = Integer.Parse(tempString)
                End If
                tempString = dmtf.Substring(15, 6)
                If ("******" <> tempString) Then
                    ticks = (Long.Parse(tempString) * CType((System.TimeSpan.TicksPerMillisecond / 1000),Long))
                End If
                If ((((((((year < 0)  _
                            OrElse (month < 0))  _
                            OrElse (day < 0))  _
                            OrElse (hour < 0))  _
                            OrElse (minute < 0))  _
                            OrElse (minute < 0))  _
                            OrElse (second < 0))  _
                            OrElse (ticks < 0)) Then
                    Throw New System.ArgumentOutOfRangeException()
                End If
            Catch e As System.Exception
                Throw New System.ArgumentOutOfRangeException(Nothing, e.Message)
            End Try
            datetime = New Date(year, month, day, hour, minute, second, 0)
            datetime = datetime.AddTicks(ticks)
            Dim tickOffset As System.TimeSpan = System.TimeZone.CurrentTimeZone.GetUtcOffset(datetime)
            Dim UTCOffset As Integer = 0
            Dim OffsetToBeAdjusted As Integer = 0
            Dim OffsetMins As Long = CType((tickOffset.Ticks / System.TimeSpan.TicksPerMinute),Long)
            tempString = dmtf.Substring(22, 3)
            If (tempString <> "******") Then
                tempString = dmtf.Substring(21, 4)
                Try 
                    UTCOffset = Integer.Parse(tempString)
                Catch e As System.Exception
                    Throw New System.ArgumentOutOfRangeException(Nothing, e.Message)
                End Try
                OffsetToBeAdjusted = CType((OffsetMins - UTCOffset),Integer)
                datetime = datetime.AddMinutes(CType(OffsetToBeAdjusted,Double))
            End If
            Return datetime
        End Function
        
        'Converts a given System.DateTime object to DMTF datetime format.
        Shared Function ToDmtfDateTime(ByVal [date] As Date) As String
            Dim utcString As String = String.Empty
            Dim tickOffset As System.TimeSpan = System.TimeZone.CurrentTimeZone.GetUtcOffset([date])
            Dim OffsetMins As Long = CType((tickOffset.Ticks / System.TimeSpan.TicksPerMinute),Long)
            If (System.Math.Abs(OffsetMins) > 999) Then
                [date] = [date].ToUniversalTime
                utcString = "+000"
            Else
                If (tickOffset.Ticks >= 0) Then
                    utcString = String.Concat("+", CType((tickOffset.Ticks / System.TimeSpan.TicksPerMinute),System.Int64 ).ToString.PadLeft(3, Global.Microsoft.VisualBasic.ChrW(48)))
                Else
                    Dim strTemp As String = CType(OffsetMins,System.Int64 ).ToString
                    utcString = String.Concat("-", strTemp.Substring(1, (strTemp.Length - 1)).PadLeft(3, Global.Microsoft.VisualBasic.ChrW(48)))
                End If
            End If
            Dim dmtfDateTime As String = CType([date].Year,System.Int32 ).ToString.PadLeft(4, Global.Microsoft.VisualBasic.ChrW(48))
            dmtfDateTime = String.Concat(dmtfDateTime, CType([date].Month,System.Int32 ).ToString.PadLeft(2, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, CType([date].Day,System.Int32 ).ToString.PadLeft(2, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, CType([date].Hour,System.Int32 ).ToString.PadLeft(2, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, CType([date].Minute,System.Int32 ).ToString.PadLeft(2, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, CType([date].Second,System.Int32 ).ToString.PadLeft(2, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, ".")
            Dim dtTemp As Date = New Date([date].Year, [date].Month, [date].Day, [date].Hour, [date].Minute, [date].Second, 0)
            Dim microsec As Long = CType(((([date].Ticks - dtTemp.Ticks)  _
                        * 1000)  _
                        / System.TimeSpan.TicksPerMillisecond),Long)
            Dim strMicrosec As String = CType(microsec,System.Int64 ).ToString
            If (strMicrosec.Length > 6) Then
                strMicrosec = strMicrosec.Substring(0, 6)
            End If
            dmtfDateTime = String.Concat(dmtfDateTime, strMicrosec.PadLeft(6, Global.Microsoft.VisualBasic.ChrW(48)))
            dmtfDateTime = String.Concat(dmtfDateTime, utcString)
            Return dmtfDateTime
        End Function
        
        Private Function ShouldSerializeInstallDate() As Boolean
            If (Me.IsInstallDateNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeJobCountSinceLastReset() As Boolean
            If (Me.IsJobCountSinceLastResetNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeKeepPrintedJobs() As Boolean
            If (Me.IsKeepPrintedJobsNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetKeepPrintedJobs()
            curObj("KeepPrintedJobs") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeLastErrorCode() As Boolean
            If (Me.IsLastErrorCodeNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeLocal() As Boolean
            If (Me.IsLocalNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetLocal()
            curObj("Local") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetLocation()
            curObj("Location") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeMarkingTechnology() As Boolean
            If (Me.IsMarkingTechnologyNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeMaxCopies() As Boolean
            If (Me.IsMaxCopiesNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeMaxNumberUp() As Boolean
            If (Me.IsMaxNumberUpNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeMaxSizeSupported() As Boolean
            If (Me.IsMaxSizeSupportedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeNetwork() As Boolean
            If (Me.IsNetworkNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetNetwork()
            curObj("Network") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetParameters()
            curObj("Parameters") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetPortName()
            curObj("PortName") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializePowerManagementSupported() As Boolean
            If (Me.IsPowerManagementSupportedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializePrinterState() As Boolean
            If (Me.IsPrinterStateNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializePrinterStatus() As Boolean
            If (Me.IsPrinterStatusNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetPrintJobDataType()
            curObj("PrintJobDataType") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetPrintProcessor()
            curObj("PrintProcessor") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializePriority() As Boolean
            If (Me.IsPriorityNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetPriority()
            curObj("Priority") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializePublished() As Boolean
            If (Me.IsPublishedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetPublished()
            curObj("Published") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeQueued() As Boolean
            If (Me.IsQueuedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetQueued()
            curObj("Queued") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeRawOnly() As Boolean
            If (Me.IsRawOnlyNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetRawOnly()
            curObj("RawOnly") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetSeparatorFile()
            curObj("SeparatorFile") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeShared() As Boolean
            If (Me.IsSharedNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetShared()
            curObj("Shared") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Sub ResetShareName()
            curObj("ShareName") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeSpoolEnabled() As Boolean
            If (Me.IsSpoolEnabledNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeStartTime() As Boolean
            If (Me.IsStartTimeNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetStartTime()
            curObj("StartTime") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeStatusInfo() As Boolean
            If (Me.IsStatusInfoNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeTimeOfLastReset() As Boolean
            If (Me.IsTimeOfLastResetNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeUntilTime() As Boolean
            If (Me.IsUntilTimeNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetUntilTime()
            curObj("UntilTime") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        Private Function ShouldSerializeVerticalResolution() As Boolean
            If (Me.IsVerticalResolutionNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Function ShouldSerializeWorkOffline() As Boolean
            If (Me.IsWorkOfflineNull = false) Then
                Return true
            End If
            Return false
        End Function
        
        Private Sub ResetWorkOffline()
            curObj("WorkOffline") = Nothing
            If ((isEmbedded = false)  _
                        AndAlso (AutoCommitProp = true)) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        <Browsable(true)>  _
        Public Overloads Sub CommitObject()
            If (isEmbedded = false) Then
                PrivateLateBoundObject.Put
            End If
        End Sub
        
        <Browsable(true)>  _
        Public Overloads Sub CommitObject(ByVal putOptions As System.Management.PutOptions)
            If (isEmbedded = false) Then
                PrivateLateBoundObject.Put(putOptions)
            End If
        End Sub
        
        Private Sub Initialize()
            AutoCommitProp = true
            isEmbedded = false
        End Sub
        
        Private Shared Function ConstructPath(ByVal keyDeviceID As String) As String
            Dim strPath As String = "ROOT\CIMV2:Win32_Printer"
            strPath = String.Concat(strPath, String.Concat(".DeviceID=", String.Concat("""", String.Concat(keyDeviceID, """"))))
            Return strPath
        End Function
        
        Private Sub InitializeObject(ByVal mgmtScope As System.Management.ManagementScope, ByVal path As System.Management.ManagementPath, ByVal getOptions As System.Management.ObjectGetOptions)
            Initialize
            If (Not (path) Is Nothing) Then
                If (CheckIfProperClass(mgmtScope, path, getOptions) <> true) Then
                    Throw New System.ArgumentException("Class name does not match.")
                End If
            End If
            PrivateLateBoundObject = New System.Management.ManagementObject(mgmtScope, path, getOptions)
            PrivateSystemProperties = New ManagementSystemProperties(PrivateLateBoundObject)
            curObj = PrivateLateBoundObject
        End Sub
        
        'Different overloads of GetInstances() help in enumerating instances of the WMI class.
        Public Overloads Shared Function GetInstances() As PrinterCollection
            Return GetInstances(Nothing, Nothing, Nothing)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal condition As String) As PrinterCollection
            Return GetInstances(Nothing, condition, Nothing)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal selectedProperties() As System.String ) As PrinterCollection
            Return GetInstances(Nothing, Nothing, selectedProperties)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal condition As String, ByVal selectedProperties() As System.String ) As PrinterCollection
            Return GetInstances(Nothing, condition, selectedProperties)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal mgmtScope As System.Management.ManagementScope, ByVal enumOptions As System.Management.EnumerationOptions) As PrinterCollection
            If (mgmtScope Is Nothing) Then
                If (statMgmtScope Is Nothing) Then
                    mgmtScope = New System.Management.ManagementScope()
                    mgmtScope.Path.NamespacePath = "root\CIMV2"
                Else
                    mgmtScope = statMgmtScope
                End If
            End If
            Dim pathObj As System.Management.ManagementPath = New System.Management.ManagementPath()
            pathObj.ClassName = "Win32_Printer"
            pathObj.NamespacePath = "root\CIMV2"
            Dim clsObject As System.Management.ManagementClass = New System.Management.ManagementClass(mgmtScope, pathObj, Nothing)
            If (enumOptions Is Nothing) Then
                enumOptions = New System.Management.EnumerationOptions()
                enumOptions.EnsureLocatable = true
            End If
            Return New PrinterCollection(clsObject.GetInstances(enumOptions))
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal mgmtScope As System.Management.ManagementScope, ByVal condition As String) As PrinterCollection
            Return GetInstances(mgmtScope, condition, Nothing)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal mgmtScope As System.Management.ManagementScope, ByVal selectedProperties() As System.String ) As PrinterCollection
            Return GetInstances(mgmtScope, Nothing, selectedProperties)
        End Function
        
        Public Overloads Shared Function GetInstances(ByVal mgmtScope As System.Management.ManagementScope, ByVal condition As String, ByVal selectedProperties() As System.String ) As PrinterCollection
            If (mgmtScope Is Nothing) Then
                If (statMgmtScope Is Nothing) Then
                    mgmtScope = New System.Management.ManagementScope()
                    mgmtScope.Path.NamespacePath = "root\CIMV2"
                Else
                    mgmtScope = statMgmtScope
                End If
            End If
            Dim ObjectSearcher As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher(mgmtScope, New SelectQuery("Win32_Printer", condition, selectedProperties))
            Dim enumOptions As System.Management.EnumerationOptions = New System.Management.EnumerationOptions()
            enumOptions.EnsureLocatable = true
            ObjectSearcher.Options = enumOptions
            Return New PrinterCollection(ObjectSearcher.Get)
        End Function
        
        <Browsable(true)>  _
        Public Shared Function CreateInstance() As Printer
            Dim mgmtScope As System.Management.ManagementScope = Nothing
            If (statMgmtScope Is Nothing) Then
                mgmtScope = New System.Management.ManagementScope()
                mgmtScope.Path.NamespacePath = CreatedWmiNamespace
            Else
                mgmtScope = statMgmtScope
            End If
            Dim mgmtPath As System.Management.ManagementPath = New System.Management.ManagementPath(CreatedClassName)
            Dim tmpMgmtClass As System.Management.ManagementClass = New System.Management.ManagementClass(mgmtScope, mgmtPath, Nothing)
            Return New Printer(tmpMgmtClass.CreateInstance)
        End Function
        
        <Browsable(true)>  _
        Public Sub Delete()
            PrivateLateBoundObject.Delete
        End Sub
        
        Public Shared Function AddPrinterConnection(ByVal Name As String) As UInteger
            Dim IsMethodStatic As Boolean = true
            If (IsMethodStatic = true) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim mgmtPath As System.Management.ManagementPath = New System.Management.ManagementPath(CreatedClassName)
                Dim classObj As System.Management.ManagementClass = New System.Management.ManagementClass(statMgmtScope, mgmtPath, Nothing)
                inParams = classObj.GetMethodParameters("AddPrinterConnection")
                inParams("Name") = CType(Name,System.String )
                Dim outParams As System.Management.ManagementBaseObject = classObj.InvokeMethod("AddPrinterConnection", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function CancelAllJobs() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("CancelAllJobs", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function Pause() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("Pause", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function PrintTestPage() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("PrintTestPage", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function RenamePrinter(ByVal NewPrinterName As String) As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                inParams = PrivateLateBoundObject.GetMethodParameters("RenamePrinter")
                inParams("NewPrinterName") = CType(NewPrinterName,System.String )
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("RenamePrinter", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function Reset() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("Reset", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function [Resume]() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("Resume", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function SetDefaultPrinter() As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("SetDefaultPrinter", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Function SetPowerState(ByVal PowerState As UShort, ByVal Time As Date) As UInteger
            If (isEmbedded = false) Then
                Dim inParams As System.Management.ManagementBaseObject = Nothing
                inParams = PrivateLateBoundObject.GetMethodParameters("SetPowerState")
                inParams("PowerState") = CType(PowerState,System.UInt16 )
                inParams("Time") = ToDmtfDateTime(CType(Time,Date))
                Dim outParams As System.Management.ManagementBaseObject = PrivateLateBoundObject.InvokeMethod("SetPowerState", inParams, Nothing)
                Return System.Convert.ToUInt32(outParams.Properties("ReturnValue").Value)
            Else
                Return System.Convert.ToUInt32(0)
            End If
        End Function
        
        Public Enum AttributesValues
            
            Queued0 = 1
            
            Direct0 = 2
            
            Default0 = 4
            
            Shared0 = 8
            
            Network0 = 16
            
            Hidden0 = 32
            
            Local0 = 64
            
            EnableDevQ = 128
            
            KeepPrintedJobs0 = 256
            
            DoCompleteFirst0 = 512
            
            WorkOffline0 = 1024
            
            EnableBIDI0 = 2048
            
            RawOnly0 = 4096
            
            Published0 = 8192
            
            NULL_ENUM_VALUE = 16384
        End Enum
        
        Public Enum AvailabilityValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            Running_Full_Power = 3
            
            Warning = 4
            
            In_Test = 5
            
            Not_Applicable = 6
            
            Power_Off = 7
            
            Off_Line = 8
            
            Off_Duty = 9
            
            Degraded = 10
            
            Not_Installed = 11
            
            Install_Error = 12
            
            Power_Save_Unknown = 13
            
            Power_Save_Low_Power_Mode = 14
            
            Power_Save_Standby = 15
            
            Power_Cycle = 16
            
            Power_Save_Warning = 17
            
            Paused = 18
            
            Not_Ready = 19
            
            Not_Configured = 20
            
            Quiesced = 21
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum CapabilitiesValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            Color_Printing = 2
            
            Duplex_Printing = 3
            
            Copies = 4
            
            Collation = 5
            
            Stapling = 6
            
            Transparency_Printing = 7
            
            Punch = 8
            
            Cover = 9
            
            Bind = 10
            
            Black_and_White_Printing = 11
            
            One_Sided = 12
            
            Two_Sided_Long_Edge = 13
            
            Two_Sided_Short_Edge = 14
            
            Portrait = 15
            
            Landscape = 16
            
            Reverse_Portrait = 17
            
            Reverse_Landscape = 18
            
            Quality_High = 19
            
            Quality_Normal = 20
            
            Quality_Low = 21
            
            NULL_ENUM_VALUE = 22
        End Enum
        
        Public Enum ConfigManagerErrorCodeValues
            
            This_device_is_working_properly_ = 0
            
            This_device_is_not_configured_correctly_ = 1
            
            Windows_cannot_load_the_driver_for_this_device_ = 2
            
            The_driver_for_this_device_might_be_corrupted_or_your_system_may_be_running_low_on_memory_or_other_resources_ = 3
            
            This_device_is_not_working_properly_One_of_its_drivers_or_your_registry_might_be_corrupted_ = 4
            
            The_driver_for_this_device_needs_a_resource_that_Windows_cannot_manage_ = 5
            
            The_boot_configuration_for_this_device_conflicts_with_other_devices_ = 6
            
            Cannot_filter_ = 7
            
            The_driver_loader_for_the_device_is_missing_ = 8
            
            This_device_is_not_working_properly_because_the_controlling_firmware_is_reporting_the_resources_for_the_device_incorrectly_ = 9
            
            This_device_cannot_start_ = 10
            
            This_device_failed_ = 11
            
            This_device_cannot_find_enough_free_resources_that_it_can_use_ = 12
            
            Windows_cannot_verify_this_device_s_resources_ = 13
            
            This_device_cannot_work_properly_until_you_restart_your_computer_ = 14
            
            This_device_is_not_working_properly_because_there_is_probably_a_re_enumeration_problem_ = 15
            
            Windows_cannot_identify_all_the_resources_this_device_uses_ = 16
            
            This_device_is_asking_for_an_unknown_resource_type_ = 17
            
            Reinstall_the_drivers_for_this_device_ = 18
            
            Failure_using_the_VxD_loader_ = 19
            
            Your_registry_might_be_corrupted_ = 20
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_does_not_work_see_your_hardware_documentation_Windows_is_removing_this_device_ = 21
            
            This_device_is_disabled_ = 22
            
            System_failure_Try_changing_the_driver_for_this_device_If_that_doesn_t_work_see_your_hardware_documentation_ = 23
            
            This_device_is_not_present_is_not_working_properly_or_does_not_have_all_its_drivers_installed_ = 24
            
            Windows_is_still_setting_up_this_device_ = 25
            
            Windows_is_still_setting_up_this_device_0 = 26
            
            This_device_does_not_have_valid_log_configuration_ = 27
            
            The_drivers_for_this_device_are_not_installed_ = 28
            
            This_device_is_disabled_because_the_firmware_of_the_device_did_not_give_it_the_required_resources_ = 29
            
            This_device_is_using_an_Interrupt_Request_IRQ_resource_that_another_device_is_using_ = 30
            
            This_device_is_not_working_properly_because_Windows_cannot_load_the_drivers_required_for_this_device_ = 31
            
            NULL_ENUM_VALUE = 32
        End Enum
        
        Public Enum CurrentCapabilitiesValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            Color_Printing = 2
            
            Duplex_Printing = 3
            
            Copies = 4
            
            Collation = 5
            
            Stapling = 6
            
            Transparency_Printing = 7
            
            Punch = 8
            
            Cover = 9
            
            Bind = 10
            
            Black_and_White_Printing = 11
            
            One_Sided = 12
            
            Two_Sided_Long_Edge = 13
            
            Two_Sided_Short_Edge = 14
            
            Portrait = 15
            
            Landscape = 16
            
            Reverse_Portrait = 17
            
            Reverse_Landscape = 18
            
            Quality_High = 19
            
            Quality_Normal = 20
            
            Quality_Low = 21
            
            NULL_ENUM_VALUE = 22
        End Enum
        
        Public Enum CurrentLanguageValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            PCL = 3
            
            HPGL = 4
            
            PJL = 5
            
            PS = 6
            
            PSPrinter = 7
            
            IPDS = 8
            
            PPDS = 9
            
            EscapeP = 10
            
            Epson = 11
            
            DDIF = 12
            
            Interpress = 13
            
            ISO6429 = 14
            
            Line_Data = 15
            
            MODCA = 16
            
            REGIS = 17
            
            SCS = 18
            
            SPDL = 19
            
            TEK4014 = 20
            
            PDS = 21
            
            IGP = 22
            
            CodeV = 23
            
            DSCDSE = 24
            
            WPS = 25
            
            LN03 = 26
            
            CCITT = 27
            
            QUIC = 28
            
            CPAP = 29
            
            DecPPL = 30
            
            Simple_Text = 31
            
            NPAP = 32
            
            DOC = 33
            
            ImPress = 34
            
            Pinwriter = 35
            
            NPDL = 36
            
            NEC201PL = 37
            
            Automatic = 38
            
            Pages = 39
            
            LIPS = 40
            
            TIFF = 41
            
            Diagnostic = 42
            
            CaPSL = 43
            
            EXCL = 44
            
            LCDS = 45
            
            XES = 46
            
            MIME = 47
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum DefaultCapabilitiesValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            Color_Printing = 2
            
            Duplex_Printing = 3
            
            Copies = 4
            
            Collation = 5
            
            Stapling = 6
            
            Transparency_Printing = 7
            
            Punch = 8
            
            Cover = 9
            
            Bind = 10
            
            Black_and_White_Printing = 11
            
            One_Sided = 12
            
            Two_Sided_Long_Edge = 13
            
            Two_Sided_Short_Edge = 14
            
            Portrait = 15
            
            Landscape = 16
            
            Reverse_Portrait = 17
            
            Reverse_Landscape = 18
            
            Quality_High = 19
            
            Quality_Normal = 20
            
            Quality_Low = 21
            
            NULL_ENUM_VALUE = 22
        End Enum
        
        Public Enum DefaultLanguageValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            PCL = 3
            
            HPGL = 4
            
            PJL = 5
            
            PS = 6
            
            PSPrinter = 7
            
            IPDS = 8
            
            PPDS = 9
            
            EscapeP = 10
            
            Epson = 11
            
            DDIF = 12
            
            Interpress = 13
            
            ISO6429 = 14
            
            Line_Data = 15
            
            MODCA = 16
            
            REGIS = 17
            
            SCS = 18
            
            SPDL = 19
            
            TEK4014 = 20
            
            PDS = 21
            
            IGP = 22
            
            CodeV = 23
            
            DSCDSE = 24
            
            WPS = 25
            
            LN03 = 26
            
            CCITT = 27
            
            QUIC = 28
            
            CPAP = 29
            
            DecPPL = 30
            
            Simple_Text = 31
            
            NPAP = 32
            
            DOC = 33
            
            ImPress = 34
            
            Pinwriter = 35
            
            NPDL = 36
            
            NEC201PL = 37
            
            Automatic = 38
            
            Pages = 39
            
            LIPS = 40
            
            TIFF = 41
            
            Diagnostic = 42
            
            CaPSL = 43
            
            EXCL = 44
            
            LCDS = 45
            
            XES = 46
            
            MIME = 47
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum DetectedErrorStateValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            No_Error = 2
            
            Low_Paper = 3
            
            No_Paper = 4
            
            Low_Toner = 5
            
            No_Toner = 6
            
            Door_Open = 7
            
            Jammed = 8
            
            Offline = 9
            
            Service_Requested = 10
            
            Output_Bin_Full = 11
            
            NULL_ENUM_VALUE = 12
        End Enum
        
        Public Enum ExtendedDetectedErrorStateValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            No_Error = 2
            
            Low_Paper = 3
            
            No_Paper = 4
            
            Low_Toner = 5
            
            No_Toner = 6
            
            Door_Open = 7
            
            Jammed = 8
            
            Service_Requested = 9
            
            Output_Bin_Full = 10
            
            Paper_Problem = 11
            
            Cannot_Print_Page = 12
            
            User_Intervention_Required = 13
            
            Out_of_Memory = 14
            
            Server_Unknown = 15
            
            NULL_ENUM_VALUE = 16
        End Enum
        
        Public Enum ExtendedPrinterStatusValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            Idle = 3
            
            Printing = 4
            
            Warmup = 5
            
            Stopped_Printing = 6
            
            Offline = 7
            
            Paused = 8
            
            [Error] = 9
            
            Busy = 10
            
            Not_Available = 11
            
            Waiting = 12
            
            Processing = 13
            
            Initialization = 14
            
            Power_Save = 15
            
            Pending_Deletion = 16
            
            I_O_Active = 17
            
            Manual_Feed = 18
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum LanguagesSupportedValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            PCL = 3
            
            HPGL = 4
            
            PJL = 5
            
            PS = 6
            
            PSPrinter = 7
            
            IPDS = 8
            
            PPDS = 9
            
            EscapeP = 10
            
            Epson = 11
            
            DDIF = 12
            
            Interpress = 13
            
            ISO6429 = 14
            
            Line_Data = 15
            
            MODCA = 16
            
            REGIS = 17
            
            SCS = 18
            
            SPDL = 19
            
            TEK4014 = 20
            
            PDS = 21
            
            IGP = 22
            
            CodeV = 23
            
            DSCDSE = 24
            
            WPS = 25
            
            LN03 = 26
            
            CCITT = 27
            
            QUIC = 28
            
            CPAP = 29
            
            DecPPL = 30
            
            Simple_Text = 31
            
            NPAP = 32
            
            DOC = 33
            
            ImPress = 34
            
            Pinwriter = 35
            
            NPDL = 36
            
            NEC201PL = 37
            
            Automatic = 38
            
            Pages = 39
            
            LIPS = 40
            
            TIFF = 41
            
            Diagnostic = 42
            
            CaPSL = 43
            
            EXCL = 44
            
            LCDS = 45
            
            XES = 46
            
            MIME = 47
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum MarkingTechnologyValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            Electrophotographic_LED = 3
            
            Electrophotographic_Laser = 4
            
            Electrophotographic_Other = 5
            
            Impact_Moving_Head_Dot_Matrix_9pin = 6
            
            Impact_Moving_Head_Dot_Matrix_24pin = 7
            
            Impact_Moving_Head_Dot_Matrix_Other = 8
            
            Impact_Moving_Head_Fully_Formed = 9
            
            Impact_Band = 10
            
            Impact_Other = 11
            
            Inkjet_Aqueous = 12
            
            Inkjet_Solid = 13
            
            Inkjet_Other = 14
            
            Pen = 15
            
            Thermal_Transfer = 16
            
            Thermal_Sensitive = 17
            
            Thermal_Diffusion = 18
            
            Thermal_Other = 19
            
            Electroerosion = 20
            
            Electrostatic = 21
            
            Photographic_Microfiche = 22
            
            Photographic_Imagesetter = 23
            
            Photographic_Other = 24
            
            Ion_Deposition = 25
            
            EBeam = 26
            
            Typesetter = 27
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum PaperSizesSupportedValues
            
            Unknown0 = 0
            
            Other0 = 1
            
            A = 2
            
            B = 3
            
            C = 4
            
            D = 5
            
            E = 6
            
            Letter = 7
            
            Legal = 8
            
            NA_10x13_Envelope = 9
            
            NA_9x12_Envelope = 10
            
            NA_Number_10_Envelope = 11
            
            NA_7x9_Envelope = 12
            
            NA_9x11_Envelope = 13
            
            NA_10x14_Envelope = 14
            
            NA_Number_9_Envelope = 15
            
            NA_6x9_Envelope = 16
            
            NA_10x15_Envelope = 17
            
            A0 = 18
            
            A1 = 19
            
            A2 = 20
            
            A3 = 21
            
            A4 = 22
            
            A5 = 23
            
            A6 = 24
            
            A7 = 25
            
            A8 = 26
            
            A9A10 = 27
            
            B0 = 28
            
            B1 = 29
            
            B2 = 30
            
            B3 = 31
            
            B4 = 32
            
            B5 = 33
            
            B6 = 34
            
            B7 = 35
            
            B8 = 36
            
            B9 = 37
            
            B10 = 38
            
            C0 = 39
            
            C1 = 40
            
            C2C3 = 41
            
            C4 = 42
            
            C5 = 43
            
            C6 = 44
            
            C7 = 45
            
            C8 = 46
            
            ISO_Designated = 47
            
            JIS_B0 = 48
            
            JIS_B1 = 49
            
            JIS_B2 = 50
            
            JIS_B3 = 51
            
            JIS_B4 = 52
            
            JIS_B5 = 53
            
            JIS_B6 = 54
            
            JIS_B7 = 55
            
            JIS_B8 = 56
            
            JIS_B9 = 57
            
            JIS_B10 = 58
            
            NA_Letter = 59
            
            NA_Legal = 60
            
            B4_Envelope = 61
            
            B5_Envelope = 62
            
            C3_Envelope = 63
            
            C4_Envelope = 64
            
            C5_Envelope = 65
            
            C6_Envelope = 66
            
            Designated_Long_Envelope = 67
            
            Monarch_Envelope = 68
            
            Executive = 69
            
            Folio = 70
            
            Invoice = 71
            
            Ledger = 72
            
            Quarto = 73
            
            NULL_ENUM_VALUE = 74
        End Enum
        
        Public Enum PowerManagementCapabilitiesValues
            
            Unknown0 = 0
            
            Not_Supported = 1
            
            Disabled = 2
            
            Enabled = 3
            
            Power_Saving_Modes_Entered_Automatically = 4
            
            Power_State_Settable = 5
            
            Power_Cycling_Supported = 6
            
            Timed_Power_On_Supported = 7
            
            NULL_ENUM_VALUE = 8
        End Enum
        
        Public Enum PrinterStateValues
            
            Paused = 0
            
            [Error] = 1
            
            Pending_Deletion = 2
            
            Paper_Jam = 3
            
            Paper_Out = 4
            
            Manual_Feed = 5
            
            Paper_Problem = 6
            
            Offline = 7
            
            IO_Active = 8
            
            Busy = 9
            
            Printing = 10
            
            Output_Bin_Full = 11
            
            Not_Available = 12
            
            Waiting = 13
            
            Processing = 14
            
            Initialization = 15
            
            Warming_Up = 16
            
            Toner_Low = 17
            
            No_Toner = 18
            
            Page_Punt = 19
            
            User_Intervention_Required = 20
            
            Out_of_Memory = 21
            
            Door_Open = 22
            
            Server_Unknown = 23
            
            Power_Save = 24
            
            NULL_ENUM_VALUE = 25
        End Enum
        
        Public Enum PrinterStatusValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            Idle = 3
            
            Printing = 4
            
            Warmup = 5
            
            Stopped_Printing = 6
            
            Offline = 7
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        Public Enum StatusInfoValues
            
            Other0 = 1
            
            Unknown0 = 2
            
            Enabled = 3
            
            Disabled = 4
            
            Not_Applicable = 5
            
            NULL_ENUM_VALUE = 0
        End Enum
        
        'Enumerator implementation for enumerating instances of the class.
        Public Class PrinterCollection
            Inherits Object
            Implements ICollection
            
            Private privColObj As ManagementObjectCollection
            
            Public Sub New(ByVal objCollection As ManagementObjectCollection)
                MyBase.New
                privColObj = objCollection
            End Sub
            
            Public Overridable ReadOnly Property Count() As Integer Implements System.Collections.ICollection.Count
                Get
                    Return privColObj.Count
                End Get
            End Property
            
            Public Overridable ReadOnly Property IsSynchronized() As Boolean Implements System.Collections.ICollection.IsSynchronized
                Get
                    Return privColObj.IsSynchronized
                End Get
            End Property
            
            Public Overridable ReadOnly Property SyncRoot() As Object Implements System.Collections.ICollection.SyncRoot
                Get
                    Return Me
                End Get
            End Property
            
            Public Overridable Sub CopyTo(ByVal array As System.Array, ByVal index As Integer) Implements System.Collections.ICollection.CopyTo
                privColObj.CopyTo(array, index)
                Dim nCtr As Integer
                nCtr = 0
                Do While (nCtr < array.Length)
                    array.SetValue(New Printer(CType(array.GetValue(nCtr),System.Management.ManagementObject)), nCtr)
                    nCtr = (nCtr + 1)
                Loop
            End Sub
            
            Public Overridable Function GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
                Return New PrinterEnumerator(privColObj.GetEnumerator)
            End Function
            
            Public Class PrinterEnumerator
                Inherits Object
                Implements System.Collections.IEnumerator
                
                Private privObjEnum As ManagementObjectCollection.ManagementObjectEnumerator
                
                Public Sub New(ByVal objEnum As ManagementObjectCollection.ManagementObjectEnumerator)
                    MyBase.New
                    privObjEnum = objEnum
                End Sub
                
                Public Overridable ReadOnly Property Current() As Object Implements System.Collections.IEnumerator.Current
                    Get
                        Return New Printer(CType(privObjEnum.Current,System.Management.ManagementObject))
                    End Get
                End Property
                
                Public Overridable Function MoveNext() As Boolean Implements System.Collections.IEnumerator.MoveNext
                    Return privObjEnum.MoveNext
                End Function
                
                Public Overridable Sub Reset() Implements System.Collections.IEnumerator.Reset
                    privObjEnum.Reset
                End Sub
            End Class
        End Class
        
        'TypeConverter to handle null values for ValueType properties
        Public Class WMIValueTypeConverter
            Inherits TypeConverter
            
            Private baseConverter As TypeConverter
            
            Private baseType As System.Type
            
            Public Sub New(ByVal inBaseType As System.Type)
                MyBase.New
                baseConverter = TypeDescriptor.GetConverter(inBaseType)
                baseType = inBaseType
            End Sub
            
            Public Overloads Overrides Function CanConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal srcType As System.Type) As Boolean
                Return baseConverter.CanConvertFrom(context, srcType)
            End Function
            
            Public Overloads Overrides Function CanConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal destinationType As System.Type) As Boolean
                Return baseConverter.CanConvertTo(context, destinationType)
            End Function
            
            Public Overloads Overrides Function ConvertFrom(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object) As Object
                Return baseConverter.ConvertFrom(context, culture, value)
            End Function
            
            Public Overloads Overrides Function CreateInstance(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal dictionary As System.Collections.IDictionary) As Object
                Return baseConverter.CreateInstance(context, dictionary)
            End Function
            
            Public Overloads Overrides Function GetCreateInstanceSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return baseConverter.GetCreateInstanceSupported(context)
            End Function
            
            Public Overloads Overrides Function GetProperties(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal value As Object, ByVal attributeVar() As System.Attribute) As PropertyDescriptorCollection
                Return baseConverter.GetProperties(context, value, attributeVar)
            End Function
            
            Public Overloads Overrides Function GetPropertiesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return baseConverter.GetPropertiesSupported(context)
            End Function
            
            Public Overloads Overrides Function GetStandardValues(ByVal context As System.ComponentModel.ITypeDescriptorContext) As System.ComponentModel.TypeConverter.StandardValuesCollection
                Return baseConverter.GetStandardValues(context)
            End Function
            
            Public Overloads Overrides Function GetStandardValuesExclusive(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return baseConverter.GetStandardValuesExclusive(context)
            End Function
            
            Public Overloads Overrides Function GetStandardValuesSupported(ByVal context As System.ComponentModel.ITypeDescriptorContext) As Boolean
                Return baseConverter.GetStandardValuesSupported(context)
            End Function
            
            Public Overloads Overrides Function ConvertTo(ByVal context As System.ComponentModel.ITypeDescriptorContext, ByVal culture As System.Globalization.CultureInfo, ByVal value As Object, ByVal destinationType As System.Type) As Object
                If (baseType.BaseType Is GetType(System.[Enum])) Then
                    If (value.GetType Is destinationType) Then
                        Return value
                    End If
                    If (((value Is Nothing)  _
                                AndAlso (Not (context) Is Nothing))  _
                                AndAlso (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) = false)) Then
                        Return  "NULL_ENUM_VALUE" 
                    End If
                    Return baseConverter.ConvertTo(context, culture, value, destinationType)
                End If
                If ((baseType Is GetType(Boolean))  _
                            AndAlso (baseType.BaseType Is GetType(System.ValueType))) Then
                    If (((value Is Nothing)  _
                                AndAlso (Not (context) Is Nothing))  _
                                AndAlso (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) = false)) Then
                        Return ""
                    End If
                    Return baseConverter.ConvertTo(context, culture, value, destinationType)
                End If
                If ((Not (context) Is Nothing)  _
                            AndAlso (context.PropertyDescriptor.ShouldSerializeValue(context.Instance) = false)) Then
                    Return ""
                End If
                Return baseConverter.ConvertTo(context, culture, value, destinationType)
            End Function
        End Class
        
        'Embedded class to represent WMI system Properties.
        <TypeConverter(GetType(System.ComponentModel.ExpandableObjectConverter))>  _
        Public Class ManagementSystemProperties
            
            Private PrivateLateBoundObject As System.Management.ManagementBaseObject
            
            Public Sub New(ByVal ManagedObject As System.Management.ManagementBaseObject)
                MyBase.New
                PrivateLateBoundObject = ManagedObject
            End Sub
            
            <Browsable(true)>  _
            Public ReadOnly Property GENUS() As Integer
                Get
                    Return CType(PrivateLateBoundObject("__GENUS"),Integer)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property [CLASS]() As String
                Get
                    Return CType(PrivateLateBoundObject("__CLASS"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property SUPERCLASS() As String
                Get
                    Return CType(PrivateLateBoundObject("__SUPERCLASS"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property DYNASTY() As String
                Get
                    Return CType(PrivateLateBoundObject("__DYNASTY"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property RELPATH() As String
                Get
                    Return CType(PrivateLateBoundObject("__RELPATH"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property PROPERTY_COUNT() As Integer
                Get
                    Return CType(PrivateLateBoundObject("__PROPERTY_COUNT"),Integer)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property DERIVATION() As String()
                Get
                    Return CType(PrivateLateBoundObject("__DERIVATION"),String())
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property SERVER() As String
                Get
                    Return CType(PrivateLateBoundObject("__SERVER"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property [NAMESPACE]() As String
                Get
                    Return CType(PrivateLateBoundObject("__NAMESPACE"),String)
                End Get
            End Property
            
            <Browsable(true)>  _
            Public ReadOnly Property PATH() As String
                Get
                    Return CType(PrivateLateBoundObject("__PATH"),String)
                End Get
            End Property
        End Class
    End Class
End Namespace

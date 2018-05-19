﻿' Developer Express Code Central Example:
' MVC - How to emulate a ReportViewer caching functionality
' 
' The ReportViewer does not have the built-in functionality to save its state
' between postbacks. This example illustrates how avoid rebuilding a report
' document when navigating between pages.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E20059

' Developer Express Code Central Example:
' How to use XtraReports in an ASP.NET MVC application
' 
' This sample demonstrates a simple ASP.NET MVC application that contains a static
' report and shows its print preview on the Web page.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3248


Imports Microsoft.VisualBasic
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices
' General Information about an assembly is controlled through the following 
' set of attributes. Change these attribute values to modify the information
' associated with an assembly.
<Assembly: AssemblyTitle("DevExpressMvcApplication1")>
<Assembly: AssemblyDescription("")>
<Assembly: AssemblyConfiguration("")>
<Assembly: AssemblyCompany("Microsoft")>
<Assembly: AssemblyProduct("DevExpressMvcApplication1")>
<Assembly: AssemblyCopyright("Copyright © Microsoft 2011")>
<Assembly: AssemblyTrademark("")>
<Assembly: AssemblyCulture("")>
' Setting ComVisible to false makes the types in this assembly not visible 
' to COM components.  If you need to access a type in this assembly from 
' COM, set the ComVisible attribute to true on that type.
<Assembly: ComVisible(False)>
' The following GUID is for the ID of the typelib if this project is exposed to COM
<Assembly: Guid("5e49d884-c97c-486e-a551-145030d68663")>
' Version information for an assembly consists of the following four values:
'
'      Major Version
'      Minor Version 
'      Build Number
'      Revision
'
' You can specify all the values or you can default the Revision and Build Numbers 
' by using the '*' as shown below:
<Assembly: AssemblyVersion("1.0.0.0")>
<Assembly: AssemblyFileVersion("1.0.0.0")>

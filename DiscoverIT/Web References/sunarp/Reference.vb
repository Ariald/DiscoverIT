﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.269
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.269.
'
Namespace sunarp
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="VehiculoServiceImplServiceSoapBinding", [Namespace]:="http://servicio.sunarp.com/")>  _
    Partial Public Class VehiculoServiceImplService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private consultarVehiculoOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.DiscoverIT.My.MySettings.Default.DiscoverIT_sunarp_VehiculoServiceImplService
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event consultarVehiculoCompleted As consultarVehiculoCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace:="http://servicio.sunarp.com/", ResponseNamespace:="http://servicio.sunarp.com/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function consultarVehiculo(<System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> ByVal codigoVehiculo As String) As <System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> vehiculo
            Dim results() As Object = Me.Invoke("consultarVehiculo", New Object() {codigoVehiculo})
            Return CType(results(0),vehiculo)
        End Function
        
        '''<remarks/>
        Public Overloads Sub consultarVehiculoAsync(ByVal codigoVehiculo As String)
            Me.consultarVehiculoAsync(codigoVehiculo, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub consultarVehiculoAsync(ByVal codigoVehiculo As String, ByVal userState As Object)
            If (Me.consultarVehiculoOperationCompleted Is Nothing) Then
                Me.consultarVehiculoOperationCompleted = AddressOf Me.OnconsultarVehiculoOperationCompleted
            End If
            Me.InvokeAsync("consultarVehiculo", New Object() {codigoVehiculo}, Me.consultarVehiculoOperationCompleted, userState)
        End Sub
        
        Private Sub OnconsultarVehiculoOperationCompleted(ByVal arg As Object)
            If (Not (Me.consultarVehiculoCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent consultarVehiculoCompleted(Me, New consultarVehiculoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.233"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://servicio.sunarp.com/")>  _
    Partial Public Class vehiculo
        
        Private afabricaField As String
        
        Private chazisField As String
        
        Private codigoField As String
        
        Private colorField As String
        
        Private marcaField As String
        
        Private modeloField As String
        
        Private motorField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property afabrica() As String
            Get
                Return Me.afabricaField
            End Get
            Set
                Me.afabricaField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property chazis() As String
            Get
                Return Me.chazisField
            End Get
            Set
                Me.chazisField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property codigo() As String
            Get
                Return Me.codigoField
            End Get
            Set
                Me.codigoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property color() As String
            Get
                Return Me.colorField
            End Get
            Set
                Me.colorField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property marca() As String
            Get
                Return Me.marcaField
            End Get
            Set
                Me.marcaField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property modelo() As String
            Get
                Return Me.modeloField
            End Get
            Set
                Me.modeloField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property motor() As String
            Get
                Return Me.motorField
            End Get
            Set
                Me.motorField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1")>  _
    Public Delegate Sub consultarVehiculoCompletedEventHandler(ByVal sender As Object, ByVal e As consultarVehiculoCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.1"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class consultarVehiculoCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As vehiculo
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),vehiculo)
            End Get
        End Property
    End Class
End Namespace

Imports System

Public Class VehiculoBE
    Private strPlaca As String
    Private strMarca As String
    Private strModelo As String
    Private strPropietario As String
    Private strSede As String
    Private strDescripcion As String
    Private strKilometraje As String
    Private strMotor As String
    Private strTransmision As String
    Private strCombustible As String
    Private strImagen As String

    Public Property Placa() As String
        Get
            Return strPlaca
        End Get
        Set(ByVal value As String)
            strPlaca = value
        End Set
    End Property

    Public Property Marca() As String
        Get
            Return strMarca
        End Get
        Set(ByVal value As String)
            strMarca = value
        End Set
    End Property

    Public Property Modelo() As String
        Get
            Return strModelo
        End Get
        Set(ByVal value As String)
            strModelo = value
        End Set
    End Property

    Public Property Propietario() As String
        Get
            Return strPropietario
        End Get
        Set(ByVal value As String)
            strPropietario = value
        End Set
    End Property

    Public Property Sede() As String
        Get
            Return strSede
        End Get
        Set(ByVal value As String)
            strSede = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return strDescripcion
        End Get
        Set(ByVal value As String)
            strDescripcion = value
        End Set
    End Property

    Public Property Kilometraje() As String
        Get
            Return strKilometraje
        End Get
        Set(ByVal value As String)
            strKilometraje = value
        End Set
    End Property

    Public Property Motor() As String
        Get
            Return strMotor
        End Get
        Set(ByVal value As String)
            strModelo = value
        End Set
    End Property

    Public Property Transmision() As String
        Get
            Return strTransmision
        End Get
        Set(ByVal value As String)
            strTransmision = value
        End Set
    End Property

    Public Property Combustible() As String
        Get
            Return strCombustible
        End Get
        Set(ByVal value As String)
            strCombustible = value
        End Set
    End Property

    Public Property Imagen() As String
        Get
            Return strImagen
        End Get
        Set(ByVal value As String)
            strImagen = value
        End Set
    End Property

End Class

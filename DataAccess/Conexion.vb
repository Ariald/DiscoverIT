Imports System.Configuration
Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Public Class Conexion
    Public Function conectar() As SqlConnection
        Dim conexion As New SqlConnection(ConfigurationManager.ConnectionStrings("Conexion").ConnectionString)
        Return conexion
    End Function
End Class
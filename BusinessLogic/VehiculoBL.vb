Imports BusinessEntity
Imports DataAccess
Public Class VehiculoBL
    Dim VehiculoDA As New VehiculoDA

    Public Function RegistrarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Return VehiculoDA.RegistrarVehiculo(Vehiculo)
    End Function

    Public Function ListarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Return VehiculoDA.ListarVehiculo(Vehiculo)
    End Function

    Public Function ListarMarca() As DataSet
        Return VehiculoDA.ListarMarca()
    End Function

    Public Function ListarModelo() As DataSet
        Return VehiculoDA.ListarModelo()
    End Function
End Class

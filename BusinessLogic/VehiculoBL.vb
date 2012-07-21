Imports BusinessEntity
Imports DataAccess
Public Class VehiculoBL
    Dim VehiculoDA As New VehiculoDA

    Public Function RegistrarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Return VehiculoDA.RegistrarVehiculo(Vehiculo)
    End Function

End Class

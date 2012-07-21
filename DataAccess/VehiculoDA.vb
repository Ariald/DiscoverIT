Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntity

Public Class VehiculoDA
    Dim con As New Conexion

    Public Function RegistrarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Dim conexion As SqlConnection
        conexion = con.conectar
        Dim daUsuario As New SqlDataAdapter("usp_InsertarVehiculo", conexion)
        daUsuario.SelectCommand.CommandType = CommandType.StoredProcedure

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@IdUsuario", SqlDbType.Int))
        daUsuario.SelectCommand.Parameters("@IdUsuario").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@IdUsuario").Value = Vehiculo.Usuario

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Placa", SqlDbType.VarChar, 10))
        daUsuario.SelectCommand.Parameters("@Placa").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Placa").Value = Vehiculo.Placa

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Marca", SqlDbType.VarChar, 20))
        daUsuario.SelectCommand.Parameters("@Marca").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Marca").Value = Vehiculo.Marca

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.VarChar, 40))
        daUsuario.SelectCommand.Parameters("@Modelo").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Modelo").Value = Vehiculo.Modelo

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Propietario", SqlDbType.VarChar, 50))
        daUsuario.SelectCommand.Parameters("@Propietario").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Propietario").Value = Vehiculo.Propietario

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Sede", SqlDbType.VarChar, 30))
        daUsuario.SelectCommand.Parameters("@Sede").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Sede").Value = Vehiculo.Sede

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 350))
        daUsuario.SelectCommand.Parameters("@Descripcion").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Descripcion").Value = Vehiculo.Descripcion

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Kilometraje", SqlDbType.VarChar, 15))
        daUsuario.SelectCommand.Parameters("@Kilometraje").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Kilometraje").Value = Vehiculo.Descripcion

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Motor", SqlDbType.VarChar, 10))
        daUsuario.SelectCommand.Parameters("@Motor").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Motor").Value = Vehiculo.Descripcion

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Transmision", SqlDbType.VarChar, 15))
        daUsuario.SelectCommand.Parameters("@Transmision").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Transmision").Value = Vehiculo.Descripcion

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Combustible", SqlDbType.VarChar, 15))
        daUsuario.SelectCommand.Parameters("@Combustible").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Combustible").Value = Vehiculo.Descripcion

        daUsuario.SelectCommand.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.VarChar, 50))
        daUsuario.SelectCommand.Parameters("@Imagen").Direction = ParameterDirection.Input
        daUsuario.SelectCommand.Parameters("@Imagen").Value = Vehiculo.Imagen

        Dim dsUsuario As New DataSet
        daUsuario.Fill(dsUsuario, "LoginUsuario")
        Return dsUsuario

        'LIBERA RECURSOS
        daUsuario.Dispose()
        dsUsuario.Dispose()
        conexion.Dispose()

    End Function

End Class

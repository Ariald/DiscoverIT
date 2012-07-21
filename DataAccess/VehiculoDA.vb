Imports Microsoft.VisualBasic
Imports System.Data
Imports System.Data.SqlClient
Imports BusinessEntity

Public Class VehiculoDA
    Dim con As New Conexion

    Public Function RegistrarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Dim conexion As SqlConnection
        conexion = con.conectar
        Dim daVehiculo As New SqlDataAdapter("usp_InsertarVehiculo", conexion)
        daVehiculo.SelectCommand.CommandType = CommandType.StoredProcedure

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@IdUsuario", SqlDbType.Int))
        daVehiculo.SelectCommand.Parameters("@IdUsuario").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@IdUsuario").Value = Vehiculo.Usuario

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Placa", SqlDbType.VarChar, 10))
        daVehiculo.SelectCommand.Parameters("@Placa").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Placa").Value = Vehiculo.Placa

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Marca", SqlDbType.VarChar, 20))
        daVehiculo.SelectCommand.Parameters("@Marca").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Marca").Value = Vehiculo.Marca

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.VarChar, 40))
        daVehiculo.SelectCommand.Parameters("@Modelo").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Modelo").Value = Vehiculo.Modelo

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Propietario", SqlDbType.VarChar, 50))
        daVehiculo.SelectCommand.Parameters("@Propietario").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Propietario").Value = Vehiculo.Propietario

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Sede", SqlDbType.VarChar, 30))
        daVehiculo.SelectCommand.Parameters("@Sede").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Sede").Value = Vehiculo.Sede

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Descripcion", SqlDbType.VarChar, 350))
        daVehiculo.SelectCommand.Parameters("@Descripcion").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Descripcion").Value = Vehiculo.Descripcion

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Kilometraje", SqlDbType.VarChar, 15))
        daVehiculo.SelectCommand.Parameters("@Kilometraje").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Kilometraje").Value = Vehiculo.Kilometraje

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Motor", SqlDbType.VarChar, 10))
        daVehiculo.SelectCommand.Parameters("@Motor").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Motor").Value = Vehiculo.Motor

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Transmision", SqlDbType.VarChar, 15))
        daVehiculo.SelectCommand.Parameters("@Transmision").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Transmision").Value = Vehiculo.Transmision

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Combustible", SqlDbType.VarChar, 15))
        daVehiculo.SelectCommand.Parameters("@Combustible").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Combustible").Value = Vehiculo.Combustible

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Imagen", SqlDbType.VarChar, 50))
        daVehiculo.SelectCommand.Parameters("@Imagen").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Imagen").Value = Vehiculo.Imagen

        Dim dsVehiculo As New DataSet
        daVehiculo.Fill(dsVehiculo, "RegistraVehiculo")
        Return dsVehiculo

        'LIBERA RECURSOS
        daVehiculo.Dispose()
        dsVehiculo.Dispose()
        conexion.Dispose()

    End Function

    Public Function ListarVehiculo(ByVal Vehiculo As VehiculoBE) As DataSet
        Dim conexion As SqlConnection
        conexion = con.conectar
        Dim daVehiculo As New SqlDataAdapter("usp_ListarVehiculos", conexion)
        daVehiculo.SelectCommand.CommandType = CommandType.StoredProcedure

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Marca", SqlDbType.VarChar, 20))
        daVehiculo.SelectCommand.Parameters("@Marca").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Marca").Value = Vehiculo.Marca

        daVehiculo.SelectCommand.Parameters.Add(New SqlParameter("@Modelo", SqlDbType.VarChar, 40))
        daVehiculo.SelectCommand.Parameters("@Modelo").Direction = ParameterDirection.Input
        daVehiculo.SelectCommand.Parameters("@Modelo").Value = Vehiculo.Modelo

        Dim dsVehiculo As New DataSet
        daVehiculo.Fill(dsVehiculo, "ListaVehiculo")
        Return dsVehiculo

        'LIBERA RECURSOS
        daVehiculo.Dispose()
        dsVehiculo.Dispose()
        conexion.Dispose()

    End Function

    Public Function ListarMarca() As DataSet
        Dim conexion As SqlConnection
        conexion = con.conectar
        Dim daVehiculo As New SqlDataAdapter("usp_ListarMarca", conexion)
        daVehiculo.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim dsVehiculo As New DataSet
        daVehiculo.Fill(dsVehiculo, "ListaMarca")
        Return dsVehiculo

        'LIBERA RECURSOS
        daVehiculo.Dispose()
        dsVehiculo.Dispose()
        conexion.Dispose()

    End Function

    Public Function ListarModelo() As DataSet
        Dim conexion As SqlConnection
        conexion = con.conectar
        Dim daVehiculo As New SqlDataAdapter("usp_ListarModelo", conexion)
        daVehiculo.SelectCommand.CommandType = CommandType.StoredProcedure

        Dim dsVehiculo As New DataSet
        daVehiculo.Fill(dsVehiculo, "ListaModelo")
        Return dsVehiculo

        'LIBERA RECURSOS
        daVehiculo.Dispose()
        dsVehiculo.Dispose()
        conexion.Dispose()

    End Function

End Class

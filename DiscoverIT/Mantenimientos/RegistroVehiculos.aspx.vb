Imports BusinessEntity
Imports BusinessLogic
Imports System.IO
Imports DiscoverIT.sunarp

Public Class RegistroVehiculos
    Inherits System.Web.UI.Page

    Structure Vehiculo
        Dim afabrica As String
        Dim chazis As String
        Dim codigo As String
        Dim color As String
        Dim marca As String
        Dim modelo As String
        Dim motor As String
    End Structure


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then

        End If
    End Sub

    Protected Sub btnGrabar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGrabar.Click
        Dim objVehiculo As New VehiculoBE
        Dim objVehiculoBL As New VehiculoBL

        With objVehiculo
            .Usuario = 1
            .Placa = txtNroPlaca.Text
            .Marca = lblMarca.Text
            .Modelo = lblModelo.Text
            .Propietario = lblPropietario.Text
            .Sede = lblSede.Text
            .Descripcion = txtDescripcion.Text
            .Kilometraje = txtKilometraje.Text
            .Motor = txtMotor.Text
            .Transmision = txtTransmision.Text
            .Combustible = txtCombustible.Text
            .Imagen = hidImagen.Value
        End With

        objVehiculoBL.RegistrarVehiculo(objVehiculo)

    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click

        Dim objSunarp As New sunarp.VehiculoServiceImplService
        Dim objVehiculo As Object
        objVehiculo = objSunarp.consultarVehiculo(txtNroPlaca.Text)


        'Dim sVehiculo As Vehiculo = DirectCast(objVehiculo, Vehiculo)

        lblMarca.Text = DirectCast(objVehiculo, DiscoverIT.sunarp.vehiculo).marca
        lblModelo.Text = DirectCast(objVehiculo, DiscoverIT.sunarp.vehiculo).modelo
        lblPropietario.Text = "Diego Quispe"
        lblSede.Text = "Lima"
        txtMotor.Text = DirectCast(objVehiculo, DiscoverIT.sunarp.vehiculo).motor
        txtDescripcion.Text = DirectCast(objVehiculo, DiscoverIT.sunarp.vehiculo).color + " - " + DirectCast(objVehiculo, DiscoverIT.sunarp.vehiculo).chazis
    End Sub

    Protected Sub btnCargar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCargar.Click
        If (fuImagen.HasFile) Then
            Dim savePath As String = "C:\Users\Diegop\Documents\Visual Studio 2010\Projects\DiscoverIT\DiscoverIT\Vehiculos\"
            Dim fileName As String = fuImagen.FileName

            savePath += fileName
            fuImagen.SaveAs(savePath)

            imgVehiculo.ImageUrl = "~/Vehiculos/" + fileName
            hidImagen.Value = fileName
        End If
    End Sub

    Protected Sub btnCancelar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelar.Click
        txtNroPlaca.Text = ""
        lblMarca.Text = ""
        lblModelo.Text = ""
        lblPropietario.Text = ""
        lblSede.Text = ""
        txtDescripcion.Text = ""
        txtKilometraje.Text = ""
        txtMotor.Text = ""
        txtTransmision.Text = ""
        txtCombustible.Text = ""
        imgVehiculo.ImageUrl = ""
    End Sub
End Class
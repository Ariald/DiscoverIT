Imports BusinessEntity
Imports BusinessLogic
Imports System.IO
Imports System.Data

Public Class ConsultaVehiculo
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not Page.IsPostBack Then
            Dim objVehiculoBL As New VehiculoBL
            ddlMarca.DataSource = objVehiculoBL.ListarMarca()
            ddlMarca.DataTextField = "descripcion"
            ddlMarca.DataValueField = "val"
            ddlMarca.DataBind()

            ddlModelo.DataSource = objVehiculoBL.ListarModelo()
            ddlModelo.DataTextField = "descripcion"
            ddlModelo.DataValueField = "val"
            ddlModelo.DataBind()

        End If
    End Sub

    Protected Sub btnBuscar_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBuscar.Click
        Dim objVehiculo As New VehiculoBE
        Dim objVehiculoBL As New VehiculoBL

        With objVehiculo
            .Marca = ddlMarca.SelectedValue
            .Modelo = ddlModelo.SelectedValue
        End With
        Dim dsVehiculos As New DataSet
        Dim drVehiculos As DataRow

        dsVehiculos = objVehiculoBL.ListarVehiculo(objVehiculo)

        Dim constructor As String = ""
        constructor += "<table>"

        For Each drVehiculos In dsVehiculos.Tables(0).Rows
            constructor += "<tr>"
            constructor += "<td><img width='200px' height='200px' src='../Vehiculos/" + drVehiculos("Imagen").ToString() + "' /></td>"
            constructor += "<td valign='top'>"
            constructor += "<table>"
            constructor += "<tr><td class='body'>Marca</td><td class='body'>: " + drVehiculos("Marca").ToString() + "</td></tr>"
            constructor += "<tr><td class='body'>Modelo</td><td class='body'>: " + drVehiculos("Modelo").ToString() + "</td></tr>"
            constructor += "<tr><td class='body'>Descripción</td><td class='body'>: " + drVehiculos("Descripcion").ToString() + "</td></tr>"
            constructor += "<tr><td class='body'>Sede</td><td class='body'>: " + drVehiculos("Sede").ToString() + "</td></tr>"
            constructor += "<tr><td class='body'>Kilometraje</td><td class='body'>: " + drVehiculos("Kilometraje").ToString() + "</td></tr>"
            constructor += "</table>"
            constructor += "</td>"
            constructor += "</tr>"
        Next
        constructor += "</table>"

        litVehiculos.Text = constructor
    End Sub
End Class
<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vehiculo.Master" CodeBehind="RegistroVehiculos.aspx.vb" Inherits="DiscoverIT.RegistroVehiculos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField runat="server" ID="hidImagen"/>
<table width="560" border="0" align="right" cellpadding="0" cellspacing="0">
            <tr>
                <td height="35" colspan="3" valign="top" class="heading" style="padding-top:8px; color:#CC0000;"><strong>REGISTRO DE VEHICULOS USADOS</strong></td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="body">Número de Placa</td>
                <td class="body">:</td>
                <td class="body" colspan="2"><asp:TextBox runat="server" ID="txtNroPlaca"></asp:TextBox><asp:Button runat="server" ID="btnBuscar" Text="Consultar SUNARP"/></td>
            </tr>
            <tr>
                <td class="body">Marca</td>
                <td class="body">:</td>
                <td class="body"><asp:label runat="server" ID="lblMarca"></asp:label></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Modelo</td>
                <td class="body">:</td>
                <td class="body"><asp:label runat="server" ID="lblModelo"></asp:label></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Propietario</td>
                <td class="body">:</td>
                <td class="body"><asp:label runat="server" ID="lblPropietario"></asp:label></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Sede</td>
                <td class="body">:</td>
                <td class="body"><asp:label runat="server" ID="lblSede"></asp:label></td>
                <td></td>
            </tr>
            <tr>
                <td class="body" valign="top">Descripción</td>
                <td class="body" valign="top">:</td>
                <td class="body" colspan="2"><asp:textbox runat="server" ID="txtDescripcion" TextMode="MultiLine" Height="70px" Width="400px"></asp:textbox></td>
            </tr>
            <tr>
                <td class="body">Kilometraje</td>
                <td class="body">:</td>
                <td class="body"><asp:textbox runat="server" ID="txtKilometraje"></asp:textbox></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Motor</td>
                <td class="body">:</td>
                <td class="body"><asp:textbox runat="server" ID="txtMotor"></asp:textbox></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Transmisión</td>
                <td class="body">:</td>
                <td class="body"><asp:textbox runat="server" ID="txtTransmision"></asp:textbox></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Combustible</td>
                <td class="body">:</td>
                <td class="body"><asp:textbox runat="server" ID="txtCombustible"></asp:textbox></td>
                <td></td>
            </tr>
            <tr>
                <td class="body">Imagen Referencial</td>
                <td class="body">:</td>
                <td class="body"><asp:FileUpload runat="server" ID="fuImagen"/></td>
                <td><asp:Button runat="server" ID="btnCargar" Text="Agregar Imagen"/></td>
            </tr>
            <tr>
                <td class="body"></td>
                <td class="body"></td>
                <td class="body" colspan="2"><asp:Image runat="server" ID="imgVehiculo" Width="250" Height="250" /></td>
            </tr>
            <tr>
                <td colspan="4">&nbsp;</td>
            </tr>
            <tr>
                <td class="body" colspan="4">
                    <asp:Button runat="server" id="btnGrabar" Text="Registrar"/>&nbsp;&nbsp;
                    <asp:Button runat="server" id="btnCancelar" Text="Cancelar"/>
                </td>
            </tr>
        </table>
</asp:Content>

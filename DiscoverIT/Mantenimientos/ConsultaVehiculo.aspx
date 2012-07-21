<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vehiculo.Master" CodeBehind="ConsultaVehiculo.aspx.vb" Inherits="DiscoverIT.ConsultaVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table width="560" border="0" align="right" cellpadding="0" cellspacing="0">
            <tr>
                <td height="35" colspan="3" valign="top" class="heading" style="padding-top:8px; color:#CC0000;"><strong>SHOWROOM</strong></td>
            </tr>
            <tr><td colspan="4">&nbsp;</td></tr>
            <tr>
                <td class="body">Marca: </td>
                <td><asp:DropDownList runat="server" ID="ddlMarca" width="150"></asp:DropDownList></td>
                <td class="body">Modelo: </td>
                <td><asp:DropDownList runat="server" ID="ddlModelo" width="150"></asp:DropDownList></td>
            </tr>
            <tr><td colspan="4">&nbsp;</td></tr>
            <tr><td colspan="4"><asp:button runat="server" ID="btnBuscar" Text="Buscar"/></td></tr>
            <tr><td colspan="4">&nbsp;</td></tr>
            <tr>
                <td colspan="4">
                    <div>
                        <asp:Literal runat="server" ID="litVehiculos"></asp:Literal>
                    </div>
                </td>
            </tr>
        </table>
    </div>
    
</asp:Content>

<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vehiculo.Master" CodeBehind="ConsultaVehiculo.aspx.vb" Inherits="DiscoverIT.ConsultaVehiculo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table>
            <tr>
                <td class="body">Marca: </td>
                <td><asp:DropDownList runat="server" ID="ddlMarca"></asp:DropDownList></td>
                <td class="body">Modelo: </td>
                <td><asp:DropDownList runat="server" ID="ddlModelo"></asp:DropDownList></td>
            </tr>
        </table>
    </div>
    <div>
        <asp:Literal runat="server" ID="litVehiculos"></asp:Literal>
    </div>
</asp:Content>

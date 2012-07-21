<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vehiculo.Master" CodeBehind="RegistroUsuario.aspx.vb" Inherits="DiscoverIT.RegistroUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
 
 <table width="560" border="0" align="right" cellpadding="0" cellspacing="0">
    <tr>
        <td valign="top">
            <table width="270" border="0" align="right" cellpadding="0" cellspacing="0">
                <tr>
                    <td height="35" colspan="3" valign="top" class="heading" style="padding-top:8px; color:#CC0000;"><strong>¿Ya eres usuario?</strong></td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td class="body" >Usuario</td>
                    <td><asp:TextBox runat="server" ID="txtUserName"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="body" >Contraseña</td>
                    <td><asp:TextBox runat="server" ID="txtContrasena"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4"><asp:button runat="server" ID="btnIngresa" Text="Ingresa"/></td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td  class="body"  colspan="4"><asp:LinkButton runat="server" ID="lbtnOlvidaste" Text="¿Olvidaste tu contraseña?"></asp:LinkButton></td>
                </tr>
            </table>
        </td>
        <td>
            <div style="height:200px;border-left:1px solid black">
        &nbsp;
        </div> 
        </td>
        <td valign="top">
            <table width="270" border="0" align="right" cellpadding="0" cellspacing="0">
                <tr>
                    <td height="35" colspan="3" valign="top" class="heading" style="padding-top:8px; color:#CC0000;"><strong>¿Eres Nuevo?</strong></td>
                </tr>
                <tr>
                    <td colspan="4">&nbsp;</td>
                </tr>
                <tr>
                    <td colspan="4"><asp:button runat="server" ID="btnRegistrarse" Text="Registrate Ahora"/></td>
                </tr>
            </table>
        </td>
    </tr>
</table> 
          
    
</asp:Content>

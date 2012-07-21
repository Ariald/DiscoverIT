<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RegistroVehiculos.aspx.vb" Inherits="DiscoverIT.RegistroVehiculos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Car Company</title>
    <link href="../css.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:HiddenField runat="server" id="hidImagen"/>
<table width="780" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#FFFFFF">
  <tr>
    <td valign="top"><img src="../images/index_01.gif" width="410" height="67" alt="" /><img src="../images/index_02.gif" width="370" height="67" alt="" /></td>
  </tr>
  <tr>
    <td valign="top"><img src="../images/index_03.gif" width="410" height="120" alt="" /><img src="../images/index_04.gif" alt="" width="370" height="120" border="0" usemap="#Map" /></td>
  </tr>
  <tr>
    <td valign="top"><table width="780" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="231" height="117" style="background-image:url(../images/index_05.gif);"><table width="225" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="60" height="115">
			<div style="width:15px; float:left; padding-top:18px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:40px; float:left; padding-top:15px;"><a href="index.html">Home</a></div>			</td>
            <td width="95" height="115">
			<div style="width:15px; float:left; padding-top:50px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:55px; float:left; padding-top:48px;"><a href="content.html">Company</a></div>			</td>
            <td width="70" height="115">
			<div style="width:15px; float:left; padding-top:73px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:50px; float:left; padding-top:71px;"><a href="contact.html">Contact</a></div>			</td>
          </tr>
        </table></td>
        <td width="244" height="117"><img src="../images/index_06.gif" width="244" height="117" alt="" /></td>
        <td width="305" valign="top" style="background-image:url(../images/index_07.gif);"><table width="300" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td width="110" height="117">
			<div style="width:15px; float:left; padding-top:2px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:90px; float:left; padding-bottom:42px;"><a href="content.html">Showroom</a></div>			</td>
            <td width="90" height="117">
			<div style="width:15px; float:left; padding-top:2px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:60px; float:left; padding-bottom:88px;"><a href="content.html">Models</a></div>			</td>
            <td width="100" height="117">
			<div style="width:15px; float:left; padding-top:2px;">
			  <div align="center"><img src="../images/arrow.gif" width="5" height="9" alt="" /></div>
			</div>
			<div class="menu" style="width:80px; float:left; padding-bottom:42px;"><a href="content.html">Finance</a></div>			</td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td style="padding-top:30px; padding-bottom:20px;">
    <table width="780" border="0" cellspacing="0" cellpadding="0">
      <tr>
        <td width="580" valign="top">
        <table width="560" border="0" align="right" cellpadding="0" cellspacing="0">
            <tr>
                <td class="body" colspan="4"><span>REGISTRO DE VEHICULOS USADOS</span></td>
            </tr>
            <tr>
                <td class="body">Número de Placa</td>
                <td class="body">:</td>
                <td class="body"><asp:TextBox runat="server" ID="txtNroPlaca"></asp:TextBox></td>
                <td class="body"><asp:Button runat="server" ID="btnBuscar" Text="Consultar SUNARP"/></td>
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
                <td class="body" colspan="4">
                    <asp:Button runat="server" id="btnGrabar" Text="Registrar"/>&nbsp;&nbsp;
                    <asp:Button runat="server" id="btnCancelar" Text="Cancelar"/>
                </td>
            </tr>
        </table></td>
        <td width="200" valign="top"><table width="160" border="0" align="center" cellpadding="0" cellspacing="0">
          <tr>
            <td valign="top" style="padding-bottom:12px;"><img src="../images/index_16.gif" width="160" height="20" alt="" /></td>
          </tr>
          <tr>
            <td valign="top" class="body" style="padding-bottom:10px;">Nulom ipsum dolor sitet, consec tetuer adipiser dulie.<br />
              <a href="#"><br />
              read more</a></td>
          </tr>
          <tr>
            <td><div align="center" style="padding-top:5px; padding-bottom:15px;"><img src="../images/index_22.gif" width="145" height="87" alt="" /></div></td>
          </tr>
          <tr>
            <td valign="top" class="body">Nulom ipsum dolor sitet, consec tetuer adipiser dulie.<br />
              <br />
              <a href="#">              read more<br />
              </a><br />
              <br />
              Nulom ipsum dolor sitet, consec tetuer adipiser dulie.<br />
              <br />
              <a href="#">              read more</a></td>
          </tr>
        </table></td>
      </tr>
    </table></td>
  </tr>
  <tr>
    <td height="83" style="background-image:url(../images/index_49.gif); background-repeat:repeat-x;"><table width="720" border="0" align="center" cellpadding="0" cellspacing="0">
      <tr>
        <td><pre class="footer"><a href="index.html">Home</a>  :  <a href="content.html">About Us</a>  :  <a href="content.html">Services</a>  :  <a href="content.html">Support</a>  :  <a href="content.html">Models</a>  :  <a href="content.html">News</a>  :  <a href="content.html">Financial</a>  :  <a href="content.html">Showroom</a>  :  <a href="contact.html">Contact</a>
</pre></td>
      </tr>
      <tr>
        <td height="20" valign="bottom" class="footer">copyrighted&copy; companyname.com 2006   All Rights and Reserved</td>
      </tr>
    </table></td>
  </tr>
</table>
    </form>
    <map name="Map" id="Map"><area shape="rect" coords="192,69,337,89" href="#" /></map>
</body>
</html>

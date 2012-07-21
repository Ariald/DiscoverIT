<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Vehiculo.Master" CodeBehind="Contact.aspx.vb" Inherits="DiscoverIT.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table width="560" border="0" align="right" cellpadding="0" cellspacing="0">
          <tr>
            <td valign="top" class="body"><form id="form1" name="form1" method="post" action="">
              <table width="93%" border="0" align="center" cellpadding="2" cellspacing="4" class="border">
                <tr>
                  <td height="35" colspan="3" valign="top" class="heading" style="padding-top:8px; color:#CC0000;"><strong>Contact Us :</strong></td>
                </tr>
                <tr>
                  <td width="36%" class="body">Your Name:</td>
                  <td width="64%" colspan="2"><input type="text" name="textfield3" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body">Address:</td>
                  <td colspan="2"><input type="text" name="textfield32" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body">City:</td>
                  <td colspan="2"><input type="text" name="textfield33" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body"> Country:</td>
                  <td colspan="2"><input type="text" name="textfield34" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body">Phone no:</td>
                  <td colspan="2"><input type="text" name="textfield35" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body">email Address:</td>
                  <td colspan="2"><input type="text" name="textfield36" style="width:250px; height:13px;" /></td>
                </tr>
                <tr>
                  <td class="body">Comments:</td>
                  <td colspan="2"><textarea name="textarea" rows="5" cols="" style="width:250px;"></textarea></td>
                </tr>
                <tr>
                  <td>&nbsp;</td>
                  <td colspan="2"><table width="100%" border="0" cellspacing="0" cellpadding="0">
                      <tr>
                        <td width="28%"><input type="image" name="imageField2" src="images/submit.gif" /></td>
                        <td width="72%"><input type="image" name="imageField3" src="images/reset.gif" /></td>
                      </tr>
                  </table></td>
                </tr>
              </table>
                        </form>
            </td>
          </tr>
        </table>
</asp:Content>

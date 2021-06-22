<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminCategoryDetail.aspx.cs" Inherits="WebApplication2.Admin.AdminCategoryDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <form id="form1" runat="server">
        <div style="margin-top:100px" > 
            <table class="nav-justified my-5" style="width: 109%; margin-left: 11px;">
                <tr>
                    <td style="color: #FF0000; width: 114px; height: 52px;" class="text-left"><strong><em>Kategori Ad:</em></strong></td>
                    <td style="height: 52px">
                       
                                &nbsp; &nbsp;<asp:TextBox ID="categorynametxt" runat="server" CssClass="form-control form-control-sm" Width="585px"  Font-Bold="False" Height="36px" ></asp:TextBox>
                                &nbsp;</td>
                </tr>
                  <tr>
                    <td style="color: #FF0000; width: 114px;"><em></em></td>
                    <td style="margin-left: 80px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="color: #FF0000; width: 114px;"><strong><em>Kategori Adet:</em></strong></td>
                    <td style="margin-left: 80px">
                        <asp:TextBox ID="categorynumbertxt" runat="server" CssClass="form-control form-control-sm" Width="585px" Font-Bold="False" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="color: #FF0000; width: 114px;"><em></em></td>
                    <td style="margin-left: 80px">&nbsp;</td>
                </tr>
                <tr>
                    <td style="color: #FF0000; width: 114px;"><em></em></td>
                    <td style="margin-left: 80px">
                        <asp:Button ID="Button1" runat="server" Text="Kategori Düzenle" Width="174px" CssClass="btn-group" OnClick="Button1_Click" />
                    </td>
                </tr>
                </table>
        </div>
    </form>
   

   
</asp:Content>

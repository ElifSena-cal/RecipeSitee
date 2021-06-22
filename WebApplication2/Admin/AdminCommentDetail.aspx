<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminCommentDetail.aspx.cs" Inherits="WebApplication2.Admin.AdminCommentDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <form id="form1" runat="server">
        <div style="margin-top:18px" > 
            <table class="nav-justified my-5" style="width: 109%; margin-left: 18px; margin-top: 0px;">
          
                              <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left" ><strong>Ad-Soyad</strong></td>
                                  <td style="height: 51px">
                                      <asp:TextBox ID="name" runat="server" Width="246px" CssClass="form-control form-control-sm" placeholder="Yemek Adı" Height="33px" ></asp:TextBox>
                                  </td>
                              </tr>
                          
                              <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left" ><strong>Mail:</strong></td>
                                  <td>
                                      <asp:TextBox ID="mail" runat="server" Height="34px" Width="246px" CssClass="form-control form-control-sm" placeholder="Yemek Malzeme"></asp:TextBox>
                                  </td>
                              </tr>
                              <tr style="height:15px">
                                  <td class="text-left" style="width: 250px"></td>
                              </tr>
                
                              <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left" ><strong>Yemek: </strong></td>
                                  <td style="height: 51px">
                                      <asp:TextBox ID="foodname" runat="server" Width="246px" CssClass="form-control form-control-sm" placeholder="Yemek Adı" Height="33px" ></asp:TextBox>
                                  </td>
                              </tr>
                              <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left"><strong>İçerik</strong></td>
                                  <td>
                                      <asp:TextBox ID="text" runat="server" Height="106px" TextMode="MultiLine" CssClass="form-control form-control-sm" placeholder="Yemek Tarifi" Width="246px"></asp:TextBox>
                                  </td>

                              </tr>
                  <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left">&nbsp;</td>
                                  <td style="margin-left: 80px">
                                      &nbsp;</td>
                              </tr>
                          
                              <tr>
                                  <td style="color: #FF0000; width: 250px;" class="text-left">&nbsp;</td>
                                  <td style="margin-left: 80px">
                                      <asp:Button ID="Button1" runat="server" Height="41px" Text="Onayla" Width="270px" CssClass="btn-primary" OnClick="Button1_Click"   />
                                  </td>
                              </tr>
                </table>
            </div>
        </form>
</asp:Content>

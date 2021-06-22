<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminAboutUs.aspx.cs" Inherits="WebApplication2.Admin.AdminAboutUs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <form id="form1" runat="server">
          <div class="row">
                    <div class="col-lg-12" style="left: 0px; top: 0px">
                     <h2 style="margin-left: 70px">Hakkımızda </h2> 
                        
                    </div>
                
                </div>              
             
                  <hr />
        <asp:TextBox ID="aboutus" runat="server" Height="260px" TextMode="MultiLine" Width="492px" style="margin-left: 28px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server"  Text="Güncelle" Width="170px" Height="49px" style="margin-left: 353px" CssClass="btn-primary" OnClick="Button1_Click" />
    </form>
   
</asp:Content>

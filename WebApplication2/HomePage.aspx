<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication2.Anasayfaa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="row-mb-3 "> 
     <div class="col-md-6 col-lg-4 ">
         <asp:DataList RepeatColumns="3" ID="DataList2" runat="server" Height="182px" Width="798px"  
>
                <ItemTemplate>
              
                 <asp:Image ID="Image1" runat="server" CssClass=" img-fluid" Height="145px" ImageUrl='<%# Eval("FoodImage") %>' Width="241px" />
                 <h6 class="text-center my-2">
                     <a href="FoodDetail.aspx?foodid=<%# Eval("Foodid") %>">
                     <asp:Label ID="Label2" runat="server" CssClass="text-center" Text='<%# Eval("FoodName") %>'></asp:Label></a> </h6>
                      
                </ItemTemplate>
            </asp:DataList>
      
        </div>
                </div>
</asp:Content>

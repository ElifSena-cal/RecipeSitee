<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="CategoryDetail.aspx.cs" Inherits="WebApplication2.KategoriDetay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:DataList ID="DataList1" runat="server" BorderColor="White" BorderWidth="2px">
             <ItemTemplate>
                   <div class="card text-white mb-3" style="left: 0px; top: 0px; width: 710px; height: 380px">
         <asp:Image ID="resim" runat="server" Height="380px" Width="710px" ImageUrl='<%# Eval("FoodImage") %>'></asp:Image>
           <div class="card-img-overlay d-flex align-items-center justify-content-center">
             <h1>
                
                 <asp:Label ID="Label4" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                
             </h1>
         </div>
     </div>
     <h2>- Hazırlanışı -</h2>
     <p class="text-justify">
     


         <asp:Label ID="Label2" runat="server" Text='<%# Eval("Recipe") %>'></asp:Label>
     

       
     </p>
     <h2>- Malzemeler -</h2>
        <p>
           
            <asp:Label ID="Label3" runat="server" Text='<%# Eval("FoodStuff") %>'></asp:Label>
          
        </p>
                   <p>
                       &nbsp;</p>
                   <p>
                       &nbsp;</p>
             </ItemTemplate>

         </asp:DataList>
 

</asp:Content>



<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="FoodDetail.aspx.cs" Inherits="WebApplication2.YemekDetayy" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <asp:DataList ID="DataList2" runat="server">
        <ItemTemplate>
          
      
     <div class="card text-white mb-3" style="left: 0px; top: 0px; width: 710px; height: 380px">
         <asp:Image ID="resim" runat="server" Height="380px" Width="710px" ImageUrl='<%# Eval("FoodImage") %>'></asp:Image>
           <div class="card-img-overlay d-flex align-items-center justify-content-center">
             <h1>
                
                 <asp:Label ID="foodname" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label>
                
             </h1>
              
                   
              
                 
              
         </div>
     </div>
     <h2>- Hazırlanışı -</h2>
     <p class="text-justify">
     


         <asp:Label ID="recipe" runat="server" Text='<%# Eval("Recipe") %>'></asp:Label>
     


     </p>
     <h2>- Malzemeler -</h2>
        <p>
           
            <asp:Label ID="foodstuff" runat="server" Text='<%# Eval("FoodStuff") %>'></asp:Label>
          
        </p> 
         </ItemTemplate>
    </asp:DataList>           
    <div class="container my-5">
    <div class="row">
        <div class="col-md-8 col-lg-9">

            <div class="card border-0 shadow-sm mb-3">
                <div class="card-body">
                   
                    <form method="get">

                        <h4 class="mb-3">Tarifi Değerlendirin</h4>

                        <div class="form-floating mb-5">
   <asp:TextBox ID="Text" runat="server" placeholder="Yorumunuz" CssClass="form-control" Height="100%" TextMode="MultiLine"></asp:TextBox>
                            <label for="TextBox1">Yorumunuz</label>

                  </div>

                       <asp:Button ID="Button1" runat="server" Text="Gönder" CssClass="btn btn-dark" OnClick="Button1_Click"  />
                    </form>

                </div>
            </div>


       
            
                    <div class="card border-0 shadow-sm mb-3">
                    <h4>Yorumlar</h4>
                   
                    </div>

         
        
                 <asp:DataList ID="DataList1" runat="server" Width="578px">
                <ItemTemplate> 
                <div class="card border-0 shadow-sm mb-2" style="left: 0px; top: 0px">
                    <p><asp:Label ID="Label5" runat="server" Text='<%# Eval("CommentText") %>'></asp:Label></p>       <div class="text-muted fs-6 mb-3 ">
                        <asp:Label ID="Label6" runat="server" Text='<%# Eval("CommentName") %>'></asp:Label>
                        &nbsp; -&nbsp;
                        <asp:Label ID="Label7" runat="server" Text='<%# Eval("CommentHistory") %>'></asp:Label>
                      
                        
                    </div>

              </div>
                </ItemTemplate>

            </asp:DataList>
               
               
                    
                </div>

            


        </div>
    </div>






  
</asp:Content>

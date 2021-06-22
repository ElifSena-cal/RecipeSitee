<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminCategory.aspx.cs" Inherits="WebApplication2.Admin.AdminCategory" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">

                <div class="row">
                    <div class="col-lg-12" style="left: 0px; top: 0px">
                     <h2 style="margin-left: 70px">Kategori Değiştir-Sil&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Kategori Ekle </h2> 
                        
                    </div>
                
                </div>              
             
                  <hr />
        <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
        <link href="assets/css/admincategory.css" rel="stylesheet" />
        <script src="assets/js/admincategory.js"></script>
<!------ Include the above in your HEAD tag ---------->


  
          <div >

              <table style="width:auto; margin-top: -100px;" class="my-5" >
                  <tr>
                      <td style="margin-left: 75px;margin-top:auto"><div class="my-5" style="margin-left: 70px">
		  <asp:DataList ID="DataList1" runat="server" style="margin-left: 0px" Width="242px">
                        <ItemTemplate>
				<li class="list-group-item ">
					<span class="show-menu">
						<span class="glyphicon glyphicon-chevron-right"></span>
					</span>
					<ul class="list-group-submenu">
						<li class="list-group-submenu-item success"><a href="AdminCategory.aspx?ide=<%#Eval("Categoryid") %>&process=delete"><span class="glyphicon glyphicon-remove"></span></li></a>
						<li class="list-group-submenu-item danger"><a href="AdminCategoryDetail.aspx?ide=<%#Eval("Categoryid") %>"><span class="glyphicon glyphicon-refresh"></span></li></a>
					</ul>
				  
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("CategoryName") %>'></asp:Label>
                 
				</li>
				
	       </ItemTemplate>
                    </asp:DataList>
		</div></td>
                      <td style="margin-left: 300px"><div style="margin-left: 300px; width: 410px; height: 130px;">
				
                          <table style="width: 100%">
                              <tr>
                                  <td style="height: 51px">Kategori Ad:</td>
                                  <td style="height: 51px">
                                      <asp:TextBox ID="name" runat="server" Width="148px" CssClass="form-control form-control-sm" placeholder="Kategori Adı" ></asp:TextBox>
                                  </td>
                              </tr>
                          
                              <tr>
                                  <td>&nbsp;</td>
                                  <td style="margin-left: 80px">
                                      &nbsp;</td>
                              </tr>
                          
                              <tr>
                                  <td>&nbsp;</td>
                                  <td style="margin-left: 80px">
                                      <asp:Button ID="Button1" runat="server" Height="24px" Text="Kategori Ekle" Width="158px" OnClick="Button1_Click" />
                                  </td>
                              </tr>
                          </table>
				
</div></td>
                  </tr>
              </table>
        

          </div>
		</form>
</asp:Content>

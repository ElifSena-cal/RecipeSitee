<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminComment.aspx.cs" Inherits="WebApplication2.Admin.AdminMessagee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <script src="assets/js/adminmessage.js"></script>
      <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"/>
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
        <link href="assets/css/admincategory.css" rel="stylesheet" />
        <script src="assets/js/admincategory.js"></script>
	   <form id="form1" runat="server">
		      <div class="row">
                    <div class="col-lg-12" style="left: 0px; top: 0px">
                     <h2 style="margin-left: 70px"> Onaysız Yorumlar &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Onaylı Yorumlar
                   </h2> 
                        
                    </div>
                
                </div>              
             
                  <hr />
            <table style="width:auto; margin-top: -100px;" class="my-5" >
                  <tr>
                      <td style="margin-left: 75px;margin-top:auto"><div class="my-5" style="margin-left: 70px">
		  <asp:DataList ID="DataList1" runat="server" style="margin-left: 0px; margin-top: 62px;" Width="242px">
                        <ItemTemplate>
				<li class="list-group-item ">
					<span class="show-menu">
						<span class="glyphicon glyphicon-chevron-right"></span>
					</span>
					<ul class="list-group-submenu">
						<li class="list-group-submenu-item success"><a href="AdminComment.aspx?ide=<%#Eval("Commentid") %>&process=delete"><span class="glyphicon glyphicon-remove"></span></li></a>
						<li class="list-group-submenu-item danger"><a href="AdminCommentDetail.aspx?commentid=<%#Eval("Commentid") %>"><span class="glyphicon glyphicon-refresh"></span></a></li>
					</ul>
				  
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("CommentName") %>'></asp:Label>
                 
				</li>
				
	       </ItemTemplate>
                    </asp:DataList>
		</div></td>
                       <td style="margin-left: 75px;margin-top:auto"><div class="my-5" style="margin-left: 70px">
		  <asp:DataList ID="DataList2" runat="server" style="margin-left: 290px; margin-top: 62px;" Width="242px">
                        <ItemTemplate>
				<li class="list-group-item ">
					<span class="show-menu">
						<span class="glyphicon glyphicon-chevron-right"></span>
					</span>
					<ul class="list-group-submenu">
						<li class="list-group-submenu-item success"><a href="AdminComment.aspx?ide=<%#Eval("Commentid") %>&process=delete"><span class="glyphicon glyphicon-remove"></span></li></a>
						<li class="list-group-submenu-item danger"><a href="AdminCommentDetail.aspx?commentid=<%#Eval("Commentid") %>"><span class="glyphicon glyphicon-refresh"></span></a></li>
					</ul>
				  
                            <asp:Label ID="Label1" runat="server" Text='<%#Eval("CommentName") %>'></asp:Label>
                 
				</li>
				
	       </ItemTemplate>
                    </asp:DataList>
		</div></td>
                      </tr>
                </table>

                        
                           
                     
	
		   </form>

</asp:Content>

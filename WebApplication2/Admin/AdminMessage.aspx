<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminMessage.aspx.cs" Inherits="WebApplication2.Admin.AdminMessage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="assets/js/adminmessage.js"></script>
	   <form id="form1" runat="server">
           <link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script>
<!------ Include the above in your HEAD tag ---------->
<asp:DataList ID="DataList1" runat="server" >
                    <ItemTemplate>
<br><br>
<div class="container-fluid well span6">
	<div class="row-fluid">
        <div class="span2" >
		<img class="img-responsive user-photo" src="https://ssl.gstatic.com/accounts/ui/avatar_2x.png">
        </div>
        <div class="span8">
            
                        <h3>
                            <asp:Label ID="Label1" runat="server" Text='<%# Eval("MessageSender") %>'></asp:Label>
                        </h3>
            <h6>Email:<asp:Label ID="Label2" runat="server" Text='<%# Eval("MessageMail") %>'></asp:Label>
                        </h6>
            <h6>Başlık:
                <asp:Label ID="Label3" runat="server" Text='<%# Eval("MessageTitle") %>'></asp:Label>
                        </h6>
            <h6>İçerik:
                <asp:Label ID="Label4" runat="server" Text='<%# Eval("MessageContent") %>'></asp:Label>
                        </h6>
          
        </div>
        
        <div class="span2">
            <div class="btn-group">
                <a class="btn dropdown-toggle btn-info" data-toggle="dropdown" href="#">
                    Action 
                    <span class="icon-cog icon-white"></span><span class="caret"></span>
                </a>
                <ul class="dropdown-menu">
                  
                    <li><a href="AdminMessage.aspx?Messageid=<%# Eval("Messageid")%>&process=delete"><span class="icon-trash"></span> Delete</li></a>
                </ul>
            </div>
        </div>   </div>
</div>
                    </ItemTemplate>
                </asp:DataList>   

                        
                           
                     
	
		   </form>

</asp:Content>

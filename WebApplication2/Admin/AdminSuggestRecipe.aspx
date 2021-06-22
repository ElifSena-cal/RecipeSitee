<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminDefault.Master" AutoEventWireup="true" CodeBehind="AdminSuggestRecipe.aspx.cs" Inherits="WebApplication2.Admin.AdminSuggestRecipe" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server"><link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/css/bootstrap-combined.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.3.2/js/bootstrap.min.js"></script>
<script src="//code.jquery.com/jquery-1.11.1.min.js"></script> <link href="//netdna.bootstrapcdn.com/bootstrap/3.1.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css">
<script src="//netdna.bootstrapcdn.com/bootstrap/3.1.0/js/bootstrap.min.js"></script>
<link href="assets/css/adminsuggestrecipe.css" rel="stylesheet" />
    <script src="assets/js/adminsuggestrecipe.js"></script>
     <form id="form1" runat="server">
  
<!------ Include the above in your HEAD tag ---------->

<div class="container">
    <div class="row"><asp:DataList ID="DataList1" runat="server" style="margin-left: 46px" Width="242px"  >
                        <ItemTemplate>
		<div class="col-md-6">
			<div class="panel panel-primary" style="width: 900px;height:auto">
				<div class="panel-heading">
					<h3 class="panel-title"><asp:Label ID="Label1" runat="server" Text='<%# Eval("FoodName") %>'></asp:Label></h3>
					<span class="pull-right clickable"><i class="glyphicon glyphicon-chevron-up"></i></span>
				</div>
				<div class="panel-body">
                       <div id="collapse1" class="panel-collapse collapse in" style="left: 0px; top: 0px; width: 903px" >
      <div class="panel-body">
             <div class="row">
            <div class="span2">
              
                <label>Gönderen</label> 
<asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("RecipeSender") %>'></asp:TextBox>
               <label>Mail:</label>
               <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("RecipeSenderMail") %>'></asp:TextBox>
                <label>Malzemeler</label>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("FoodStuff") %>' Height="147px" TextMode="MultiLine" Width="205px"></asp:TextBox>
                <label>Resim</label>
                <asp:Image ID="Image1" runat="server" Height="118px"  ImageUrl='<%# Eval("FoodImage") %>' Width="305px" />
               <label>Kategori</label>
                <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataValueField='Categoryid' SelectedValue='<%# Eval("Categoryid") %>' DataTextField="CategoryName">
                    <asp:ListItem></asp:ListItem>
                    <asp:ListItem></asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Context %>" SelectCommand="SELECT [Categoryid], [CategoryName] FROM [Category]"></asp:SqlDataSource>
            </div>
    
            <div class="span4" style="margin-left: 392px; margin-top: -400px">
                <label>Tarif</label> 
<asp:TextBox ID="TextBox4" runat="server" class="input-xlarge span4" name="message"
                rows="10" Text='<%# Eval("Recipe") %>' TextMode="MultiLine" style="margin-left: 4px"></asp:TextBox>
     
         
     <asp:Button ID="Button1" runat="server" Text="Onayla" CssClass="btn btn-primary pull-right" OnClick="Button1_Click" />
               <asp:Button ID="Button2" runat="server" Text="Sil" CssClass="btn btn-primary pull-right" style="margin-left: 17px" OnClick="Button2_Click" /></a>
                 
       </div>
          </div>
        </div>


    </div>
                            <div style="height: 37px">

                            </div>
                 
                        </ItemTemplate>
                            </asp:DataList>
                           
				</div>
			</div>
	

		</form>
    </form>
</asp:Content>
   <%-- 
                            <asp:Panel ID="Panel1" runat="server">
      <h4 class="panel-title" style="border: medium solid #FF0000; width: 876px; height: 18px;">
        <a data-toggle="collapse" data-parent="#accordion" href="#collapse1">
             </a>
      </h4>
    </div>
    <div id="collapse1" class="panel-collapse collapse in" style="left: 0px; top: 0px; width: 887px" >
      <div class="panel-body">
             <div class="row">
            <div class="span3">
                <label>Gönderen</label> 
<asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("RecipeSender") %>'></asp:TextBox>
                <label>Mail:</label>
               <asp:TextBox ID="TextBox2" runat="server" Text='<%# Eval("RecipeSenderMail") %>'></asp:TextBox>
                <label>Malzemeler</label>
                <asp:TextBox ID="TextBox3" runat="server" Text='<%# Eval("FoodStuff") %>' Height="147px" TextMode="MultiLine" Width="205px"></asp:TextBox>
                <label>Resim</label>
<asp:Image ID="Image1" runat="server" Height="118px" ImageUrl='<%# Eval("FoodImage") %>' Width="199px" />
               
            </div>
    
            <div class="span5">
                <label>Tarif</label> 
<asp:TextBox ID="TextBox4" runat="server" class="input-xlarge span5" name="message"
                rows="10" Text='<%# Eval("Recipe") %>' TextMode="MultiLine"></asp:TextBox>
           <button class="btn btn-primary pull-right" type=
            "submit">Onayla</button>
                 <button class="btn btn-primary pull-right" type=
            "submit">Sil</button>
        </div>
          </div>
        </div>


    </div>
                            <div style="height: 37px">

                            </div></asp:Panel>
                        </ItemTemplate>
                            </asp:DataList>--%>
                           

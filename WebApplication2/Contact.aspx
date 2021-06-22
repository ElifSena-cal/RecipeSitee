<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication2.iletişimm" UnobtrusiveValidationMode="None"%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assets/css/contact.css" rel="stylesheet" />
 <div class="container contact " style="height: 50px" >
	<div class="row" style="height: 361px; width: 1135px; margin-right: 0px; margin-top: 0px" >
		<div class="col-md-3" style="width: 13%; height: 440px">
			<div class="contact-info">
				<img src="https://image.ibb.co/kUASdV/contact-image.png" alt="image"/>
				<h2 style="width: 145px; height: 60px">Bize Mesaj Bırakın </h2>
		
			</div>
		</div>
		<div class="col-auto" style="height: 171px" >
			<div class="contact-form" style="width: 699px; height: 297px; margin-left: 22px;">
				<div class="form-group">
				  <asp:Label ID="Label1" runat="server" Text="Ad-Soyad" CssClass="control-label col-sm-2"></asp:Label>
				  <div class="col-sm-10">          
				 <asp:TextBox ID="nametxt" runat="server" CssClass="form-control" placeholder="Ad-Soyad"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage="Ad-soyad kısmı boş geçilemez" ControlToValidate="nametxt" Font-Bold="True" ForeColor="Red" ></asp:RequiredFieldValidator>
				  </div>
				</div>
				<div class="form-group">
			<asp:Label ID="Label2" runat="server" Text="E-Mail" CssClass="control-label col-sm-2"></asp:Label>
				  <div class="col-sm-10">          
					 <asp:TextBox ID="emailtxt" runat="server" CssClass="form-control" placeholder="E-Mail" TextMode="Email"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ErrorMessage="E-Mail kısmı boş geçilemez" ControlToValidate="emailtxt" Font-Bold="True" ForeColor="Red" ></asp:RequiredFieldValidator>
				  </div>
				</div>
				<div class="form-group">
					<asp:Label ID="Label3" runat="server" Text="Başlık" CssClass="control-label col-sm-2"></asp:Label>
				  <div class="col-sm-10">
					  <asp:TextBox ID="titletxt" runat="server" CssClass="form-control" placeholder="Başlık"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"  ErrorMessage="Başlık kısmı boş geçilemez" ControlToValidate="titletxt" Font-Bold="True" ForeColor="Red" ></asp:RequiredFieldValidator>
				  </div>
				</div>
				<div class="form-group">
		
						<asp:Label ID="Label4" runat="server" Text="Mesajınız" CssClass="control-label col-sm-2"></asp:Label>
				  <div class="col-sm-10">
					<asp:TextBox ID="contenttxt" runat="server" CssClass="form-control" placeholder="Mesaj" Height="84px" TextMode="MultiLine" Width="100%" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"  ErrorMessage="Mesaj kısmı boş geçilemez" ControlToValidate="contenttxt" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
				  </div>
				</div>
				<div class="form-group">        
				  <div class="col-sm-offset-2 col-sm-10" style="height: 32px">
				  <asp:Button ID="Button1" runat="server" Text="Mesaj Gönder" CssClass="btnContact" OnClick="myFunction" />
				  </div>
				
				</div>
			</div>
		</div>
	</div>
</div>

</asp:Content>

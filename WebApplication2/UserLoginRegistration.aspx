<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLoginRegistration.aspx.cs" Inherits="WebApplication2.WebForm1" UnobtrusiveValidationMode="None"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>KULLANICI GİRİŞ</title>
    <link href="assets/css/login-registration.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-wrap">
			<form action="WebForm3.aspx" method="post">
	<div class="login-html">
		<input id="tab-1" type="radio" name="tab" class="sign-in" checked="checked"><label for="tab-1" class="tab">GİRİŞ YAP</label>
		<input id="tab-2" type="radio" name="tab" class="sign-up"><label for="tab-2" class="tab">ÜYE OL</label>
		<div class="login-form">
			<div class="sign-in-htm">
				<div class="group">
					<asp:Label ID="Label1" runat="server" Text="E-Posta" CssClass="label"></asp:Label>
					<asp:TextBox ID="epostain" runat="server" CssClass="input" placeholder="E-posta" TextMode="Email"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="E-Posta kısmı boş geçilemez" ControlToValidate="epostain" Font-Bold="True" ForeColor="Red" ValidationGroup="giris"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<asp:Label ID="Label2" runat="server" Text="Şifre" CssClass="label"></asp:Label>
					<asp:TextBox ID="passwordin" runat="server" CssClass="input" placeholder="Şifre" TextMode="Password"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Şifre kısmı boş geçilemez" ControlToValidate="passwordin" Font-Bold="True" ForeColor="Red" ValidationGroup="giris"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<input id="check" type="checkbox" class="check" checked>
					<label for="check"><span class="icon"></span> 
						Beni Hatırla
					</label>
				</div>
				<div class="group">
				<asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="button" OnClick="Button1_Click" ValidationGroup="giris" />
				</div>
				<div class="hr"></div>
			
			</div></form>

			<div class="sign-up-htm">
				<div class="group">
					<label for="user" class="label">Ad-Soyad</label>
					<asp:TextBox ID="nametxt" runat="server" CssClass="input" placeholder="Ad-Soayd"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"  ErrorMessage="Ad-soyad kısmı boş geçilemez" ControlToValidate="nametxt" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit"></asp:RequiredFieldValidator>
				<div class="group">
					<label for="pass" class="label">Şifre</label>
					
					<asp:TextBox ID="passwordtxt" runat="server" placeholder="Şifre" TextMode="Password" CssClass="input"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Şifre Kısmı boş geçilemez" ControlToValidate="passwordtxt" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
					<label for="pass" class="label">Şifreyi Tekrar Girin</label>
					<asp:TextBox ID="passwordtxt2" runat="server" placeholder="Şifre" TextMode="Password" CssClass="input"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Şifre tekrar kısmı boş geçilemez" ControlToValidate="passwordtxt2" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit"></asp:RequiredFieldValidator>
				</div>
				<div class="group">
                     <label for="pass" class="label">E-Posta</label>
					<asp:TextBox ID="emailtxt" runat="server" placeholder="E-Posta" TextMode="Email" CssClass="input"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server"  ErrorMessage="E-Posta kısmı boş geçilemez" ControlToValidate="emailtxt" Font-Bold="True" ForeColor="Red" ValidationGroup="kayit"></asp:RequiredFieldValidator>
					
				</div>
				<div class="group">
				<asp:Button ID="Button2" runat="server" Text="Kaydı Tamamla" CssClass="button" OnClick="Button2_Click" ValidationGroup="kayit"/>
				</div>
				</div>
				<div class="hr"></div>
				<div class="foot-lnk">
					<label for="tab-1">

Zaten Üye misiniz?</a>
				</div>
			</div>
		</div>
	</div>
</div>
    </form>
</body>
</html>

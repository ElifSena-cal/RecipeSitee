<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="AboutUs.aspx.cs" Inherits="WebApplication2.hakkimizda" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link href="assets/css/about-us.css" rel="stylesheet" />
    <div class="about-section paddingTB60 gray-bg">
                <div class="container">
                    <div class="row">
						<div class="col-md-7 col-sm-6" style="width: 86%">
							<div class="about-title clearfix">
								<h1>Bizim <span>Hakkımızda</span></h1>
								<h3>İştah açan, ilham veren, ağız sulandıran... Sadece yemek tarifleri değil... Güldürürken yediren...
Sadece karnını doyurmak isteyenler için değil, bir hazzın peşinde koşanlar için. </h3>
							
                                <h5 style="text-align: justify">
							
    <asp:Label ID="Label1" runat="server" Text="Label" Height="30px" style="font-size: medium; color: #666666; font-weight: normal; margin-top: 0px" Width="749px"></asp:Label>
						        </h5>
						<div class="about-icons">
                            <ul>
                                <li><a href="https://www.facebook.com/"><i id="social-fb" class="fa fa-facebook-square fa-3x social"></i></a> </li>
                                <li><a href="https://twitter.com/"><i id="social-tw" class="fa fa-twitter-square fa-3x social"></i></a> </li>
                                <li> <a href="https://plus.google.com/"><i id="social-gp" class="fa fa-google-plus-square fa-3x social"></i></a> </li>
                                <li> <a href="mailto:bootsnipp@gmail.com"><i id="social-em" class="fa fa-envelope-square fa-3x social"></i></a> </li>
                            </ul>       
               
               
	           
	           
	        
	        </div>
							</div>
						</div>
						<div class="col-md-5 col-sm-6">
							<div class="about-img">
								<img src="https://devitems.com/preview/appmom/img/mobile/2.png" alt="">
							</div>
						</div>	
                    </div>
                </div>
            </div>
</asp:Content>

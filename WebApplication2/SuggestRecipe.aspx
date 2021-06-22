<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="SuggestRecipe.aspx.cs" Inherits="WebApplication2.TarifÖner" UnobtrusiveValidationMode="None" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


 

 



<form class="form-compact" action="" style="height: 463px; margin-top: 7px;" >
            <div class="row paddingBottom20">
                <div class="container col-4" style="width: 99%; height: 391px; margin-left: 0px">
                    <div class="row">
                        <h6 class="text-center col-12 mb-0">Tarif Öner</h6>
                        <sub class="text-right text-muted col-12"><a href="#" tabindex="-1"><i class="far fa-edit"></i></a></sub>
                    </div>
                    <div class="dropdown-divider mb-3"></div>
                    <div class="form-group row">
                       <asp:Label ID="Label1" runat="server" Text="Tarif Adı:" CssClass="col-4 col-form-label-sm text-right"></asp:Label>
                        <div class="col-8">
                            <div class="input-group" style="left: 0px; top: 0px"> 
                               	<asp:TextBox ID="tarifadtxt" runat="server" CssClass="form-control form-control-sm" placeholder="Tarif Adı"  ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Tarif Ad kısmı boş geçilemez" ControlToValidate="tarifadtxt" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div> 
                    <div style="height: 15px"></div>
                    <div class="form-group row align-items-center">
                          <asp:Label ID="Label2" runat="server" Text="Malzeme:" CssClass="col-4 col-form-label-sm text-right"></asp:Label>
                        <div class="col-8">
                          <div class="input-group" style="left: 0px; top: 0px; height: 140px"> 
                           <asp:TextBox ID="tarifmalzemetxt" runat="server" CssClass="form-control form-control-sm" placeholder="Malzeme"  TextMode="MultiLine"></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Malzeme kısmı boş geçilemez" ControlToValidate="tarifmalzemetxt" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                    </div>
                        <div style="height: 15px"></div>
                    <div class="form-group row align-items-center">
                          <asp:Label ID="Label5" runat="server" Text="Kategori:" CssClass="col-4 col-form-label-sm text-right"></asp:Label>
                        <div class="col-8">
                          <div class="input-group" style="left: 0px; top: 0px; height: 20px"> 
                              <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                          </div>
                          
                        </div>
                    </div>
                    <div style="height: 15px"></div>

                    <div class="form-group row align-items-center">
                       <asp:Label ID="Label3" runat="server" Text="Yapılışı:" CssClass="col-4 col-form-label-sm text-right"></asp:Label>
                        <div class="col-8">
                          <div class="input-group"> 
                         <asp:TextBox ID="tarifyapilistxt" runat="server" CssClass="form-control form-control-sm" placeholder="Yapılış"  TextMode="MultiLine" Height="121px" ></asp:TextBox><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Yapılış kısmı boş geçilemez" ControlToValidate="tarifyapilistxt" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                    </div>
                    <div style="height: 15px"></div>
                    <div class="form-group row align-items-center">
                          <asp:Label ID="Label4" runat="server" Text="Tarifin Resmi:" CssClass="col-4 col-form-label-sm text-right"></asp:Label>
                        <div class="col-8">
                          <div class="input-group">
                            <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control form-control-sm"  /><asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Tarif Resmi kısmı boş geçilemez" ControlToValidate="FileUpload1" Font-Bold="True" ForeColor="Red"></asp:RequiredFieldValidator>
                          </div>
                        </div>
                    </div>
                 
                
                     
                          <div class="input-group">
                        <asp:Button ID="Button1" runat="server" Text="Tarifi Gönder" Height="31px" style="margin-left: 276px" Width="169px" OnClick="Button1_Click"  />
          
                              </div>
                </div>
              
            </div>
        </form>

 </asp:Content>




   
           
    

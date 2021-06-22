using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using BussinessLayer.Abstract;
using DataAccsessLayer.Concrete.Ado_Net;
using BussinessLayer.Concrete;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        //baglanti baglanti = new baglanti();

        private IUserService _userService; 
        protected void Page_Load(object sender, EventArgs e)
        {
_userService = new UserManager(new UserDal());
            
        }
        

        protected void Button1_Click(object sender, EventArgs e)
        {
         
         var b = _userService.GetAll().Find(a => a.UserEmail == epostain.Text && a.UserPassword == passwordin.Text);
           
        
            if (b!=null)
            {
                if (b.Userid==1)
                {
                    Response.Redirect("https://localhost:44379/Admin/AdminCategory.aspx");
                }
                  Session.Add("Name-Surname", b.UserName);
                  Session.Add("E-Mail", b.UserEmail);
                 Response.Redirect("https://localhost:44379/HomePage.aspx");
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Hatalı giriş!Lütfen tekrar deneyiniz');</script>");
            }






        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (passwordtxt.Text==passwordtxt2.Text)
            {
               
                _userService.SignUp(nametxt.Text, emailtxt.Text, passwordtxt.Text);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Kayıt başarılı.');</script>");
            }
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Şifreler aynı değil!');</script>");

        
        }
        } 
}
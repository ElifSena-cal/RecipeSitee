using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete.Ado_Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Admin
{
    public partial class AdminAboutUs : System.Web.UI.Page
    {
        private IAboutUsService _aboutUsService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _aboutUsService = new AboutUsManager(new AboutUsDal());
            if (Page.IsPostBack==false)
            {
      var a  = _aboutUsService.GetAll().FirstOrDefault();
         
            aboutus.Text = a.Text;
            }   
      
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _aboutUsService.Update(aboutus.Text);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Hakkımzda metni güncellenmiştir.' );</script>");
        }
    }
}
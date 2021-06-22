using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete.Ado_Net;

namespace WebApplication2
{
    public partial class hakkimizda : System.Web.UI.Page
    {
        private IAboutUsService _aboutUsService;

        protected void Page_Load(object sender, EventArgs e)
        {

         _aboutUsService = new AboutUsManager(new AboutUsDal());
            Label1.Text = _aboutUsService.GetAll().Last().Text;


        }
    }
}
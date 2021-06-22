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
using Org.BouncyCastle.Asn1.Ocsp;
using Ubiety.Dns.Core;

namespace WebApplication2
{
    public partial class KategoriDetay : System.Web.UI.Page
    {
        string categoryid = "";
    
        private IFoodService _foodService;  
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryid = Request.QueryString["Categoryid"];
          


            _foodService = new FoodManager(new FoodDal());


            
            DataList1.DataSource = _foodService.GetByCategory(categoryid);
            DataList1.DataBind();

        }
    }
}
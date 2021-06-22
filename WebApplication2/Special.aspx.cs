using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using BussinessLayer.Abstract;
using DataAccsessLayer.Concrete.Ado_Net;
using BussinessLayer.Concrete;

namespace WebApplication2
{
    public partial class GununYemegi : System.Web.UI.Page
    {

        private IFoodService _foodService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _foodService = new FoodManager(new FoodDal());
            DataList1.DataSource = _foodService.GetFoodOfTheDay();
            DataList1.DataBind();

        }
    }
}
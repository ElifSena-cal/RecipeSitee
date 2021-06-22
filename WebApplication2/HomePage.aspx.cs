using System;
using BussinessLayer.Concrete;
using BussinessLayer.Abstract;
using DataAccsessLayer.Concrete.Ado_Net;

namespace WebApplication2
{
    public partial class Anasayfaa : System.Web.UI.Page
    {

        private IFoodService _foodService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _foodService = new FoodManager(new FoodDal());
            DataList2.DataSource = _foodService.GetAll();
            DataList2.DataBind();
      
            

        }
    }
}
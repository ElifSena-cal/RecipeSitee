using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete;
using DataAccsessLayer.Concrete.Ado_Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Admin
{
    public partial class AdminSuggestRecipe : System.Web.UI.Page
    {

        private ISuggestRecipeService _suggestRecipeService;
        private ICategoryService categoryService;
     
        protected void Page_Load(object sender, EventArgs e)
        {

            _suggestRecipeService = new SuggestRecipeManager(new SuggestRecipeDal());
            categoryService = new CategoryManager(new CategoryDal());
            GetAll();

        }

        private void GetAll()
        {
            DataList1.DataSource = _suggestRecipeService.GetAll();
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
            var a = _suggestRecipeService.GetAll().FirstOrDefault();


            _suggestRecipeService.AddToHomepage(a.FoodName, a.FoodStuff, a.Recipe, a.FoodImage, a.Categoryid.ToString());
            categoryService.UpdateAmount(a.Categoryid.ToString());
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yemek Eklenmiştir' );</script>");
            Delete(a);
            GetAll();
           
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            var a = _suggestRecipeService.GetAll().FirstOrDefault();
            Delete(a);
        }

        private void Delete(EntityLayer.Concrete.SuggestRecipe a)
        {
            _suggestRecipeService.Delete(a.Specificationid.ToString());
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yemek Silinmiştir' );</script>");
            GetAll();
        }

     
    }
}
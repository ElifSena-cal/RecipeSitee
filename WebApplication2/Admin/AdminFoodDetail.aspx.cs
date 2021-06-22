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
    public partial class AdminFoodDetail : System.Web.UI.Page
    {
        private IFoodService _foodService;
        private ICategoryService _categoryService;
        string foodid;

        protected void Page_Load(object sender, EventArgs e)
        {
            _foodService = new FoodManager(new FoodDal());
            _categoryService = new CategoryManager(new CategoryDal());
         
            foodid = Request.QueryString["id"];
            if (Page.IsPostBack == false)
            {
                var a = _foodService.FoodDetail(foodid).SingleOrDefault();
                name.Text = a.FoodName.ToString();
                Stuff.Text = a.FoodStuff.ToString();
                Recipe.Text = a.Recipe.ToString();  
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "Categoryid";
                DropDownList1.DataSource = _categoryService.GetAll();
                DropDownList1.DataBind();

             
              
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("/assets/img/" + FileUpload1.FileName));
            _foodService.Update(name.Text, Stuff.Text, Recipe.Text, DropDownList1.SelectedValue, FileUpload1.FileName,foodid);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yemek Güncellenmiştir.' );</script>");
         
            name.Text = null;
            Stuff.Text = null;
            Recipe.Text = null;
           
            _categoryService.UpdateAmount(DropDownList1.SelectedValue);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            _foodService.FoodOfTheDay(foodid);
        }
    }
}
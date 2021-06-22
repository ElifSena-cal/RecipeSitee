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
    public partial class AdminFood : System.Web.UI.Page
    {
        string foodid = "";
        string process = "";
        private IFoodService _foodService;
        private ICategoryService _categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _categoryService = new CategoryManager(new CategoryDal());
            _foodService = new FoodManager(new FoodDal());
            if (Page.IsPostBack==false)
            {
                DropDownList1.DataTextField = "CategoryName";
                DropDownList1.DataValueField = "Categoryid";
                DropDownList1.DataSource=_categoryService.GetAll();
                DropDownList1.DataBind();
                foodid = Request.QueryString["ide"];
                process = Request.QueryString["process"];
            }
            GetAll();
            if (process == "delete")
            {
                _foodService.Delete(foodid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yemek Silinmiştir' );</script>");
            }
            GetAll();

        }
        private void GetAll()
        {
            DataList1.DataSource = _foodService.GetAll();
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("/assets/img/" + FileUpload1.FileName));
            _foodService.Add(name.Text, Stuff.Text, Recipe.Text, DropDownList1.SelectedValue,FileUpload1.FileName);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yemek Eklenmişitr.' );</script>");
            GetAll();
            name.Text = null;
            Stuff.Text = null;
            Recipe.Text = null;
            _categoryService.UpdateAmount(DropDownList1.SelectedValue);



        }
    }
}
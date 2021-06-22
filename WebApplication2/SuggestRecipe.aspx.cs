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
using DataAccsessLayer.Concrete;

namespace WebApplication2
{
    public partial class TarifÖner : System.Web.UI.Page
    {
        
        private ISuggestRecipeService _suggestRecipeService;
        private ICategoryService _categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {
            _categoryService = new CategoryManager(new CategoryDal());
            DropDownList1.DataTextField = "CategoryName";
            DropDownList1.DataValueField = "Categoryid";
            DropDownList1.DataSource = _categoryService.GetAll();
            DropDownList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _suggestRecipeService = new SuggestRecipeManager(new SuggestRecipeDal());
            _suggestRecipeService.Add(tarifadtxt.Text, tarifmalzemetxt.Text, tarifyapilistxt.Text, FileUpload1.FileName, Session["Name-Surname"].ToString(), Session["E-Mail"].ToString(),DropDownList1.SelectedValue);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Tarifiniz Alınmıştır');</script>");



        }

        

    }
}
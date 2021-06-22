using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Admin
{
    public partial class AdminCategoryDetail : System.Web.UI.Page
    {
        private ICategoryService _categoryService;
        string categoryid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            categoryid = Request.QueryString["ide"];

            _categoryService = new CategoryManager(new CategoryDal());

            if (Page.IsPostBack == false)
            {
                var a = _categoryService.GetByCategoryid(categoryid).SingleOrDefault();


                categorynumbertxt.Text = a.CategoryNumber.ToString();
                categorynametxt.Text = a.CategoryName;
            }







        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _categoryService.Update(categoryid, categorynametxt.Text, categorynumbertxt.Text);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Kategori Düzenlenmiştir');</script>");
            categorynametxt.Text = null;
            categorynumbertxt.Text = null;
        }
    }
}
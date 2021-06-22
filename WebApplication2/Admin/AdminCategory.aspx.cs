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
    public partial class AdminCategory : System.Web.UI.Page
    {
        string categoryid = "";
        string process = "";
        private ICategoryService _categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack==false)
            {
                categoryid = Request.QueryString["ide"];
                process = Request.QueryString["process"];
            }
            _categoryService = new CategoryManager(new CategoryDal());
            if (process=="delete")
            {
                _categoryService.Delete(categoryid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Kategori Silinmiştir' );</script>");
            }
            GetAll();
           
        }

        private void GetAll()
        {
            DataList1.DataSource = _categoryService.GetAll();
            DataList1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _categoryService.Add(name.Text);

            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Kategori Eklenmişitr.' );</script>");
            GetAll();
            name.Text = null;
        }
    }
}
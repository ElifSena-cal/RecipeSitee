using System;

using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete;

namespace WebApplication2
{
    public partial class Site1 : System.Web.UI.MasterPage
    { 
     

       
        private ICategoryService categoryService;
        protected void Page_Load(object sender, EventArgs e)
        {

            categoryService = new CategoryManager(new CategoryDal());
            DataList1.DataSource = categoryService.GetAll();
            DataList1.DataBind();
            if (Session.Count != 0)
            {
                Label4.Text = Session["Name-Surname"].ToString();

                Label4.Visible = true;
                HyperLink1.Visible = false;
                HyperLink2.Visible = true;
            
            }
         
        }
    }
}
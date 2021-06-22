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
using DataAccsessLayer.Abstract;

namespace WebApplication2
{
    public partial class YemekDetayy : System.Web.UI.Page
    {


        string foodid = "";
        private ICommentService _commentService;
        private IFoodService _foodService;
        protected void Page_Load(object sender, EventArgs e)
        {
            foodid = Request.QueryString["foodid"];
            _foodService = new FoodManager(new FoodDal());
            DataList2.DataSource = _foodService.FoodDetail(foodid);
            DataList2.DataBind();

            //Yorumları Listeleme
            _commentService = new CommentManager(new CommentDal());
            DataList1.DataSource = _commentService.GetComment(foodid);
            DataList1.DataBind();
         }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session.Count!=0)
            {

                _commentService.SaveComment(foodid, Session["Name-Surname"].ToString(), Session["E-Mail"].ToString(), Text.Text);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yorumunz Alınmıştır');</script>");
            }
           else if (Session.Count==0)
            {
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yorum Yapabilmek için üye olmanız gerekmektedir!');</script>");
            }
        }

    }
}

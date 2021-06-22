using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete.Ado_Net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Admin
{
    public partial class AdminCommentDetail : System.Web.UI.Page
    {
        private ICommentService _commentService;
        string commentid = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            _commentService = new CommentManager(new CommentDal());
            commentid = Request.QueryString["commentid"];
            SqlCommand command = new SqlCommand("Select CommentName,CommentMail,CommentText,FoodName from dbo.Comment inner join dbo.Food on dbo.Comment.Foodid=dbo.Food.Foodid where commentid=@p1 ", Connection.bgl());
            command.Parameters.AddWithValue("@p1",Convert.ToInt32(commentid));
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                name.Text = dr[0].ToString();
                mail.Text = dr[1].ToString();
                text.Text = dr[2].ToString();
                foodname.Text = dr[3].ToString();
            }
            Connection.bgl().Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            _commentService.ConfirmComment(commentid, text.Text);
            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yorum Onaylanmıştır' );</script>");
        }
    }
}
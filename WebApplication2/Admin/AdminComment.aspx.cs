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
    public partial class AdminMessagee : System.Web.UI.Page
    {
        string commentid = "";
        string process = "";
        private ICommentService _commentService;
        protected void Page_Load(object sender, EventArgs e)
        {

            _commentService = new CommentManager(new CommentDal());
            GetAll();
            commentid = Request.QueryString["ide"];
            process = Request.QueryString["process"];
            if (process=="delete")
            {
                _commentService.Delete(commentid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Yorum Silinmiştir' );</script>");
            }
            GetAll();
        }

        private void GetAll()
        {
            DataList1.DataSource = _commentService.UnapprovedComments();
            DataList1.DataBind();

            DataList2.DataSource = _commentService.ApprovedComments();
            DataList2.DataBind();
        }
    }
}
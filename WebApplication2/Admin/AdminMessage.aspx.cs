using BussinessLayer.Abstract;
using BussinessLayer.Concrete;
using DataAccsessLayer.Concrete.Ado_Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2.Admin
{
    public partial class AdminMessage : System.Web.UI.Page
    {
        private IMessageService _messageService;
        string messageid = "";
        string process = "";
        
        protected void Page_Load(object sender, EventArgs e)
        {
          
        
            if (Page.IsPostBack == false)
            {
                messageid = Request.QueryString["Messageid"];
                process = Request.QueryString["process"];
            } 
            _messageService = new MessageManager(new MessageDal());
            if (process == "delete")
            {
                _messageService.Delete(messageid);
                Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mesaj Silinmiştir' );</script>");
            }
            GetMessage();

        }

        private void GetMessage()
        {
            DataList1.DataSource = _messageService.GetAll();
            DataList1.DataBind();
        }

    }
}
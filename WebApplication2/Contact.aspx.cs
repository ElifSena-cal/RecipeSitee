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
using System.Threading;

namespace WebApplication2
{
    public partial class iletişimm : System.Web.UI.Page
    {
        private IMessageService _messageService;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void myFunction(object sender, EventArgs e)
        {

            _messageService = new MessageManager(new MessageDal());
            _messageService.Add(nametxt.Text, titletxt.Text, emailtxt.Text, contenttxt.Text);







            Page.ClientScript.RegisterStartupScript(this.GetType(), "Scripts", "<script>alert('Mesajınız Alınmıştır');</script>");


        }
    }
}
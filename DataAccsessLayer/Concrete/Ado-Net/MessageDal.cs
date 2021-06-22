using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Ado_Net
{
    public class MessageDal : IMessageDal
    {
        public  void Add(string sender, string title, string mail, string content)
        {
            SqlCommand command = new SqlCommand("insert into dbo.Message (MessageSender,MessageTitle,MessageMail,MessageContent) values(@p1,@p2,@p3,@p4)",Connection.bgl());
           
            command.Parameters.AddWithValue("@p1", sender);
            command.Parameters.AddWithValue("@p2", title);
            command.Parameters.AddWithValue("@p3", mail);
            command.Parameters.AddWithValue("@p4", content);

            command.ExecuteNonQuery();
            Connection.bgl().Close();
           
        }

        public void Delete(string messageid)
        {
            SqlCommand command = new SqlCommand("Delete from dbo.Message where messageid=@p1", Connection.bgl());

            command.Parameters.AddWithValue("@p1", Convert.ToInt16(messageid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Message> GetAll()
        {
            List<Message> messages = new List<Message>();
            SqlCommand command = new SqlCommand("Select * from dbo.Message", Connection.bgl());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Message message = new Message();
                message.Messageid = (short)dr[0];
                message.MessageSender = dr[1].ToString();
                message.MessageTitle = dr[2].ToString();
                message.MessageMail = dr[3].ToString();
                message.MessageContent = dr[4].ToString();
                messages.Add(message);
            }
            Connection.bgl().Close();
            return messages;
        }
    }
}

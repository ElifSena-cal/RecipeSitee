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
    public class CommentDal : ICommentDal
        
    {
        public void ConfirmComment(string commentid, string commenttext)
        {
            SqlCommand command = new SqlCommand("Update dbo.Comment set commenttext=@p1,confirmation=@p2 where commentid=@p3", Connection.bgl());
            command.Parameters.AddWithValue("@p1", commenttext);
            command.Parameters.AddWithValue("@p2", true);
            command.Parameters.AddWithValue("@p3", commentid);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Comment> GetComment(string foodid)
        {
            List<Comment> comments = new List<Comment>();
            SqlCommand command = new SqlCommand("select*from dbo.Comment where Foodid=@p1 and Confirmation=1", Connection.bgl());
           
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(foodid));
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Comment comment = new Comment();
                comment.CommentText = dr[5].ToString();
                comment.CommentName = dr[1].ToString();
                comment.CommentHistory = (DateTime)dr[3];
                comments.Add(comment);
            }
            Connection.bgl().Close();
            return comments;
        }

        public List<Comment> ApprovedComments()
        {
            List<Comment> comments = new List<Comment>();
            SqlCommand command = new SqlCommand("select*from dbo.Comment where confirmation=1",Connection.bgl());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Comment comment = new Comment();
                comment.Commentid = (short)dr[0];
                comment.CommentName = dr[1].ToString();
              
                comments.Add(comment);
            }
            Connection.bgl().Close();
            return comments;

        }

        public void SaveComment(string foodid, string name, string mail, string text)
        {
          
            SqlCommand command= new SqlCommand("insert into dbo.Comment (CommentName,CommentMail,CommentText,Foodid) values(@p1,@p2,@p3,@p4)", Connection.bgl());
            if (command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", name);
            command.Parameters.AddWithValue("@p2", mail);
            command.Parameters.AddWithValue("@p3", text);
            command.Parameters.AddWithValue("@p4", Convert.ToInt32(foodid));
          
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Comment> UnapprovedComments()
        {
            List<Comment> comments = new List<Comment>();
            SqlCommand command = new SqlCommand("select*from dbo.Comment where confirmation=0", Connection.bgl());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Comment comment = new Comment();
                comment.Commentid = (short)dr[0];
                comment.CommentName = dr[1].ToString();

                comments.Add(comment);
            }
            Connection.bgl().Close();
            return comments;
        }

        public void Delete(string commentid)
        {
            SqlCommand command = new SqlCommand("Delete from dbo.Comment where commentid=@p1", Connection.bgl());

            command.Parameters.AddWithValue("@p1", Convert.ToInt16(commentid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
    }


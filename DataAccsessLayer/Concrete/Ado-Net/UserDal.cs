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
    public class UserDal : IUserDal
    {
        public List<User> GetAll()
        {
            List<User> users = new List<User>();
            SqlCommand command = new SqlCommand("Select*from [User]", Connection.bgl());
            if (command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                User user = new User();
                user.Userid = (short)dr[0];
                user.UserName = dr[1].ToString();
                user.UserPassword = dr[2].ToString();
                user.UserEmail = dr[3].ToString();
                users.Add(user);
            }
            dr.Close();
            return users;
        }

       




        public void SignUp(string name, string email, string password)
        {
            SqlCommand command = new SqlCommand("insert into [User] (UserName,UserEmail,UserPassword)values (@p1,@p2,@p3)", Connection.bgl());
            if (command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1",name);
            command.Parameters.AddWithValue("@p3", password);
            command.Parameters.AddWithValue("@p2", email);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
}

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
    public class AboutUsDal : IAboutUsDal
    {
        public List<AboutUs> GetAll()
        {
            List<AboutUs> aboutUs = new List<AboutUs>();
            SqlCommand command= new SqlCommand("Select*from dbo.AboutUs", Connection.bgl());
          
            SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
            {
                AboutUs about = new AboutUs();
                about.Textid = (short)dr[0];
                about.Text = dr[1].ToString();
                aboutUs.Add(about);
            }
            return aboutUs;
        }

        public void Update(string text)
        {
            SqlCommand command = new SqlCommand("Update dbo.AboutUs set text=@p1", Connection.bgl());
            command.Parameters.AddWithValue("@p1", text);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
}

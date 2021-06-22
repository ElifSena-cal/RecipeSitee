using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Ado_Net;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        public void Add(string categoryName)
        {
            SqlCommand command = new SqlCommand("insert into dbo.Category(CategoryName) values (@p1)", Connection.bgl());
      
            command.Parameters.AddWithValue("@p1", categoryName);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public void Delete(string categoryid)
        {
            SqlCommand command = new SqlCommand("Delete from dbo.Category where categoryid=@p1", Connection.bgl());
           
            command.Parameters.AddWithValue("@p1", Convert.ToInt16(categoryid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Category> GetAll()
        {
            List<Category> categories = new List<Category>();
            SqlCommand command= new SqlCommand("Select*from dbo.Category", Connection.bgl());
           
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Category category = new Category();
                category.Categoryid= (short)dr[0];
                category.CategoryName = dr[1].ToString();
                category.CategoryNumber = (short)dr[2];
                categories.Add(category);

            }
            Connection.bgl().Close();
            return categories;
        }

        public List<Category> GetByCategoryid(string categoryid)
        { 
            List<Category> categories = new List<Category>();
            SqlCommand command = new SqlCommand("select*from dbo.Category where Categoryid=@p1", Connection.bgl());
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(categoryid));
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Category categorys = new Category();
                categorys.CategoryName = dr[1].ToString();
                categorys.CategoryNumber = (short)dr[2];
                categories.Add(categorys);

            } Connection.bgl().Close();
            return categories;
           
        }

        public void Update(string categorid, string categoryName, string categoryQuantity)
        {
            SqlCommand command = new SqlCommand("Update dbo.Category set categoryname=@p1,categorynumber=@p2 where categoryid=@p3", Connection.bgl());
            command.Parameters.AddWithValue("@p1", categoryName);
            command.Parameters.AddWithValue("@p2", categoryQuantity);
            command.Parameters.AddWithValue("@p3", categorid);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public void UpdateAmount(string categoryid)
        {
            SqlCommand command = new SqlCommand("Update Dbo.Category set categorynumber=categorynumber+1 where categoryid=@p1", Connection.bgl());
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(categoryid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
}

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
    public class FoodDal : IFoodDal
    {
        public void Add(string foodname, string foodstuff, string foodrecipe, string catehoryid, string image)
        {
            SqlCommand command = new SqlCommand("insert into dbo.Food (foodname,foodstuff,recipe,categoryid,foodImage,Confirmation) values(@p1,@p2,@p3,@p4,@p5,@p6)", Connection.bgl());
            command.Parameters.AddWithValue("@p1", foodname);
            command.Parameters.AddWithValue("@p2", foodstuff);
            command.Parameters.AddWithValue("@p3", foodrecipe);
            command.Parameters.AddWithValue("@p4", catehoryid);
            command.Parameters.AddWithValue("@p5", image);
            command.Parameters.AddWithValue("@p6", false);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        
        }

        public void Delete(string foodid)
        {
            SqlCommand command = new SqlCommand("Delete from dbo.Food where foodid=@p1", Connection.bgl());

            command.Parameters.AddWithValue("@p1", Convert.ToInt16(foodid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Food> FoodDetail(string foodid)
        {
            List<Food> foods = new List<Food>();
            SqlCommand command = new SqlCommand("select*from dbo.Food where Foodid=@p1", Connection.bgl());
          
            command.Parameters.AddWithValue("@p1", Convert.ToInt32(foodid));
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.FoodName = dr[1].ToString();
                food.FoodStuff = dr[2].ToString();
                food.Recipe = dr[3].ToString();
                food.FoodImage = dr[4].ToString();
                foods.Add(food);

            }
            Connection.bgl().Close();
            return foods;
        }

        public void FoodOfTheDay(string foodid)
        {
            SqlCommand command = new SqlCommand("Update dbo.Food set durum=0", Connection.bgl());
            command.ExecuteNonQuery();
            SqlCommand command1 = new SqlCommand("Update dbo.Food set durum=1 where foodid=@p1",Connection.bgl());
            command1.Parameters.AddWithValue("@p1", foodid);
            command1.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public List<Food> GetAll()
        {
            List<Food> foods = new List<Food>();
            SqlCommand command = new SqlCommand("Select*from dbo.Food", Connection.bgl());
        
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.Foodid = (short)dr[0];
                food.FoodName = dr[1].ToString();

                food.FoodImage = dr[4].ToString();

                foods.Add(food);
            }
            Connection.bgl().Close();
            return foods;
        }

        public List<Food> GetByCategory(string categoryid)
        {

            List<Food> foods = new List<Food>();
            SqlCommand komut = new SqlCommand("Select*from dbo.Food where Categoryid=@p1", Connection.bgl());
          
            komut.Parameters.AddWithValue("@p1", Convert.ToInt16(categoryid));
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.Foodid = (short)dr[0];
                food.FoodName = dr[1].ToString();
                food.FoodStuff = dr[2].ToString();
                food.Recipe = dr[3].ToString();
                food.FoodImage = dr[4].ToString();
                food.Categorid = (short)dr[6];
                foods.Add(food);
            }
            Connection.bgl().Close();
            return foods;
        }

        public List<Food> GetFoodName()
        {
            List<Food> foods = new List<Food>();
            SqlCommand command = new SqlCommand("Select*from dbo.Food", Connection.bgl());
         
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.Foodid = (short)dr[0];
                food.FoodName = dr[1].ToString();
                foods.Add(food);
            }
            Connection.bgl().Close();
            return foods;
        }

        public List<Food> GetFoodOfTheDay()
        {
            List<Food> foods = new List<Food>();
            SqlCommand command = new SqlCommand("Select*from dbo.Food where confirmation=1", Connection.bgl());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                Food food = new Food();
                food.FoodName = dr[1].ToString();
                food.FoodStuff = dr[2].ToString();
                food.Recipe = dr[3].ToString();
                food.FoodImage = dr[4].ToString();
                foods.Add(food);
            }
            return foods;
        }

        public void Update(string foodname, string foodstuff, string foodrecipe, string categoryid, string image,string foodid)
        {
            SqlCommand command = new SqlCommand("Update dbo.Food set foodname=@p1,foodstuff=@p2,Recipe=@p3,foodImage=@p4,categoryid=@p5 where foodid=@p6", Connection.bgl());
            command.Parameters.AddWithValue("@p1", foodname);
            command.Parameters.AddWithValue("@p2", foodstuff);
            command.Parameters.AddWithValue("@p3", foodrecipe);
            command.Parameters.AddWithValue("@p4", image);
            command.Parameters.AddWithValue("@p5", categoryid);
            command.Parameters.AddWithValue("@p6", foodid);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
}

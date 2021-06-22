

using DataAccsessLayer.Abstract;
using DataAccsessLayer.Concrete.Ado_Net;
using EntityLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete.Ado_Net
{
    public class SuggestRecipeDal : ISuggestRecipeDal
    {
        public List<SuggestRecipe> GetAll()
        {
            List<SuggestRecipe> suggestRecipes = new List<SuggestRecipe>();
            SqlCommand command = new SqlCommand("Select*from dbo.SuggestRecipe", Connection.bgl());
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                SuggestRecipe suggest = new SuggestRecipe();
                suggest.Specificationid = (short)dr[0];
                suggest.FoodName = dr[1].ToString();
                suggest.FoodStuff = dr[2].ToString();
                suggest.Recipe = dr[3].ToString();
                suggest.FoodImage = dr[4].ToString();
                suggest.RecipeSender = dr[5].ToString();
                suggest.RecipeSenderMail = dr[6].ToString();
                suggest.Categoryid = (short)dr[8];
                suggest.Confirmation = (bool)dr[7];
                suggestRecipes.Add(suggest);
            }
            return suggestRecipes;
        }

        public void Add(string foodName, string foodStuff, string recipe, string foodImage, string sender, string senderMail,string categoryid)
        {

            SqlCommand command= new SqlCommand("insert into dbo.SuggestRecipe (FoodName,FoodStuff,Recipe,FoodImage,RecipeSender,RecipeSenderMail,Categoryid) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",Connection.bgl());
            if (command.Connection.State != System.Data.ConnectionState.Open)
            {
                command.Connection.Open();
            }
            command.Parameters.AddWithValue("@p1", foodName);
            command.Parameters.AddWithValue("@p2", foodStuff);
            command.Parameters.AddWithValue("@p3", recipe);
            command.Parameters.AddWithValue("@p4", foodImage);
            command.Parameters.AddWithValue("@p5", sender);
            command.Parameters.AddWithValue("@p6",senderMail);
            command.Parameters.AddWithValue("@p7", categoryid);

            command.ExecuteNonQuery();
            Connection.bgl().Close();



        }

        public void AddToHomepage(string foodName, string foodStuff, string recipe, string foodImage, string categoryid)
        {
            
            SqlCommand command = new SqlCommand("insert into dbo.Food(FoodName,FoodStuff,Recipe,FoodImage,Categoryid) values(@p1,@p2,@p3,@p4,@p5)", Connection.bgl());
            command.Parameters.AddWithValue("@p1", foodName);
            command.Parameters.AddWithValue("@p2", foodStuff);
            command.Parameters.AddWithValue("@p3", recipe);
            command.Parameters.AddWithValue("@p4", foodImage);
            command.Parameters.AddWithValue("@p5",categoryid);
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }

        public void Delete(string specificationid)
        {
            SqlCommand command = new SqlCommand("Delete from  dbo.SuggestRecipe where Specificationid=@p1", Connection.bgl());

            command.Parameters.AddWithValue("@p1", Convert.ToInt16(specificationid));
            command.ExecuteNonQuery();
            Connection.bgl().Close();
        }
    }
}

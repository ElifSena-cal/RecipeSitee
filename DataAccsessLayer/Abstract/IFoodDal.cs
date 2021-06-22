using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
   public interface IFoodDal:IEntityRepository<Food>
    {
        List<Food> GetByCategory(string categoryid);
        List<Food> FoodDetail(string foodid);
        List<Food> GetFoodName();
        void Add(string foodname,string foodstuff,string foodrecipe,string catehoryid,string image);
        void Update(string foodname, string foodstuff, string foodrecipe, string catehoryid, string image, string foodid);
        void Delete(string foodid);
        void FoodOfTheDay(string foodid);
        List<Food> GetFoodOfTheDay();
      
    




    }
}

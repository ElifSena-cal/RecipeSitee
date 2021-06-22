using BussinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class FoodManager : IFoodService
    {
        private IFoodDal _foodDal;
        public FoodManager(IFoodDal foodDal)
        {
            _foodDal = foodDal;
        }

        public void Add(string foodname, string foodstuff, string foodrecipe, string catehoryid,string image)
        {
            _foodDal.Add(foodname, foodstuff, foodrecipe, catehoryid,image);
        }

        public void Delete(string foodid)
        {
            _foodDal.Delete(foodid);

        }

        public List<Food> FoodDetail(string foodid)
        {
            return _foodDal.FoodDetail(foodid);
        }

        public void FoodOfTheDay(string foodid)
        {
            _foodDal.FoodOfTheDay(foodid);
        }

        public List<Food> GetAll()
        {
            return _foodDal.GetAll();
        }

        public List<Food> GetByCategory(string categoryid)
        {

            return _foodDal.GetByCategory(categoryid);
        }

        public List<Food> GetFoodName()
        {
            return _foodDal.GetFoodName();
        }

        public List<Food> GetFoodOfTheDay()
        {
            return _foodDal.GetFoodOfTheDay();
        }

        public void Update(string foodname, string foodstuff, string foodrecipe, string categoryid, string image,string foodid)
        {
            _foodDal.Update(foodname, foodstuff, foodrecipe, categoryid, image,foodid);
        }
    }
}

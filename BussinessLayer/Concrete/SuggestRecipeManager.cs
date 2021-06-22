using BussinessLayer.Abstract;
using DataAccsessLayer.Abstract;
using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BussinessLayer.Concrete
{
    public class SuggestRecipeManager : ISuggestRecipeService
    {
        private ISuggestRecipeDal _suggestRecipeDal;
        public SuggestRecipeManager(ISuggestRecipeDal suggestRecipeDal)
        {
            _suggestRecipeDal = suggestRecipeDal;
        }

        public List<SuggestRecipe> GetAll()
        {
            return _suggestRecipeDal.GetAll();
        }

        public void Add(string foodName, string foodStuff, string recipe, string foodImage, string sender, string senderMail, string categoryid)
        {
            _suggestRecipeDal.Add(foodName, foodStuff, recipe, foodImage, sender, senderMail,categoryid);
        }

      
        public void AddToHomepage(string foodName, string foodStuff, string recipe, string foodImage, string categoryid)
        {
            _suggestRecipeDal.AddToHomepage(foodName, foodStuff, recipe, foodImage, categoryid);
        }

        public void Delete(string specificationid)
        {
            _suggestRecipeDal.Delete(specificationid);
        }
    }
}

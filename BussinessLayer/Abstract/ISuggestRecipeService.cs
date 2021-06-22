using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
   public interface ISuggestRecipeService
    {
        void Add(string foodName, string foodStuff, string recipe, string foodImage, string sender, string senderMail, string categoryid);
        List<SuggestRecipe> GetAll();
        void AddToHomepage(string foodName, string foodStuff, string recipe, string foodImage, string categoryid);
        void Delete(string specificationid);
    }
}

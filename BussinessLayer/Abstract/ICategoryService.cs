using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
   public interface ICategoryService
    {
        List<Category> GetAll();
        void Add(string categoryName);
        List<Category> GetByCategoryid(string categoryid);
        void Update(string categorid, string categoryName, string categoryQuantity);
        void Delete(string categoryid);
        void UpdateAmount(string categoryid);

    }
}

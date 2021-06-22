using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
   public  interface ICategoryDal:IEntityRepository<Category>
    {
        void Add(string categoryName);
        List<Category> GetByCategoryid(string categoryid);
        void Update(string categorid, string categoryName, string categoryQuantity);
        void Delete(string categoryid);
        void UpdateAmount(string categoryid);

    }
}

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
     public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(string categoryName)
        {
            _categoryDal.Add(categoryName);
        }

        public void Delete(string categoryid)
        {
            _categoryDal.Delete(categoryid);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public List<Category> GetByCategoryid(string categoryid)
        {
            return _categoryDal.GetByCategoryid(categoryid);
        }

        public void Update(string categorid, string categoryName, string categoryQuantity)
        {
            _categoryDal.Update(categorid, categoryName, categoryQuantity);
        }

        public void UpdateAmount(string categoryid)
        {
            _categoryDal.UpdateAmount(categoryid);
        }
    }
}

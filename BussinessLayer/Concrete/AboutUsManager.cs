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
    public class AboutUsManager : IAboutUsService
    {
        private IAboutUsDal _aboutDal;

        
        public AboutUsManager(IAboutUsDal aboutUsDal)
        {
            _aboutDal = aboutUsDal;
            
        }
        public List<AboutUs> GetAll()
        {
           return _aboutDal.GetAll();
        }

        public void Update(string text)
        {
            _aboutDal.Update(text);
        }
    }
}

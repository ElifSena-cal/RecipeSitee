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
    public class MessageManager : IMessageService
    {
        private IMessageDal _messageDal;
        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public void Add(string sender, string title, string mail, string content)
        {
            _messageDal.Add(sender, title, mail, content);
        }

        public void Delete(string messageid)
        {
            _messageDal.Delete(messageid);
        }

        public List<Message> GetAll()
        {
            return _messageDal.GetAll();
        }

     
    }
}

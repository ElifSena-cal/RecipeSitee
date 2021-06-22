using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
   public interface IMessageService
    {
        void Add(string sender, string title, string mail, string content);
        List<Message> GetAll();
        void Delete(string messageid);
    }
}

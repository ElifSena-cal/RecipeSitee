using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
 public interface IMessageDal:IEntityRepository<Message>
    {
        
       void Add(string sender,string title,string mail,string content);
        void Delete(string messageid);
       





    }
}

using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Abstract
{
     public interface ICommentDal
    {
        List<Comment> GetComment(string foodid);
        List<Comment> ApprovedComments();

        void SaveComment(string foodid,string name,string mail,string text);
        void ConfirmComment(string commentid, string commenttext);
        List<Comment> UnapprovedComments();
        void Delete(string commentid);

    }
}

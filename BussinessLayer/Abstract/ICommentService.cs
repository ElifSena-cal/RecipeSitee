using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface ICommentService
    {
        List<Comment> GetComment(string foodid);
        void SaveComment(string foodid, string name, string mail, string text);
        List<Comment> ApprovedComments();
        void ConfirmComment(string commentid, string commenttext);
        List<Comment> UnapprovedComments();
        void Delete(string commentid);



    }
}

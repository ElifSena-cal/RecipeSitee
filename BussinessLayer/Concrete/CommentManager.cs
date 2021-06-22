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
    public class CommentManager : ICommentService
    {
        private DataAccsessLayer.Abstract.ICommentDal _commentDal;
        public CommentManager(DataAccsessLayer.Abstract.ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public List<Comment> ApprovedComments()
        {
            return   _commentDal.ApprovedComments();
        }

        public void ConfirmComment(string commentid, string commenttext)
        {
            _commentDal.ConfirmComment(commentid, commenttext);
        }

        public void Delete(string commentid)
        {
            _commentDal.Delete(commentid);
        }

        public List<Comment> GetComment(string foodid)
        {
            return _commentDal.GetComment(foodid); 
        }

      
        public void SaveComment(string foodid, string name, string mail, string text)
        {
            _commentDal.SaveComment(foodid, name, mail, text);
        }

        public List<Comment> UnapprovedComments()
        {
            return _commentDal.UnapprovedComments();
        }
    }
}

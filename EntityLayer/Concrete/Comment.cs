using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public class Comment:IEntity
    {
        [Key]
        public Int16 Commentid { get; set; }
        [StringLength(500)]
        public string CommentName { get; set; }
        [StringLength(200)]
        public string CommentMail { get; set; }
        public DateTime CommentHistory { get; set; }
        public bool Confirmation { get; set; }
        [StringLength(1000)]
        public string CommentText { get; set; }
        public Int16 Foodid { get; set; }
        public virtual Food Food { get; set; }
    }
}

using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public  class Message:IEntity
    {
        [Key]
        public Int16 Messageid { get; set; }
        [StringLength(100)]
        public string MessageSender { get; set; }
        [StringLength(100)]
        public string MessageTitle { get; set; }
        [StringLength(100)]
   
        public string MessageMail { get; set; }    
        [StringLength(500)]
        public string MessageContent { get; set; }
    }
}

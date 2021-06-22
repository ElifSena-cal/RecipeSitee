using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class AboutUs:IEntity
    {
        [Key]
        public Int16 Textid { get; set; }
        [StringLength(500)]
        public string Text { get; set; }
    }
}

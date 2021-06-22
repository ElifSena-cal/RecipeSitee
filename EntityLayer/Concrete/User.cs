using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
  public   class User:IEntity
    { 
        [Key]
        public Int16 Userid { get; set; }
        [StringLength(100)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string UserPassword { get; set; }
        [StringLength(100)]
        public string UserEmail { get; set; }

    }
}

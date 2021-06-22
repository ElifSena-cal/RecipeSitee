using EntityLayer.Abstract;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
   public class Food:IEntity
    {
        [Key]
        public Int16 Foodid { get; set; }
        [StringLength(500)]
        
        public string FoodName { get; set; }
        [StringLength(1000)]
        public string FoodStuff { get; set; }
        [StringLength(1000)]
        public string Recipe { get; set; }
        [StringLength(500)]
        public string FoodImage { get; set; }
 
        public Int16 Categorid { get; set; }
        public virtual Category Category { get; set; }
        public bool Confirmation { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}

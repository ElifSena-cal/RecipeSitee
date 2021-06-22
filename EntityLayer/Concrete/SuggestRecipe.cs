using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
   public  class SuggestRecipe:IEntity
    {
        [Key]
        public Int16 Specificationid { get; set; }
        [StringLength(500)]
        public string FoodName { get; set; }
        [StringLength(1000)]
        public string FoodStuff { get; set; }
        [StringLength(1000)]
        public string Recipe { get; set; }
        [StringLength(500)]
        public string FoodImage { get; set; }
        [StringLength(200)]
        public string RecipeSender { get; set; }
        [StringLength(200)]
        public string RecipeSenderMail { get; set; }
        public bool Confirmation { get; set; }
        public int Categoryid { get; set; }
        public virtual Category Category{ get; set; }
    }
}

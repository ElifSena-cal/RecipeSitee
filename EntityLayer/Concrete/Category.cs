using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
     public class Category:IEntity
    {
        [Key]
        public Int16 Categoryid { get; set; }
        [StringLength(100)]
        public string CategoryName{ get; set; }

        public Int16 CategoryNumber { get; set; }
        public ICollection<SuggestRecipe> suggestRecipes{ get; set; }
        public ICollection<Food> Foods { get; set; }
    }
}

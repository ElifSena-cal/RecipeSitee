using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.Concrete
{
    public class Context : DbContext

    {
        public DbSet<Food> Foods { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<AboutUs> AboutUs { get; set; }
        public DbSet<SuggestRecipe> SuggestRecipes { get; set; }

        public DbSet<User> Users{ get; set; }
        public DbSet<Message> Messages{ get; set; }

    }
}

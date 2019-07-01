using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete
{
    public class PreloadedContent : DropCreateDatabaseIfModelChanges<BlogProjectDbContext>
    {
        protected override void Seed(BlogProjectDbContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Finans"},
                new Category { Name = "Gündem"},
                new Category { Name = "Mobil"},
                new Category { Name = "Oyun"},
                new Category { Name = "Teknoloji"},
                new Category { Name = "Sağlık"},
                new Category { Name = "Spor"},
                new Category { Name = "Yaşam"}
            };

            var tags = new List<Tag>
            {
                new Tag { Name = "Web Development" },
                new Tag { Name = "ASP.NET MVC" },
                new Tag { Name = "N-Tier" },
                new Tag { Name = "Entity Framework" },
                new Tag { Name = "ADO.NET" },
                new Tag { Name = "SQL" },
                new Tag { Name = "C#" },
                new Tag { Name = "HTML"},
                new Tag { Name = "CSS"},
                new Tag { Name = "JavaScript"},
                new Tag { Name = "Angular"},
                new Tag { Name = "Bootstrap"},
                new Tag { Name = "jQuery"},
                new Tag { Name = "ReactJS"},
                new Tag { Name = "Vue.js"}
            };

            context.Categories.AddRange(categories);
            context.Tags.AddRange(tags);
            context.SaveChanges();
        }
    }
}
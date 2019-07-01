using BlogProject.DAL.Mapping;
using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete
{
    public class BlogProjectDbContext : DbContext
    {
        public BlogProjectDbContext() : base("Server = CTNKYWORKS ; Database = BlogProjectDb; Trusted_Connection = true") // DÜZENLEMEYİ UNUTMA.
        {
            Database.SetInitializer<BlogProjectDbContext>(new PreloadedContent());
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new TagMapping());
            modelBuilder.Configurations.Add(new UserMapping());
        }
    }
}

using BlogProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Model
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string PhotoUrl { get; set; } // HttpPostedFileBase diye bir şey de var.

        public int CategoryID { get; set; }
        public int UserID { get; set; }
        
        public virtual Category Category { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}

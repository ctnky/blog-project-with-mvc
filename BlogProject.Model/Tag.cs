using BlogProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Model
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }
}

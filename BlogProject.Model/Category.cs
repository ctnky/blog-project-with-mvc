using BlogProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Model
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public Article Article { get; set; }
    }
}

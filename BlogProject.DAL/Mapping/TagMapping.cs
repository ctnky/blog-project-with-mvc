using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Mapping
{
    public class TagMapping : EntityTypeConfiguration<Tag>
    {
        public TagMapping()
        {
            ////
        }
    }
}

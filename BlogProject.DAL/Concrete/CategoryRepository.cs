using BlogProject.Core.DAL.EntityFramework;
using BlogProject.DAL.Abstract;
using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.DAL.Concrete
{
    public class CategoryRepository : EFRepositoryBase<Category, BlogProjectDbContext>, ICategoryDAL
    {
        ////
    }
}

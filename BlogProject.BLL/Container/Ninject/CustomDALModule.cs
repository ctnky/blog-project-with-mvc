using BlogProject.DAL.Abstract;
using BlogProject.DAL.Concrete;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Container.Ninject
{
    public class CustomDALModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IArticleDAL>().To<ArticleRepository>();
            Bind<ICategoryDAL>().To<CategoryRepository>();
            Bind<ITagDAL>().To<TagRepository>();
            Bind<IUserDAL>().To<UserRepository>();
        }
    }
}

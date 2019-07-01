using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract
{
    public interface IArticleService : IBaseService<Article>
    {
        //// controller tarafında oluşacak ihtiyaca göre buraya metotlar yazılacak.

        List<Article> GetArticleOfCategory(int categoryID); //mesela
    }
}

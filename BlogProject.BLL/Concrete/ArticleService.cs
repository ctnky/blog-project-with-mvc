using BlogProject.BLL.Abstract;
using BlogProject.DAL.Abstract;
using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Concrete
{
    public class ArticleService : IArticleService
    {
        IArticleDAL _articleDAL;

        public ArticleService(IArticleDAL article)
        {
            _articleDAL = article;
        }

        public void Delete(Article entity)
        {
            _articleDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Article article = _articleDAL.Get(a => a.ID == entityID);
            Delete(article);
        }

        public ICollection<Article> GetAll()
        {
            return _articleDAL.GetAll();
        }

        public List<Article> GetArticleOfCategory(int categoryID)
        {
            return _articleDAL.GetAll(a => a.CategoryID == categoryID).ToList();
        }

        public Article GetByID(int entityID)
        {
            return _articleDAL.Get(a => a.ID == entityID);
        }

        public void Insert(Article entity)
        {
            _articleDAL.Add(entity);
        }

        public void Update(Article entity)
        {
            _articleDAL.Update(entity);
        }
    }
}

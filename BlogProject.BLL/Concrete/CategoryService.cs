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
    public class CategoryService : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryService(ICategoryDAL category)
        {
            _categoryDAL = category;
        }

        public void Delete(Category entity)
        {
            _categoryDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Category category = _categoryDAL.Get(a => a.ID == entityID);
            Delete(category);
        }

        public ICollection<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetByID(int entityID)
        {
            return _categoryDAL.Get(a => a.ID == entityID);
        }

        public void Insert(Category entity)
        {
            _categoryDAL.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDAL.Update(entity);
        }
    }
}

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
    public class TagService : ITagService
    {
        ITagDAL _tagDAL;

        public TagService(ITagDAL tag)
        {
            _tagDAL = tag;
        }
        public void Delete(Tag entity)
        {
            _tagDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            Tag tag = _tagDAL.Get(a => a.ID == entityID);
            Delete(tag);
        }

        public ICollection<Tag> GetAll()
        {
            return _tagDAL.GetAll();
        }

        public Tag GetByID(int entityID)
        {
            return _tagDAL.Get(a => a.ID == entityID);
        }

        public void Insert(Tag entity)
        {
            _tagDAL.Add(entity);
        }

        public void Update(Tag entity)
        {
            _tagDAL.Update(entity);
        }
    }
}

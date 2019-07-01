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
    public class UserService : IUserService
    {
        IUserDAL _userDAL;

        public UserService(IUserDAL user)
        {
            _userDAL = user;
        }

        public void Delete(User entity)
        {
            _userDAL.Remove(entity);
        }

        public void DeleteByID(int entityID)
        {
            User user = _userDAL.Get(a => a.ID == entityID);
            Delete(user);
        }

        public ICollection<User> GetAll()
        {
            return _userDAL.GetAll();
        }

        public User GetByID(int entityID)
        {
            return _userDAL.Get(a => a.ID == entityID);
        }

        public User GetUserByLogin(string username, string password)
        {
            return _userDAL.Get(a => a.Username == username && a.Password == password);
        }

        public void Insert(User entity)
        {
            _userDAL.Add(entity);
        }

        public void Update(User entity)
        {
            _userDAL.Update(entity);
        }
    }
}

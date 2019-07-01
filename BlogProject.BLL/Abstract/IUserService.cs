using BlogProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.BLL.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        //// controller tarafında oluşacak ihtiyaca göre buraya metotlar yazılacak.
    
        User GetUserByLogin(string username, string password); // mesela
    }
}

using BlogProject.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Model
{
    public class User : BaseEntity
    {
        public User()
        {
            IsApproved = false;
        }

        public string Username { get; set; }
        public string Password { get; set; }
        public string PhotoUrl { get; set; } // HttpPostedFileBase diye bir şey de var.
        public string Mail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsApproved { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
    }

    public enum UserType
    {
        Standart, Admin
    }
}

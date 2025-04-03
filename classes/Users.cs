using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OP
{
    public abstract class User
    {
        public string Username { get; set; }

        public User(string username)
        {
            Username = username;
        }
    }

    public class RegularUser : User
    {
        public RegularUser(string username) : base(username) { }
    }

    public class AdminUser : User
    {
        public AdminUser(string username) : base(username) { }
    }
}

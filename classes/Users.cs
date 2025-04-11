using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace OP
{
    public abstract class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public User(string username, string email, string passwordHash)
        {
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
        }
    }


    public class RegularUser : User
    {
        public RegularUser(string username, string email, string password)
            : base(username, email, password) { }
    }

    public class AdminUser : User
    {
        public AdminUser(string username, string email, string password)
            : base(username, email, password) { }
    }




}

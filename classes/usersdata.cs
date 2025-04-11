using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;


namespace OP
{
    public static class UserData
    {
        private static string path = "users.json";

        public static List<User> Users = new List<User>();

        public static void LoadUsers()
        {
            if (File.Exists(path))
            {
                string json = File.ReadAllText(path);
                var loadedUsers = JsonConvert.DeserializeObject<List<RegularUser>>(json);

                // перевірка на null
                if (loadedUsers != null)
                    Users = new List<User>(loadedUsers);
                else
                    Users = new List<User>();
            }
            else
            {
                Users = new List<User>();
            }
        }


        public static void SaveUsers()
        {
            string json = JsonConvert.SerializeObject(Users, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static bool UsernameExists(string username)
        {
            return Users.Any(u => u.Username == username);
        }
    }
}

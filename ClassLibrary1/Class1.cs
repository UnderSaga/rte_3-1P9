using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public string Login { get; }

        public User(string login)
        {
            Login = login;
        }
        public static User LogIn(string login, string password)
        {
            return login == "admin" && password == "123" ? new User(login): null;
        }
    }
}

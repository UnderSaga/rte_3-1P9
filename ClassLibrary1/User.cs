using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string PasswordHash { get; set; }


        public static void CreateAdmin()
        {
            using (var db = new DBContext())
            {
                var user = new User { Login = "Admin", PasswordHash = "Admin" };
                db.Users.Add(user);
                Special special = new Special { Code = 'П', Name = "Программисты" };
                db.Specials.Add(special);
                for (int y = 0; y < 4; y++)
                {
                    for (int sg = 0; sg < 2; sg++)
                    {
                        Grop grop = new Grop 
                        { 
                            ClassRoom = 9, 
                            SubGroup = sg, 
                            StartYear = 2019 + y, 
                            Special = special
                        };
                        db.Grops.Add(grop);
                    }        
                }
                db.SaveChanges();
            }
        }

        public static User LogIn(string login, string password)
        {
            {
                using (var db = new DBContext())
                {
                    try
                    {
                        return db.Users.Where(u => u.Login == login && u.PasswordHash == password).First();
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
        }
    }
}

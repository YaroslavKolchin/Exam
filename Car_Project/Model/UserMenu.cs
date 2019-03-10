using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace Car_Project
{
    public class UserMenu
    {
        public UserMenu() { }
        public bool Registration(User user, out string message)
        {
            try
            {
                using (var db = new LiteDatabase("User.db"))
                {
                    var users = db.GetCollection<User>("Users");
                    users.Insert(user);

                    message = "Registered";
                    return true;
                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return false;
            }

        }
        public User SignIn(string login, string password, out string message)
        {
            User user = null;

            try
            {
                using (var db = new LiteDatabase("User.db"))
                {

                    var users = db.GetCollection<User>("Users");

                    IEnumerable<User> results =
                    users.Find(x => x.Name.Equals(login) &&
                    x.Password.Equals(password));

                    if (results.Any())
                    {
                        message = "";
                        return results.FirstOrDefault();

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        message = "Repeat login or password";
                        return user;
                    }

                }

            }
            catch (Exception ex)
            {
                message = ex.Message;
                return user;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    public static class UserHelper
    {
        public static string Print(this User user)
        {
            return $"{user.Id} - {user.Names} - {user.Role}";
        }

        public static void ValidateCredentials(this UserData userData, string name, string password)
        {
            if (name.Length < 1)
            {
                throw new Exception("Name can't be empty!");
            }
            else if (password.Length < 1)
            {
                throw new Exception("Password can't be empty!");
            }
            userData.ValidateUser(name, password);
        }

        public static User? GetUserH(this UserData userData, string name, string password)
        {
            return userData.GetUser(name, password);
        }
    }
}

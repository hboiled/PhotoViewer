using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Security
{
    public class SignInService
    {
        private PWGen PWG;
        private List<User> users;

        public SignInService()
        {
            PWG = new PWGen(new SaltGen(), new HashGen());
            //TODO users = get users from csv file
            users = new List<User>();
            users.Add(CreateUser("abc", "123"));
            users.Add(CreateUser("zzz", "zzz"));
        }

        public void RegisterUser(string username, string password)
        {
            User newUser = CreateUser(username, password);

            users.Add(newUser);

            SaveUsers();
        }

        public User CreateUser(string username, string password)
        {
            string newSalt = PWG.GetSalt();
            string securedPW = PWG.GenerateSecurePassword(password, newSalt);

            return new User(username, newSalt, securedPW);
        }

        public Boolean UsernameExists(string username)
        {
            foreach (User user in users)
            {
                if (user.Username.Equals(username))
                {
                    return true;
                }
            }

            return false;
        }

        private void SaveUsers()
        {
            // PATHING BASED ON DEBUG/BIN DIR
            string path = "..\\..\\Data\\users.csv";

            using (var w = new StreamWriter(path))
            {
                foreach (User user in users)
                {
                    string name = user.Username;
                    string salt = user.Salt;
                    string scp = user.SecuredPassword;

                    string entry = string.Format("{0},{1},{2}", name, salt, scp);

                    w.WriteLine(entry);
                    w.Flush();
                }
            }
        }
    }
}

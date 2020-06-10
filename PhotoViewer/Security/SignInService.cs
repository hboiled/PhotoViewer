using LumenWorks.Framework.IO.Csv;
using PhotoViewer.SortSearch;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoViewer.Security
{
    public class SignInService
    {
        private PWGen PWG;
        private List<User> users;

        public SignInService()
        {
            PWG = new PWGen(new SaltGen(), new HashGen());            
            users = new List<User>();         
        }

        // Loads users from csv file
        public void InsertUsersFromCSV()
        {
            string filePath = "..\\..\\Data\\users.csv";

            // 2nd arg set to false, files have no headers   
            // Default ctor assumes headers, so it skips the first entry
            using (CsvReader csv = new CsvReader(
                                    new StreamReader(filePath), false))
            {
                while (csv.ReadNextRecord())
                {
                    string name = csv[0];
                    string salt = csv[1];
                    string pw = csv[2];

                    users.Add(new User(name, salt, pw));
                }
            }
        }

        // method for signing in using hash functions
        public Boolean ProcessSignIn(string username, string password)
        {
            if (UsernameExists(username))
            {
                // get user from list
                User user = GetUser(username);
                // get user salt
                string salt = user.Salt;
                // gen secure pw 
                string userPW = user.SecuredPassword;
                // check for match between secure pw generated and the one stored                

                if (PWG.IsPasswordMatch(password, salt, userPW))
                {
                    // start main window, handled in SignIn class
                    return true;
                }                                
            }

            return false;
        }

        // registers users and directs to saving to csv file
        public Boolean ProcessRegister(string username, string password)
        {
            if (UsernameExists(username))
            {
                return false;
            }
            
            User newUser = CreateUser(username, password);

            users.Add(newUser);

            SaveUsers();
            return true;
            
        }

        // use PWGen to create user and hash password
        public User CreateUser(string username, string password)
        {
            string newSalt = PWG.GetSalt();
            string securedPW = PWG.GenerateSecurePassword(password, newSalt);

            return new User(username, newSalt, securedPW);
        }

        // check for existing users to be used in conjunction with sign in and register
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

        // Merge sort then binary search of users list
        private User GetUser(string username)
        {
            Sorter.MergeSort(users);
            int index = Searcher.BSearch(users, 0, users.Count, new User(username, "na", "na"));
            return users.ElementAt(index);
        }

        // saves user list to csv, each entry contains name, salt and hashed password
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

        // manually adding users to list
        public void AddUser(User user)
        {
            users.Add(user);
        }
    }
}

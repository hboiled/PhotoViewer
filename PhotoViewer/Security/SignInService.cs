using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Security
{
    public class SignInService
    {
        private PWGen PWG = new PWGen(new SaltGen(), new HashGen());


        public User CreateUser(string username, string password)
        {
            string newSalt = PWG.GetSalt();
            string securedPW = PWG.GenerateSecurePassword(password, newSalt);

            return new User(username, newSalt, securedPW);

        }
    }
}

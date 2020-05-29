using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer
{
    public class User
    {
        private readonly string username;
        private readonly string salt;
        private readonly string securedPassword;

        public User(string username, string salt, string securedPassword)
        {
            this.username = username;
            this.salt = salt;
            this.securedPassword = securedPassword;
        }

        public string SecuredPassword => securedPassword;

        public string Salt => salt;

        public string Username => username;
    }
}

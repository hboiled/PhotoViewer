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

        public override bool Equals(object obj)
        {
            return obj is User user &&
                   username == user.username;
        }

        public override int GetHashCode()
        {
            return 799926177 + EqualityComparer<string>.Default.GetHashCode(username);
        }
    }
}

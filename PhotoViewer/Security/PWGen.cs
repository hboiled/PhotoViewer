using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Security
{
    public class PWGen
    {
        private SaltGen saltGen;
        private HashGen hashGen;

        public PWGen(SaltGen sg, HashGen hg)
        {
            saltGen = sg;
            hashGen = hg;
        }

        public string GetSalt()
        {
            return saltGen.GetSaltString();
        }

        // hashes salted password
        public string GenerateSecurePassword(string plainTextPassword, string salt)
        {            
            string finalString = plainTextPassword + salt;

            return hashGen.HashSaltPassword(finalString);
        }

        // takes attributes of user and generates a hashed pw, compares it with internal hashed pw
        public bool IsPasswordMatch(string password, string salt, string hash)
        {
            string finalString = password + salt;
            return hash.Equals(hashGen.HashSaltPassword(finalString));
        }
    }
}

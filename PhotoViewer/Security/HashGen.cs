using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Security
{
    public class HashGen
    {
        public string HashSaltPassword(string password)
        {
            SHA256 sha = new SHA256CryptoServiceProvider();
            byte[] dataBytes = Encoding.UTF8.GetBytes(password);
            byte[] resultBytes = sha.ComputeHash(dataBytes);

            // return the hash string to the caller
            return Convert.ToBase64String(resultBytes);
        }
    }
}

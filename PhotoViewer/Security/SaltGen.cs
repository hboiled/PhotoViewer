using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.Security
{
    public class SaltGen
    {
        private static RNGCryptoServiceProvider m_cryptoServiceProvider = null;
        private const int SALT_SIZE = 24;

        public SaltGen()
        {
            m_cryptoServiceProvider = new RNGCryptoServiceProvider();
        }

        public string GetSaltString()
        {
            byte[] saltBytes = new byte[SALT_SIZE];

            m_cryptoServiceProvider.GetNonZeroBytes(saltBytes);

            string saltString = Convert.ToBase64String(saltBytes);

            return saltString;
        }
    }
}

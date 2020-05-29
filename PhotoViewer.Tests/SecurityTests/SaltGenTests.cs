using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using PhotoViewer;
using PhotoViewer.Security;
using Xunit;

namespace PhotoViewer.Tests.SecurityTests
{
    public class SaltGenTests
    {

        [Fact]
        public void SaltLengthShouldBeValid()
        {
            SaltGen saltGen = new SaltGen();            
            string salt = saltGen.GetSaltString();
            
            // Actual        
            int saltLength = salt.Length;

            // Length of string should be as expected
            // That is the SALT SIZE + 8
            int expected = 32;

            Assert.Equal(saltLength, expected);
        }

    }
}

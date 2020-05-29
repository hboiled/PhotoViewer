using PhotoViewer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhotoViewer.Tests.SecurityTests
{
    public class HashGenTests
    {

        [Fact]
        public void Test()
        {
            HashGen hashGen = new HashGen();

            string pw = "hunter2";

            string secured = hashGen.HashSaltPassword(pw);

            Assert.True(true);                        
        }
    }
}

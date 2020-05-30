using PhotoViewer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhotoViewer.Tests.SecurityTests
{
    public class SignInServiceTests
    {
        // ***CHANGE SIGNINSERVICE CTOR TO RESOLVE CONFLICT

        private PWGen PWG = new PWGen(new SaltGen(), new HashGen());
        //private SignInService signInService = new SignInService();

        [Fact]
        public void CreateUser_UsersShoulsHaveUniqueSalt()
        {
            // First user
            string username = "test1";
            string password = "password1";
            
            // Second user
            string username2 = "test2";
            string password2 = "password2";

            //User testUser1 = SignInService.CreateUser(username, password);
            //User testUser2 = SignInService.CreateUser(username2, password2);

            //Boolean saltsEqual = testUser1.Salt.Equals(testUser2.Salt);
            //Assert.False(saltsEqual);
        } 
    }
}

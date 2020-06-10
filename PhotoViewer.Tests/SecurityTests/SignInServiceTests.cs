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
        PWGen PWG;
        SignInService signInService;


        public SignInServiceTests()
        {
            PWG = new PWGen(new SaltGen(), new HashGen());
            signInService = new SignInService();
        }


        [Fact]
        public void CreateUser_UsersShoulsHaveUniqueSalt()
        {
            // First user
            string username = "test1";
            string password = "password1";
            
            // Second user
            string username2 = "test2";
            string password2 = "password2";

            User testUser1 = signInService.CreateUser(username, password);
            User testUser2 = signInService.CreateUser(username2, password2);

            bool saltsEqual = testUser1.Salt.Equals(testUser2.Salt);
            Assert.False(saltsEqual);
        }

        [Fact]
        public void ProcessSignIn_ShouldSignInValidUser()
        {
            // Test user
            string username = "Test";
            string password = "abc";

            signInService.AddUser(signInService.CreateUser(username, password));

            bool outcome = signInService.ProcessSignIn(username, password);

            Assert.True(outcome);
        }
    }
}

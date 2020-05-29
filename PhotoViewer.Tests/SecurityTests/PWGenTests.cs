using PhotoViewer.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhotoViewer.Tests.SecurityTests
{
    public class PWGenTests
    {
        private PWGen PWG = new PWGen(new SaltGen(), new HashGen());

        [Fact]
        public void IsPasswordMatch_DifferentPasswordsReturnFalse()
        {
            // Shared salt
            string salt = PWG.GetSalt();

            // Subject 1
            string securedPWOne = GetSecuredPW("password1", salt);

            // Subject 2
            string securedPWTwo = GetSecuredPW("password2", salt);

            Boolean OneEqualsTwo = securedPWOne.Equals(securedPWTwo);
            Assert.False(OneEqualsTwo);
        }

        [Fact]
        public void IsPasswordMatch_SamePasswordsReturnTrue()
        {
            // Subject 1
            string securedPWOne = GetSecuredPW("password1", PWG.GetSalt());

            // Subject 2
            string securedPWTwo = securedPWOne;

            Boolean oneEqualsTwo = securedPWOne.Equals(securedPWTwo);
            Assert.True(oneEqualsTwo);
        }

        [Fact]
        public void GenerateSecurePassword_TwoUsersWithSamePasswordShouldBeDifferent()
        {
            // Salt values
            string saltOne = PWG.GetSalt();
            string saltTwo = PWG.GetSalt();

            // First subject
            string userOnePW = GetSecuredPW("test", saltOne);
            User one = new User("one", saltOne, userOnePW);

            // Second subject
            string userTwoPW = GetSecuredPW("test", saltTwo);
            User two = new User("two", saltTwo, userTwoPW);

            Boolean oneEqualsTwo = one.SecuredPassword.Equals(two.SecuredPassword);
            Assert.False(oneEqualsTwo);
        }

        private String GetSecuredPW(string textPW, string salt)
        {            
            return PWG.GenerateSecurePassword(textPW, salt);
        }
    }
}

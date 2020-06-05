using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using PhotoViewer.SortSearch;

namespace PhotoViewer.Tests.SortSearchTests
{
    public class SorterTests
    {
        

        [Fact]
        public void MergeSort_ShouldWorkOnLists()
        {
            List<User> users = new List<User>();
            FillWithUsers(users);
            List<User> temp = new List<User>();

            List<User> sortedUsers = SortedList();//new List<User>(users);            

            //sortedUsers.Sort();
            List<User> usersTest = Sorter.MergeSort(users);

            Assert.Equal(usersTest, sortedUsers);
        }

        private List<User> SortedList()
        {
            List<User> users = new List<User>();
            users.Add(new User("Aname", "a", "a"));
            users.Add(new User("Cname", "a", "a"));
            users.Add(new User("Dname", "a", "a"));
            users.Add(new User("Lname", "a", "a"));            
            users.Add(new User("Qname", "a", "a"));            
            users.Add(new User("Yname", "a", "a"));
            
            return users;
        }

        private void FillWithUsers(List<User> users)
        {
            users.Add(new User("Aname", "a", "a"));
            users.Add(new User("Cname", "a", "a"));
            users.Add(new User("Lname", "a", "a"));
            users.Add(new User("Yname", "a", "a"));
            users.Add(new User("Qname", "a", "a"));
            users.Add(new User("Dname", "a", "a"));
        }
    }
}

using PhotoViewer.SortSearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PhotoViewer.Tests.SortSearchTests
{
    public class SearcherTests
    {

        [Fact]
        public void BinarySearch_CanFindTargetUserInList()
        {
            User target = new User("X", "A", "A");
            List<User> usersA = Sorter.MergeSort(GenUserListA());
            List<User> usersB = Sorter.MergeSort(GenUserListB());
            
            int indexB = Searcher.BSearch(usersB, 0, usersB.Count - 1, target);
            int indexA = Searcher.BSearch(usersA, 0, usersA.Count - 1, target);
            int actualA = usersA.IndexOf(target);
            int actualB = usersB.IndexOf(target);

            Assert.Equal(indexB, actualB);
            Assert.Equal(indexA, actualA);
            
        }

        private List<User> GenUserListA()
        {
            List<User> users = new List<User>();
            users.Add(new User("B", "A", "A"));
            users.Add(new User("A", "A", "A"));
            users.Add(new User("D", "A", "A"));
            users.Add(new User("G", "A", "A"));
            users.Add(new User("X", "A", "A"));
            users.Add(new User("E", "A", "A"));

            return users;
        }

        private List<User> GenUserListB()
        {
            List<User> users = new List<User>();
            users.Add(new User("X", "A", "A"));
            users.Add(new User("A", "A", "A"));
            users.Add(new User("D", "A", "A"));
            users.Add(new User("G", "A", "A"));
            users.Add(new User("C", "A", "A"));
            users.Add(new User("E", "A", "A"));

            return users;
        }
    }
}

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

            List<User> sortedUsers = SortedList();//new List<User>(users);            

            //sortedUsers.Sort();
            List<User> usersTest = Sorter.MergeSort(users);

            Assert.Equal(usersTest, sortedUsers);
        }

        [Fact]
        public void GallerySort_ShouldWorkOnLists()
        {
            List<Gallery> galleries = new List<Gallery>();
            FillWithGalleries(galleries);

            List<Gallery> sortedGalleries = SortedGalleryList();

            Sorter.GallerySort(galleries);

            Assert.Equal(galleries, sortedGalleries);
        }

        [Fact]
        public void ImageSort_ShouldWorkOnLinkedLists()
        {
            LinkedList<string> first = new LinkedList<string>();
            FillLinkedList(first);

            LinkedList<string> second = new LinkedList<string>();
            FillSortedLinkedList(second);

            Sorter.ImageSort(first);

            Assert.Equal(first, second);
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

        private List<Gallery> SortedGalleryList()
        {
            List<Gallery> galleries = new List<Gallery>();
            galleries.Add(new Gallery("C"));
            galleries.Add(new Gallery("D"));
            galleries.Add(new Gallery("L"));
            galleries.Add(new Gallery("M"));
            galleries.Add(new Gallery("W"));            
            galleries.Add(new Gallery("X"));

            return galleries;
        }

        private void FillWithGalleries(List<Gallery> galleries)
        {
            galleries.Add(new Gallery("D"));
            galleries.Add(new Gallery("W"));
            galleries.Add(new Gallery("L"));
            galleries.Add(new Gallery("X"));
            galleries.Add(new Gallery("M"));
            galleries.Add(new Gallery("C"));
        }

        private void FillLinkedList(LinkedList<string> list)
        {
            list.AddLast("L");
            list.AddLast("P");
            list.AddLast("V");
            list.AddLast("A");
            list.AddLast("Z");
            list.AddLast("R");
        }
        private void FillSortedLinkedList(LinkedList<string> list)
        {
            list.AddLast("A");
            list.AddLast("L");
            list.AddLast("P");
            list.AddLast("R");
            list.AddLast("V");            
            list.AddLast("Z");
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.SortSearch
{
    public class Searcher
    {
        // binary search on list of users
        public static int BSearch(List<User> users, int l, int r, User x)
        {
            if (r >= l)
            {
                int mid = l + (r - l) / 2;

                if (users.ElementAt(mid).Username.Equals(x.Username))
                {
                    return mid;
                }
                    

                if (users[mid].Username.CompareTo(x.Username) == 1)
                {
                    return BSearch(users, l, mid - 1, x);
                }                    
                else
                {
                    return BSearch(users, mid + 1, r, x);
                }
                
            }

            return -1;
        }

        // gallery linear search
        public static int GallerySearch(string name, List<Gallery> galleries)
        {
            int index = -1;

            for (int i = 0; i < galleries.Count; i++)
            {
                if (galleries.ElementAt(i).ToString().Equals(name))
                {
                    index = i;
                }
            }

            return index;
        }

        // custom search which searches the filename without extension
        public static int ImageSearch(string name, LinkedList<string> gallery)
        {
            int index = -1;

            for (int i = 0; i < gallery.Count; i++)
            {
                string properName = Path.GetFileNameWithoutExtension(gallery.ElementAt(i));
                if (properName.Equals(name))
                {
                    index = i;
                }
            }

            return index;
        }

    }
}

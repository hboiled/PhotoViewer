using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.SortSearch
{
    public class Searcher
    {
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

    }
}

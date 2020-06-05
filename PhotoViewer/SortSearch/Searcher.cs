using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoViewer.SortSearch
{
    public class Searcher
    {
        public static int Search(List<Gallery> galleries, Gallery target)
        {
            int index = -1;

            for (int i = 0; i < galleries.Count; i++)
            {
                if (galleries.ElementAt(i).Equals(target))
                {
                    index = i;
                }
            }

            return index;
        }

        //public static BSearch()

    }
}

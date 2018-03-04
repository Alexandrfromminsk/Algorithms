using System;
using System.Collections.Generic;
using System.Linq;


namespace Sorting
{
    public class Sort
    {
        public static bool less(IComparable a, IComparable b)
        {
            return a.CompareTo(b) == -1;
        }

        public static void exch(Object[] list, int a, int b)
        {
            var swap = list[a];
            list[a] = list[b];
            list[b] = swap;

        }

        public static bool isSorted(IComparable[] mylist)
        {
            for (int i = 1; i < mylist.Count(); i++)
            {
                if (less(mylist[i], mylist[i - 1]))
                    return false;
            }

            return true;
        }
        
    }
}

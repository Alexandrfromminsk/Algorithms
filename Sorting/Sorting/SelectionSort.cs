using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public class SelectionSort:Sort
    {
        public static void selectionSort(IComparable[] input)
        {
            int N = input.Count();
            for (int i=0; i<N; i++)
            {
                var min_index = i;
                for (int j=i; j<N; j++)
                {
                    if (less(input[j], input[min_index]))
                        min_index = j;                    
                }

                exch(input, i, min_index);

            }
        }

    }
}

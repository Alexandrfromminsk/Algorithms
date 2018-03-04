using System;
using System.Collections.Generic;
using System.Linq;


namespace Sorting
{
    public class InsertionSort:Sort
    {
        public static void insertionSort(IComparable[] input)
        {
            int N = input.Count();

            for (int i = 1; i < N; i++)
            {
                int j = i;
                while ((j>0) && (less(input[j], input[j - 1])))
                {
                    exch(input, j, j-1);
                    j--;
                }
            }
        }

        public static void InsertionSortReferenceImplementation(IComparable[] input)
        {
            int N = input.Count();
            for (int i = 0; i < N; i++) {
                for (int j = i; j > 0; j--)
                {
                    if (less(input[j], input[j-1]))
                        exch(input, j, j-1);
                    else
                        break;
                }
                    
                        
            }

        }
    }
}

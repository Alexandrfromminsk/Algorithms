using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //My Implementation for Learning

            IComparable[] testList =  Helper.generateRandonArray(100);
            Console.WriteLine("Original list:");
            Helper.printArray(testList);

            Console.WriteLine("Is original list sorted?");
            Console.WriteLine(Sort.isSorted(testList));

            /* InsertionSort
            InsertionSort.insertionSort(testList);
            
            Console.WriteLine("InsertionSort list:");
            Helper.printArray(testList);
            Console.WriteLine("Is new list sorted?");
            Console.WriteLine(Sort.isSorted(testList));
            */
            //SelectionSort
            SelectionSort.selectionSort(testList);

            Console.WriteLine("SelectionSort list:");
            Helper.printArray(testList);
            Console.WriteLine("Is new list sorted?");
            Console.WriteLine(Sort.isSorted(testList));
            


            Console.ReadKey();
        }  
       
    }
}

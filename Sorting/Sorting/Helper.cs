using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class Helper
    {
        public static void printArray(object[] ar)
        {
            foreach (var item in ar)
                Console.Write("{0},", item.ToString());
            Console.WriteLine();
        }

        public static IComparable[] generateRandonArray(int len)
        {
            if (len <= 0)
                throw new ArgumentException();


            IComparable[] randAr = new IComparable[len];
            Random r = new Random();
            for (int i = 0; i < len; i++)
                {
                    randAr[i] = r.Next(0, 100);
                }
            return randAr;
            
        }
    }
}

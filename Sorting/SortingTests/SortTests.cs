using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class SortTests
    {
        [TestMethod]
        public void Check_Less()
        {
            Random r = new Random();
            IComparable a = r.Next(0,50);
            IComparable b = r.Next(51, 100);

            Assert.IsTrue(Sort.less(a,b));

        }

        [TestMethod]
        public void Check_isSorted()
        {
            
            IComparable[] sortedList = { 1, 2, 3, 4, 6, 6, 9 };            

            Assert.IsTrue(Sort.isSorted(sortedList));

        }

        //Should add more tests for isSorted
    }
}

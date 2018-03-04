using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class SelectionSortTests
    {
        [TestMethod]
        public void Check_if_mySS_always_returns_isSorted()
        {
            int arrayLen = 50;
            int numberOfRepeats = 10;
            for (int i = 0; i < numberOfRepeats; i++)
            {
                var randAr = Helper.generateRandonArray(arrayLen);
                SelectionSort.selectionSort(randAr);
                Assert.IsTrue(Sort.isSorted(randAr));
            }
        }
    }
}

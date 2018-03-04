using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class InsertionSortTests
    {
        [TestMethod]
        public void Check_if_myIS_always_returns_isSorted()
        {
            int arrayLen = 50;
            int numberOfRepeats = 10;
            for (int i=0; i<numberOfRepeats; i++)
            {
                var randAr = Helper.generateRandonArray(arrayLen);
                InsertionSort.insertionSort(randAr);
                Assert.IsTrue(Sort.isSorted(randAr));
            }
        }

        [TestMethod]
        public void Check_if_referencedIS_always_returns_isSorted()
        {
            int arrayLen = 50;
            int numberOfRepeats = 10;
            for (int i = 0; i < numberOfRepeats; i++)
            {
                var randAr = Helper.generateRandonArray(arrayLen);
                InsertionSort.insertionSort(randAr);
                Assert.IsTrue(Sort.isSorted(randAr));
            }
        }
    }
}

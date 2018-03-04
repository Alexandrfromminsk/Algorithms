using System;
using Sorting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SortingTests
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void CheckLength()
        {
            int length = 10;

            var randList = Helper.generateRandonArray(length);

            Assert.AreEqual(randList.Length, length);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Negative_lenghts_Throws()
        {
            int length = -7;

            var randList = Helper.generateRandonArray(length);
            // assert is handled by the ExpectedException  
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Zero_lenghts_Throws()
        {
            int length = 0;

            var randList = Helper.generateRandonArray(length);
            // assert is handled by the ExpectedException  
        }
    }
}

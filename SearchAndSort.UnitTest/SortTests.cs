using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SearchAndSort.UnitTest
{
    [TestClass]
    public class SortTests
    {

        [TestMethod]
        public void BubbleSort_IntegerArray_SortedAscending()
        {
            //arrange
            var values = new int[] { 5, 1, 3, -2, -8 };
            var sortedValues = new int[] { -8, -2, 1, 3, 5 };

            //act
            Sort.BubbleSort<int>(values);
            
            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }

        [TestMethod]
        public void BubbleSort_StringArray_SortedAscending()
        {
            //arrange
            var values = new string[] { "kalle", "per", "Isa", "adam", "Anna" };
            var sortedValues = new string[] { "adam", "Anna", "Isa", "kalle", "per" };

            //act
            Sort.BubbleSort<string>(values);

            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }
    }


}

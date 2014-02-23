using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;

namespace SearchAndSort.UnitTest
{
    [TestClass]
    public class SortTests
    {

        [TestMethod]
        public void QuickSort_null_ExceptionNotThrown()
        {
            //act
            try
            {
                Sort.QuickSort<int>(null);
            }
            catch (NullReferenceException e)
            {
                Assert.Fail("NullReferenceException thrown");
            }

        }

        [TestMethod]
        public void QuickSort_IntegerArray_SortedAscending()
        {
            //arrange
            var values = new int[] { 5, 1, 3, -2, -8 };
            var sortedValues = new int[] { -8, -2, 1, 3, 5 };

            //act
            Sort.QuickSort<int>(values);

            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }

        [TestMethod]
        public void QuickSort_StringArray_SortedAscending()
        {
            //arrange
            var values = new string[] { "kalle", "per", "Isa", "adam", "Anna" };
            var sortedValues = new string[] { "adam", "Anna", "Isa", "kalle", "per" };

            //act
            Sort.QuickSort<string>(values);

            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }

        [TestMethod]
        public void MergeSort_null_ExceptionNotThrown()
        {
            
            try
            {
                Sort.MergeSort<int>(null);
            }
            catch (NullReferenceException e)
            {
                Assert.Fail("NullReferenceException thrown");
            }

        }

        [TestMethod]
        public void MergeSort_StringArray_SortedAscending()
        {
            //arrange
            var values = new string[] { "kalle", "per", "Isa", "adam", "Anna" };
            var sortedValues = new string[] { "adam", "Anna", "Isa", "kalle", "per" };

            //act
            string[] result = Sort.MergeSort<string>(values);

            //assert
            CollectionAssert.AreEqual(result, sortedValues);
        }

        [TestMethod]
        public void MergeSort_IntegerArray_SortedAscending()
        {
            //arrange
            var values = new int[] { 5, 1, 3, -2, -8 };
            var sortedValues = new int[] { -8, -2, 1, 3, 5 };

            //act
            int[] result = Sort.MergeSort<int>(values);

            //assert
            CollectionAssert.AreEqual(result, sortedValues);
        }


        [TestMethod]
        public void InsertionSort_null_ExceptionNotThrown()
        {

            try
            {
                Sort.InsertionSort<int>(null);
            }
            catch (NullReferenceException e)
            {
                Assert.Fail("NullReferenceException thrown");
            }

        }

        [TestMethod]
        public void InsertionSort_IntegerArray_SortedAscending()
        {
            //arrange
            var values = new int[] { 5, 1, 3, -2, -8 };
            var sortedValues = new int[] { -8, -2, 1, 3, 5 };

            //act
            Sort.InsertionSort<int>(values);

            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }

        [TestMethod]
        public void InsertionSort_StringArray_SortedAscending()
        {
            //arrange
            var values = new string[] { "kalle", "per", "Isa", "adam", "Anna" };
            var sortedValues = new string[] { "adam", "Anna", "Isa", "kalle", "per" };

            //act
            Sort.InsertionSort<string>(values);

            //assert
            CollectionAssert.AreEqual(values, sortedValues);
        }

        [TestMethod]
        public void BubbleSort_null_ExceptionNotThrown()
        {

            try
            {
                Sort.BubbleSort<int>(null);
            }
            catch (NullReferenceException e)
            {
                Assert.Fail("NullReferenceException thrown");
            }

        }

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

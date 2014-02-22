﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    /// <summary>
    /// Implementation of various sorting algorithms.
    /// </summary>
    public static class Sort
    {
     
        /// <summary>
        /// Merge sort implementation
        /// </summary>
        /// <typeparam name="T">Array type</typeparam>
        /// <param name="array">Array with elements to be sorted</param>
        /// <returns>Sorted array</returns>
        public static T[] MergeSort<T> (T[] array) where T: IComparable<T>
        {
            if (array == null || array.Count() == 0 || array.Count() == 1)
            {
                return array;
            }

            int middleIndex = array.Count() / 2;

            T[] leftArray = MergeSort(array.Take(middleIndex).ToArray());
            T[] rightArray = MergeSort(array.Skip(middleIndex).ToArray());

            T[] sortedArray = leftArray.Merge(rightArray, (x, y) => x.CompareTo(y) < 0).ToArray();

            return sortedArray;
        }

        /// <summary>
        /// Bubble sort implementation
        /// </summary>
        /// <typeparam name="T">Array type</typeparam>
        /// <param name="array">Array with elements to be sorted</param>
        public static void BubbleSort<T> (T[] array) where T: IComparable<T>
        {
            if (array == null || array.Length == 0 || array.Length == 1)
            {
                return;
            }

            int rightBoundary = array.Length;
            bool hasSwapped = false;

            do
            {
                hasSwapped = false;

                for (int i = 1; i < rightBoundary; i++)
                {
                    if (array[i-1].CompareTo(array[i]) > 0)
                    {
                        Swap(array, i - 1, i);
                        hasSwapped = true;
                    }
                }

                rightBoundary--;

            } while (hasSwapped);

        }

        /// <summary>
        /// Swaps the position of two elements within an array
        /// </summary>
        /// <typeparam name="T">Array type</typeparam>
        /// <param name="list">Array</param>
        /// <param name="pos1">Position of the first element</param>
        /// <param name="pos2">Position of the second element</param>
        public static void Swap<T> (T[] list, int pos1, int pos2)
        {
            if (list == null)
            {
                return;
            }

            try
            {
                T temp = list[pos1];
                list[pos1] = list[pos2];
                list[pos2] = temp;
            }
            catch (IndexOutOfRangeException)
            {
                throw;
            }
            
        }

        /// <summary>
        /// Extension method for IEnumerable<T> that merges two IEnumerables on
        /// a predicate condition.
        /// </summary>
        /// <typeparam name="T">Element type</typeparam>
        /// <param name="first">First IEnumerable</param>
        /// <param name="second">Second IEnumerable</param>
        /// <param name="predicate">Predicate to use while merging</param>
        /// <returns>Merged IEnumerable</returns>
        public static IEnumerable<T> Merge<T> (this IEnumerable<T> first,
                                               IEnumerable<T> second,
                                               Func<T,T, bool> predicate)
        {
            using (var firstEnumerator = first.GetEnumerator())
            using (var secondEnumerator = second.GetEnumerator())
            {
                bool firstEnumHasElementsLeft = firstEnumerator.MoveNext();
                bool secondEnumHasElementsLeft = secondEnumerator.MoveNext();

                while (firstEnumHasElementsLeft && secondEnumHasElementsLeft)
                {
                    if (predicate(firstEnumerator.Current, secondEnumerator.Current))
                    {
                        yield return firstEnumerator.Current;
                        firstEnumHasElementsLeft = firstEnumerator.MoveNext();
                    }
                    else
                    {
                        yield return secondEnumerator.Current;
                        secondEnumHasElementsLeft = secondEnumerator.MoveNext();
                    }
                }

                while (firstEnumHasElementsLeft)
                {
                    yield return firstEnumerator.Current;
                    firstEnumHasElementsLeft = firstEnumerator.MoveNext();
                }

                while (secondEnumHasElementsLeft)
                {
                    yield return secondEnumerator.Current;
                    secondEnumHasElementsLeft = secondEnumerator.MoveNext();
                }

            }
        }
    }
}

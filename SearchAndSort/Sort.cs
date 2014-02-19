using System;
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
    }
}

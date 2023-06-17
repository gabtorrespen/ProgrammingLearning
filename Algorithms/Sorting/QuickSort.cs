using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    /// <summary>
    /// Quick sort implementation class
    /// 
    /// O(n logn)
    /// As every call processes halfs there are log n leves
    /// and on each level the partition step will process every sub-array element
    /// </summary>
    public static class QuickSort<T> where T : IComparable<T>
    {
        /// <summary>
        /// Sorts the elements passed by using the quick sort algorithm
        /// </summary>
        public static void Sort(List<T> elements)
        {
            if (elements == null)
                return;

            Sort(elements, 0, elements.Count - 1);
        }

        /// <summary>
        /// Sorts the elements between the start and end indexes
        /// </summary>
        private static void Sort(List<T> elements, int start, int end)
        {
            if (start > end)
                return;

            /*
             * Get a pivot index and the elements list 
             * with smaller elements to the left and
             * greater elements to right
             */
            int pivot = Util.Partition(elements, start, end);
            
            // Repeat for elements to the left and right of the pivot
            Sort(elements, start, pivot - 1);
            Sort(elements, pivot + 1, end);
        }
    }
}

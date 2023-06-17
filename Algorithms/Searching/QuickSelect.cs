using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    /// <summary>
    /// Implementation of quick select 
    /// 
    /// O(n)
    /// As every call processes just one half, if the pivot divides the list in exactly the half
    /// the algorithm will process N +N/2 +N/4 ... 1 and this is actually 2n -1
    /// </summary>
    public static class QuickSelect<T> where T : IComparable<T>
    {
        /// <summary>
        /// It will return the element in the Kth position in the ordered list.
        /// If K is less than 1 it will automatically be set to 1, similarly if K is greater
        /// than the list count it will be set to the list count
        /// </summary>
        /// <returns>The element in the position K of the ordered list</returns>
        public static T Select(List<T> elements, int k)
        {
            if(elements == null)
                throw new ArgumentNullException(nameof(elements));

            if(elements.Count == 0)
                throw new Exception("List is empty");

            if (k < 1)
                k = 1;

            if (k > elements.Count)
                k = elements.Count;

            return Select(elements, k-1, 0, elements.Count - 1);
        }

        /// <summary>
        /// It will return the element in the K position in the ordered list 
        /// between the start and end indexes
        /// </summary>
        /// <returns>The element in the position K of the ordered list</returns>
        public static T Select(List<T> elements, int k, int start, int end)
        {
            /*
             * Get a pivot index and the elements list 
             * with smaller elements to the left and
             * greater elements to right
             */
            int pivot = Util.Partition(elements, start, end);

            // Just search for the Kth element in the appropiate half
            if (pivot.CompareTo(k) < 0)
                return Select(elements, k, pivot + 1, end);
            else if (pivot.CompareTo(k) > 0)
                return Select(elements, k, start, pivot - 1);
            else
                return elements[pivot];
        }
    }
}

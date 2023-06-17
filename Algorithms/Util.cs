using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    /// <summary>
    /// Helper class for all possible shared methods
    /// </summary>
    public static class Util
    {
        /// <summary>
        /// Return the index of an arbitray pivot. 
        /// The elements list is changed between the start and end indexes
        /// to have smaller elements than the pivot to the left and greater ones to the right
        /// </summary>
        /// <returns>Return the index of an arbitrary pivot</returns>
        public static int Partition<T>(List<T> elements, int start, int end)
            where T : IComparable<T>
        {
            // Takes an arbitrary pivot (the last element in this implementation)
            T pivot = elements[end];
            int i = start;

            for (int j = start; j < end; j++)
            {
                // If element is smaller than pivot
                if (elements[j].CompareTo(pivot) < 0)
                {
                    // Put the element to the left of the pivot and 
                    // advance the pivot
                    Swap(elements, i, j);
                    i++;
                }
            }

            // Finally swap the pivot to its right position
            Swap(elements, i, end);
            return i;
        }

        /// <summary>
        /// Swaps two elements of a list in the specified indexes
        /// </summary>
        public static void Swap<T>(List<T> elements, int a, int b)
        {
            T temp = elements[a];
            elements[a] = elements[b];
            elements[b] = temp;
        }
    }
}

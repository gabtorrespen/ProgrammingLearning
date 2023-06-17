using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    //TODO: Comment class
    //TODO: Sort the passed list
    public static class MergeSort
    {
        public static List<T> Sort<T>(List<T> array)
             where T : IComparable, IComparable<T>, IEquatable<T>
        {
            if (array.Count == 1)
                return array;

            int half = array.Count / 2;
            List<T> leftArray = Sort<T>(array.GetRange(0, half));
            List<T> rightArray = Sort<T>(array.GetRange(half, array.Count - half));

            return Merge<T>(leftArray, rightArray);
        }

        private static List<T> Merge<T>(List<T> leftArray, List<T> rightArray)
            where T : IComparable, IComparable<T>, IEquatable<T>
        {
            int l = 0, r = 0;
            List<T> finalArray = new List<T>(leftArray.Count + rightArray.Count);
            while (l < leftArray.Count && r < rightArray.Count)
            {
                if (leftArray[l].CompareTo(rightArray[r]) <= 0)
                    finalArray.Add(leftArray[l++]);
                else
                    finalArray.Add(rightArray[r++]);
            }

            if (l >= leftArray.Count)
                finalArray.AddRange(rightArray.GetRange(r, rightArray.Count - r));

            if (r >= rightArray.Count)
                finalArray.AddRange(leftArray.GetRange(l, leftArray.Count - l));

            return finalArray;
        }
    }
}

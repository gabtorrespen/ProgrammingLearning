using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    //TODO: Comment class
    //TODO: Make it generic
    public static class QuickSort
    {
        public static void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int start, int end)
        {
            if (start > end)
                return;

            int pivot = Util.Partition(arr, start, end);
            Sort(arr, start, pivot - 1);
            Sort(arr, pivot + 1, end);
        }
    }
}

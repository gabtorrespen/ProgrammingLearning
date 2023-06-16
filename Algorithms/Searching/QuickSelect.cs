using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    //TODO: Comment class
    //TODO: Make it generic
    public static class QuickSelect
    {
        public static int Select(int[] arr, int k)
        {
            return Select(arr, k, 0, arr.Length - 1);
        }

        public static int Select(int[] arr, int k, int start, int end)
        {
            int pivot = Util.Partition(arr, start, end);
            if (pivot < k)
                return Select(arr, k, pivot + 1, end);
            else if (pivot > k)
                return Select(arr, k, start, pivot - 1);
            else
                return arr[pivot];
        }
    }
}

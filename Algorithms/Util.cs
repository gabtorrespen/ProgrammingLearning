using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    //TODO: Comment class
    //TODO: Make it generic
    public static class Util
    {
        public static int Partition(int[] arr, int start, int end)
        {
            int pivot = arr[end];
            int i = start;

            for (int j = start; j < end; j++)
            {
                if (arr[j] < pivot)
                {
                    Swap(arr, i, j);
                    i++;
                }
            }
            Swap(arr, i, end);
            return i;
        }

        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
    }
}

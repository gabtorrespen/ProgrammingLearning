using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercises.Util
{
    public static class UtilArrays
    {
        public static void PrintArray<T>(List<T> array)
        {
            foreach (var item in array)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }

        public static void PrintMatrix(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}

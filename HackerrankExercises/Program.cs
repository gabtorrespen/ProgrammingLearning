using HackerrankExercises.EasyCollection;
using System;

namespace HackerrankExercises
{
    class Program
    {
        static Arrays arrays = new Arrays();

        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };

            int res = arrays.MaxProfit(prices);

            Console.WriteLine("Hello World!");
        }
    }
}

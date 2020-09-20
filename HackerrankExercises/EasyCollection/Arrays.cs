using System;
using System.Collections.Generic;
using System.Text;

namespace HackerrankExercises.EasyCollection
{
    public class Arrays
    {
        /*
        Say you have an array prices for which the ith element is the price of a given stock on day i.
        Design an algorithm to find the maximum profit. You may complete as many transactions as you like
        (i.e., buy one and sell one share of the stock multiple times).
         */

        public int MaxProfit(int[] prices)
        {
            int len = prices.Length;
            int[] buying = new int[len];
            int[] selling = new int[len];
            int[] notBuying = new int[len];
            int[] notSelling = new int[len];

            buying[len - 1] = -prices[len - 1];
            selling[len - 1] = prices[len - 1];

            for (int i = len-2; i >= 0; i--)
            {
                buying[i] = prices[i]*-1 + Math.Max(selling[i + 1], notSelling[i + 1]);
                selling[i] = prices[i] + Math.Max(buying[i + 1], notBuying[i + 1]);
                notBuying[i] = Math.Max(buying[i + 1], notBuying[i + 1]);
                notSelling[i] = Math.Max(selling[i + 1], notSelling[i + 1]);
            }

            return Math.Max(buying[0], notBuying[0]);

        }

        
    }
}

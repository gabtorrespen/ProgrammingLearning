using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercises
{
    public class ArraysNStrings
    {
        /*
         * Implement an algorithm to determine if a string has all unique characters. 
         * What if you cannot use additional data structures? 
        */
        public bool HasUniqueCharacters(string s)
        {
            bool[] checker = new bool[128];
            foreach (char c in s)
            {
                if (checker[c])
                    return false;
                else
                    checker[c] = true;
            }
            return true;

            //Without additional structures
            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < s.Length; j++)
            //    {
            //        if (i!=j && s[i].Equals(s[j]))
            //            return false;
            //    }
            //}
            //return true;
        }

        /*
         * Given two strings, write a method to decide if one is a permutation of the other.
         */
        public bool CheckPermutation(string a, string b)
        {
            if (a.Length != b.Length) return false;

            int[] checker = new int[128];
            Console.Write(checker.ToString());
            for (int i = 0; i < a.Length; i++)
            {
                checker[a[i]]++;
                checker[b[i]]++;
            }

            foreach (var item in checker)
                if (item != 2 && item != 0) return false;

            return true;
        }
    }
}

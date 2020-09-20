using Shared.Util;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
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
        }

        public bool HasUniqueCharactersWithoutStructures(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i != j && s[i].Equals(s[j]))
                        return false;
                }
            }
            return true;
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

        /*
         * Write a method to replace all spaces in a string with '%20'. You may assume that the string 
         * has sufficient space at the end to hold the additional characters,and that you are given the "true" 
         * length of the string.
         * */

        public char[] URLify(string word, int l)
        {
            char[] result = new char[word.Length];
            int spacesCount = 0, idx;
            for (int i = 0; i < l; i++)
            {
                idx = i + (spacesCount * 2);
                if (word[i] == ' ')
                {
                    result[idx] = '%';
                    result[idx + 1] = '2';
                    result[idx + 2] = '0';
                    spacesCount++;
                }
                else
                {
                    result[idx] = word[i];
                }
            }

            return result;
        }

        //MyAttempt O(n^2)
        //public char[] URLifyInPlace(char[] word, int l)
        //{
        //    int spacesCount = 0, idx;
        //    for (int i = 0; i < l; i++)
        //    {
        //        idx = i + (spacesCount * 2);
        //        if (word[idx] == ' ')
        //        {
        //            UtilStrings.MoveForward(word, idx, 2);

        //            word[idx] = '%';
        //            word[idx + 1] = '2';
        //            word[idx + 2] = '0';
        //            spacesCount++;
        //        }
        //    }
        //    return word;
        //}

        public char[] URLifyInPlace(char[] word, int l)
        {
            int spacesCount = 0, idx;

            for (int i = 0; i < l; i++)
                if (word[i] == ' ') spacesCount++;

            idx = l + spacesCount * 2 - 1;
            for (int i = l - 1; i >= 0; i--)
            {
                if (word[i] == ' ')
                {
                    word[idx] = '0';
                    word[idx - 1] = '2';
                    word[idx - 2] = '%';
                    idx -= 3;
                }
                else
                {
                    word[idx] = word[i];
                    idx--;
                }
            }
            return word;
        }

        /*
         * Check if a word is a permutation of a palindrome
         */

        public bool IsPalindromePermutation(string word)
        {
            int[] letters = new int[128];
            int caseDifference = 'a' - 'A';
            foreach (var c in word)
            {
                if (c >= 'a' && c <= 'z')
                    letters[c - caseDifference]++;

                if (c >= 'A' && c <= 'Z')
                    letters[c]++;
            }

            int possibleMiddleItems = 0;
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] % 2 == 1)
                    possibleMiddleItems++;
                if (possibleMiddleItems > 1)
                    return false;
            }
            return true;
        }

        public bool IsPalindromePermutationBit(string word)
        {
            int letters = 0;

            foreach (var c in word)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int value = c - 'a';
                    int bitValue = ((1 << value) & letters) != 0 ? 0 : 1;
                    letters = (letters & ~(1 << value)) | (bitValue << value);
                }

                if (c >= 'A' && c <= 'Z')
                {
                    int value = c - 'A';
                    int bitValue = ((1 << value) & letters) != 0 ? 0 : 1;
                    letters = (letters & ~(1 << value)) | (bitValue << value);
                }
            }

            bool oddFound = false;
            for (int i = 0; i < 32; i++)
            {
                if (((1 << i) & letters) > 0)
                {
                    if (oddFound)
                        return false;
                    else
                        oddFound = true;
                }
            }

            return true;
        }

        /*
         * Given two strings, write a function to check if they are 
         * one edit (or zero edits) away. 
         */

        public bool OneEditAway(string a, string b)
        {
            if (Math.Abs(a.Length - b.Length) > 1)
                return false;

            int[] lettersFromA = new int[128];
            int[] lettersFromB = new int[128];

            for (int i = 0; i < Math.Max(a.Length, b.Length); i++)
            {
                if (i < a.Length)
                    lettersFromA[a[i]]++;
                if (i < b.Length)
                    lettersFromB[b[i]]++;
            }

            int differencesFound = 0;
            int difference;
            for (int i = 0; i < lettersFromA.Length; i++)
            {
                difference = Math.Abs(lettersFromA[i] - lettersFromB[i]);
                if (difference > 1)
                    return false;
                else if (difference == 1)
                {
                    differencesFound++;
                    if (differencesFound > 2)
                        return false;
                }
            }
            return true;
        }

        /*
         *  Implement a method to perform basic string compression using the counts 
of repeated characters. For example, the string aabcccccaaa would become a2blc5a3. If the 
"compressed" string would not become smaller than the original string, your method should return 
the original string
         */

        public string StringCompression(string str)
        {
            if (str.Length <= 1)
                return str;

            StringBuilder sb = new StringBuilder(str[0]);
            char actual = str[0];
            int actualCount = 1;
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == actual)
                {
                    actualCount++;
                }
                else
                {
                    sb.Append($"{actual}{actualCount}");
                    actual = str[i];
                    actualCount = 1;
                }
            }
            sb.Append($"{actual}{actualCount}");

            return sb.Length < str.Length ? sb.ToString() : str;
        }

        /*
         Rotate matrix 90 degrees
        */

        public int[][] RotateSquare90(int[][] matrix)
        {
            int len = matrix.Length;
            int temp;

            for (int i = 0; i < len / 2; i++)
            {
                for (int j = i; j < len - i - 1; j++)
                {
                    temp = matrix[i][j];
                    matrix[i][j] = matrix[len - 1 - j][i];
                    matrix[len - 1 - j][i] = matrix[len - 1 - i][len - 1 - j];
                    matrix[len - 1 - i][len - 1 - j] = matrix[j][len - 1 - i];
                    matrix[j][len - 1 - i] = temp;
                }
            }

            return matrix;
        }

        /*
         * Write an algorithm such that if an element in an MxN matrix is 0, its entire row and 
column are set to 0. 
        */

        public int[][] ZeroMatrix(int[][] matrix)
        {
            int[] r = new int[matrix.Length];
            int[] c = new int[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 0)
                    {
                        r[i] = 1;
                        c[i] = 1;
                    }
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                if (r[i] == 1)
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                        matrix[i][j] = 0;
                }
                else
                {
                    for (int j = 0; j < matrix[i].Length; j++)
                    {
                        if (c[j] == 1)
                            matrix[i][j] = 0;
                    }
                }
            }
            return matrix;
        }


        public bool IsStringRotation(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            var sortedA = UtilSorting.MergeSort<char>(a.ToList());
            var sortedB = UtilSorting.MergeSort<char>(b.ToList());

            return UtilStrings.IsSubstring(sortedA.ToString(), sortedB.ToString());
        }

        public bool IsStringRotation2(string a, string b)
        {
            if (a.Length != b.Length)
                return false;

            string compositeString = a + a;
            return UtilStrings.IsSubstring(compositeString, b);
        }

    }
}

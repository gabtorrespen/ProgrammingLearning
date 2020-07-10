using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewExercises.Util
{
    public static class UtilStrings
    {
        public static void MoveForward(char[] word, int from, int steps)
        {
            for (int i = word.Length - 1; i >= from + steps; i--)
            {
                word[i] = word[i - steps];
            }
        }

        public static bool IsSubstring(string a, string b)
        {
            if (b.Length > a.Length)
                return false;

            int idxB = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[idxB])
                {
                    if (++idxB == b.Length)
                        return true;
                }
                else
                {
                    idxB = 0;
                }
            }
            return false;
        }
    }
}

using InterviewExercises;
using System;
using Xunit;

namespace UnitTesting
{
    public class ArraysNStringsTests
    {
        ArraysNStrings arraysNStrings;

        public ArraysNStringsTests()
        {
            arraysNStrings = new ArraysNStrings();
        }

        [Fact]
        public void HasUniqueCharacters()
        {
            Assert.True(arraysNStrings.HasUniqueCharacters("abc"));
            Assert.False(arraysNStrings.HasUniqueCharacters("bbacc"));
        }

        [Fact]
        public void CheckPermutation()
        {
            Assert.True(arraysNStrings.CheckPermutation("abc", "cba"));
            Assert.False(arraysNStrings.CheckPermutation("abc", "dhj"));
        }

        [Fact]
        public void URLify()
        {
            Assert.Equal<char>("Mr%20John%20Smith".ToCharArray(), arraysNStrings.URLify("Mr John Smith    ", 13));
            Assert.Equal<char>("Mr%20John%20Smith".ToCharArray(), arraysNStrings.URLifyInPlace("Mr John Smith    ".ToCharArray(), 13));
        }

        [Fact]
        public void IsPalindromePermutation()
        {
            Assert.True(arraysNStrings.IsPalindromePermutation("Tact Coa"));
            Assert.False(arraysNStrings.IsPalindromePermutation("hola"));
            Assert.True(arraysNStrings.IsPalindromePermutationBit("Tact Coa"));
            Assert.False(arraysNStrings.IsPalindromePermutationBit("hola"));
        }

        [Fact]
        public void OneEditAway()
        {
            Assert.True(arraysNStrings.OneEditAway("pale", "ple"));
            Assert.True(arraysNStrings.OneEditAway("pales", "pale"));
            Assert.True(arraysNStrings.OneEditAway("pale", "bale"));
            Assert.False(arraysNStrings.OneEditAway("pale", "bake"));
            Assert.False(arraysNStrings.OneEditAway("pale", "balec"));
        }

        [Fact]
        public void StringCompression()
        {
            Assert.Equal("a2b1c5a3", arraysNStrings.StringCompression("aabcccccaaa"));
        }

        [Fact]
        public void RotateSquare90()
        {
            int[][] array1 = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 5, 6 },
                new int[]{ 7, 8, 9 }
            };

            int[][] array2 = new int[][]
            {
                new int[]{ 1, 2, 3 ,4 },
                new int[]{ 5, 6, 7, 8 },
                new int[]{ 9, 10, 11, 12 },
                new int[]{ 13, 14, 15, 16 }
            };

            int[][] array1Solution = new int[][]
            {
                new int[]{ 7, 4, 1 },
                new int[]{ 8, 5, 2 },
                new int[]{ 9, 6, 3 }
            };

            int[][] array2Solution = new int[][]
            {
                new int[]{ 13, 9, 5 ,1 },
                new int[]{ 14, 10, 6, 2 },
                new int[]{ 15, 11, 7, 3 },
                new int[]{ 16, 12, 8, 4 }
            };

            Assert.Equal<int[][]>(array1Solution, arraysNStrings.RotateSquare90(array1));
            Assert.Equal<int[][]>(array2Solution, arraysNStrings.RotateSquare90(array2));
        }

        [Fact]
        public void ZeroMatrix()
        {
            int[][] array1 = new int[][]
            {
                new int[]{ 1, 2, 3 },
                new int[]{ 4, 0, 6 },
                new int[]{ 7, 8, 9 }
            };

            int[][] array2 = new int[][]
            {
                new int[]{ 0, 2, 3 ,4 },
                new int[]{ 5, 0, 7, 8 },
                new int[]{ 9, 10, 0, 12 },
                new int[]{ 13, 14, 15, 0 }
            };

            int[][] array1Solution = new int[][]
            {
                new int[]{ 1, 0, 3 },
                new int[]{ 0, 0, 0 },
                new int[]{ 7, 0, 9 }
            };

            int[][] array2Solution = new int[][]
            {
                new int[]{ 0, 0, 0 ,0 },
                new int[]{ 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0 },
                new int[]{ 0, 0, 0, 0 }
            };

            Assert.Equal<int[][]>(array1Solution, arraysNStrings.ZeroMatrix(array1));
            Assert.Equal<int[][]>(array2Solution, arraysNStrings.ZeroMatrix(array2));
        }

        [Fact]
        public void IsStringRotation()
        {
            Assert.True(arraysNStrings.IsStringRotation2("waterbottle", "erbottlewat"));
            Assert.False(arraysNStrings.IsStringRotation2("waterbottle", "erbottlewwt"));
        }

    }
}

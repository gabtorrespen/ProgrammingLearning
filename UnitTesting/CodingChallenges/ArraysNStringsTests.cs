using NUnit.Framework;
using System;

using CodingChallenges;

namespace UnitTesting.CodingChallenges
{
    // TODO: Comment class
    [TestFixture]
    internal class ArraysNStringsTests
    {
        [Test]
        public void HasUniqueCharacters()
        {
            Assert.True(ArraysNStrings.HasUniqueCharacters("abc"));
            Assert.False(ArraysNStrings.HasUniqueCharacters("bbacc"));
        }

        [Test]
        public void CheckPermutation()
        {
            Assert.True(ArraysNStrings.CheckPermutation("abc", "cba"));
            Assert.False(ArraysNStrings.CheckPermutation("abc", "dhj"));
        }

        [Test]
        public void URLify()
        {
            Assert.AreEqual("Mr%20John%20Smith".ToCharArray(), ArraysNStrings.URLify("Mr John Smith    ", 13));
            Assert.AreEqual("Mr%20John%20Smith".ToCharArray(), ArraysNStrings.URLifyInPlace("Mr John Smith    ".ToCharArray(), 13));
        }

        [Test]
        public void IsPalindromePermutation()
        {
            Assert.True(ArraysNStrings.IsPalindromePermutation("Tact Coa"));
            Assert.False(ArraysNStrings.IsPalindromePermutation("hola"));
            Assert.True(ArraysNStrings.IsPalindromePermutationBit("Tact Coa"));
            Assert.False(ArraysNStrings.IsPalindromePermutationBit("hola"));
        }

        [Test]
        public void OneEditAway()
        {
            Assert.True(ArraysNStrings.OneEditAway("pale", "ple"));
            Assert.True(ArraysNStrings.OneEditAway("pales", "pale"));
            Assert.True(ArraysNStrings.OneEditAway("pale", "bale"));
            Assert.False(ArraysNStrings.OneEditAway("pale", "bake"));
            Assert.False(ArraysNStrings.OneEditAway("pale", "balec"));
        }

        [Test]
        public void StringCompression()
        {
            Assert.AreEqual("a2b1c5a3", ArraysNStrings.StringCompression("aabcccccaaa"));
        }

        [Test]
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

            Assert.AreEqual(array1Solution, ArraysNStrings.RotateSquare90(array1));
            Assert.AreEqual(array2Solution, ArraysNStrings.RotateSquare90(array2));
        }

        [Test]
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

            Assert.AreEqual(array1Solution, ArraysNStrings.ZeroMatrix(array1));
            Assert.AreEqual(array2Solution, ArraysNStrings.ZeroMatrix(array2));
        }

        [Test]
        public void IsStringRotation()
        {
            Assert.True(ArraysNStrings.IsStringRotation2("waterbottle", "erbottlewat"));
            Assert.False(ArraysNStrings.IsStringRotation2("waterbottle", "erbottlewwt"));
        }

    }
}

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
            Assert.True(arraysNStrings.CheckPermutation("abc","cba"));
            Assert.False(arraysNStrings.CheckPermutation("abc","dhj"));
        }
    }
}

using NUnit.Framework;
using System.Collections.Generic;

using CodingChallenges;
using DataStructures.Util;

namespace UnitTesting.CodingChallenges
{
    [TestFixture]
    public class LinkedListsTests
    {
        [Test]
        public void RemoveDuplicates()
        {
            DataStructures.LinkedList<int> expected = LinkedList.GenerateLinkedList(new List<int> { 1, 2 });
            DataStructures.LinkedList<int> actual = LinkedList.GenerateLinkedList(new List<int> { 1, 1, 2, 2 });

            Assert.AreEqual(expected, LinkedLists.RemoveDuplicates(actual));
        }
    }
}

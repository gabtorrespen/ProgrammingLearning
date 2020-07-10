using InterviewExercises.DataStructures;
using InterviewExercises.Subjects;
using InterviewExercises.Util;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace UnitTesting
{
    public class LinkedListsTests
    {
        LinkedLists linkedLists;

        public LinkedListsTests()
        {
            linkedLists = new LinkedLists();
        }

        [Fact]
        public void RemoveDuplicates()
        {
            Node<int> expected = UtilStructures.LinkedList.GenerateLinkedList(new List<int> { 1, 2 });
            Node<int> actual = UtilStructures.LinkedList.GenerateLinkedList(new List<int> { 1, 1, 2, 2 });

            Assert.Equal(expected,linkedLists.RemoveDuplicates(actual));
        }
    }
}

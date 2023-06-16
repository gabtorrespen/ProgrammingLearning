using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

using CodingChallenges;
using DataStructures;
using DataStructures.Util;

namespace UnitTesting.CodingChallenges
{
    [TestFixture]
    public class TreesNGraphsTests
    {
        [Test]
        public void InOrderTraversalTest()
        {
            // Arrange
            TreeNode<int> root = Graph.GenerateTreeNode<int>(new List<int> { 1, 2, 3, 4, 5, 6 });
            List<int> expected = new List<int> { 4, 2, 5, 1, 6, 3 };

            // Act
            List<int> result = TreesNGraphs.InOrderTraversal(root);

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

    }
}

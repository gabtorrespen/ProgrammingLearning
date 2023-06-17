using Algorithms.Sorting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Algorithms
{
    [TestFixture]
    internal class QuickSortTests
    {
        [Test]
        public void UnorderedList_OrderList()
        {
            //Arrange
            List<int> list = new List<int> {  4, 5, 3, 6, 2, 0, 5 };
            List<int> orderedList = new List<int>(list);
            orderedList.Sort();

            //Act
            QuickSort<int>.Sort(list);

            //Assert
            CollectionAssert.AreEqual(orderedList, list);
        }

            [Test]
        public void NullList_DoNothing()
        {
            //Arrange
            List<int> nullList = null;

            //Act
            QuickSort<int>.Sort(nullList);

            //Assert
            Assert.IsNull(nullList);
        }

        [Test]
        public void EmptyList_DoNothing()
        {
            //Arrange
            List<int> emptyList = new List<int>();

            //Act
            QuickSort<int>.Sort(emptyList);

            //Assert
            Assert.IsTrue(emptyList.Count == 0);
        }
    }
}

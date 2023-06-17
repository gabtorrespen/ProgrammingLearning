using Algorithms.Searching;
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
    internal class QuickSelectTests
    {
        [Test]
        public void UnorderedListGetMedian_ReturnMedian()
        {
            //Arrange
            List<int> list = new List<int> {  4, 5, 3, 6, 2, 0, 5 };
            List<int> orderedList = new List<int>(list);
            orderedList.Sort();
            int kMedian = list.Count / 2;

            //Act
            int selectedMedian = QuickSelect<int>.Select(list, kMedian);

            //Assert
            int medianFromOrderedList = orderedList[kMedian-1];
            Assert.AreEqual(medianFromOrderedList, selectedMedian);
        }

        [Test]
        public void KthGreaterThanListLength_ReturnGreatestElement()
        {
            //Arrange
            List<int> list = new List<int> { 4, 5, 3, 6, 2, 0, 5 };
            int k = 10;

            // Act
            int element = QuickSelect<int>.Select(list, k);

            // Assert
            Assert.AreEqual(list.Max(), element);
        }

        [Test]
        public void KthSmallerThanOne_ReturnSmallestElement()
        {
            //Arrange
            List<int> list = new List<int> { 4, 5, 3, 6, 2, 0, 5 };
            int k = -10;

            // Act
            int element = QuickSelect<int>.Select(list, k);

            // Assert
            Assert.AreEqual(list.Min(), element);
        }

        [Test]
        public void NullList_ReturnNull()
        {
            //Arrange
            List<int> nullList = null;
            int k = 0;

            // Assert
            Assert.Throws<ArgumentNullException>(() => QuickSelect<int>.Select(nullList, k));
        }

        [Test]
        public void EmptyList_DoNothing()
        {
            //Arrange
            List<int> emptyList = new List<int>();
            int k = 0;

            // Assert
            Assert.Throws<Exception>(() => QuickSelect<int>.Select(emptyList, k));
        }
    }
}

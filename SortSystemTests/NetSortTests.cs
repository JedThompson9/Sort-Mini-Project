using SortSystemApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortSystemTests
{
    public class NetSortTests
    {
        int[] nums = { 7, 4, 2, 16, 8, 3, 23 };
        int[] expectedNums = { 2, 3, 4, 7, 8, 16, 23 };
        [Test]
        public void GivenASingularArrayReturnNetSortedArray()
        {
            //Arrange
            var bubbleSort = new DotNetSort();
            //Act
            bubbleSort.Sort(nums);
            //Assert
            Assert.That(nums, Is.EqualTo(expectedNums));
        }

        [Test]
        public void GivenNullArray_BubbleSort_ThrowsException()
        {
            int[] arr1 = null;
            var bubbleSort = new BubbleSort();
            Assert.That(() => bubbleSort.Sort(arr1), Throws.ArgumentNullException);
        }

        [Test]
        public void GivenEmptyArray_BubbleSort_ReturnsEmptyArray()
        {
            var bubbleSort = new BubbleSort();
            Assert.That(() => bubbleSort.Sort(Array.Empty<int>()),
                Is.EqualTo(Array.Empty<int>()));
        }
    }
}

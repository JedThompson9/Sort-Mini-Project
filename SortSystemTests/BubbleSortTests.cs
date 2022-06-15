using SortSystemApp;

namespace SortSystemTests
{
    public class BubbleSortTests
    {
        int[] nums = {7,4,2,16,8,3,23};
        int[] expectedNums = {2,3,4,7,8,16,23};
        [Test]
        public void GivenASingularArrayReturnBubbleSortedArray()
        {
            //Arrange
            var netSort = new DotNetSort();
            //Act
            netSort.Sort(nums);
            //Assert
            Assert.That(nums, Is.EqualTo(expectedNums));
        }

        [Test]
        public void GivenNullArray_BubbleSort_ThrowsException()
        {
            int[] arr1 = null;
            var netSort = new DotNetSort();
            Assert.That(() => netSort.Sort(arr1),Throws.ArgumentNullException);
        }

        [Test]
        public void GivenEmptyArray_BubbleSort_ReturnsEmptyArray()
        {
            var netSort = new DotNetSort();
            Assert.That(() => netSort.Sort(Array.Empty<int>()),
                Is.EqualTo(Array.Empty<int>()));
        }
    }
}
using SortSystemApp;

namespace SortSystemTests
{
    public class MergeSortTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenNullArray_MergeSort_ThrowsException()
        {
            int[] array = null;
            var mergeSorter = new MergeSort();
            Assert.That(() => mergeSorter.Sort(array),
                Throws.TypeOf<NullReferenceException>());
        }

        [Test]
        public void GivenEmptyArray_MergeSort_ReturnsEmptyArray()
        {
            var mergeSorter = new MergeSort();
            Assert.That(() => mergeSorter.Sort(Array.Empty<int>()),
                Is.EqualTo(Array.Empty<int>()));
        }

        [Test]
        public void GivenSortedArrays_MergeSort_ReturnsExpectedArray()
        {
            int[] array = { 1, 3, 5, 9, 2, 5, 8, 9 };
            int[] sorted = { 1, 2, 3, 5, 5, 8, 9, 9 };
            var mergeSorter = new MergeSort();
            Assert.That(() => mergeSorter.Sort(array),
                Is.EqualTo(sorted));
        }
    }
}
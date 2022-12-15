using Algorithms.Trees;
using Xunit;

namespace AlgorithmtXUnitTest.Tree
{
    public class HeapAlgorithmsTest
    {
        private HeapAlgorithms heapAlgorithms;

        public HeapAlgorithmsTest()
        {
            heapAlgorithms = new HeapAlgorithms();
        }

        [Fact]
        public void MakeHeap_Returns_Heap()
        {
            // Arrange
            int[] testArray = { 15, 11, 10, 7, 5, 9, 2, 6, 4, 3, 1, 8, 12 };
            int[] expectedArray = { 15, 11, 12, 7, 5, 10, 2, 6, 4, 3, 1, 8, 9 };

            // Act
            var result = heapAlgorithms.MakeHeap(testArray);

            // Assert
            Assert.Equal(expectedArray, result);
        }

        [Fact]
        public void RemoveHeapTopItem_Returns_Removed_Item_And_Rebuilds_Heap()
        {
            // Arrange
            int[] testArray = { 15, 11, 10, 7, 5, 9, 2, 6, 4, 3, 1, 8, 12 };
            int[] expectedArray = { 12, 11, 10, 7, 5, 9, 2, 6, 4, 3, 1, 8, 15 };

            // Act
            var result = heapAlgorithms.RemoveTopItem(ref testArray, testArray.Length);

            // Assert
            Assert.Equal(15, result);
            Assert.Equal(expectedArray, testArray);
        }
    }
}

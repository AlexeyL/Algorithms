using Algorithms.Sorting;
using System.Linq;
using Xunit;

namespace AlgorithmtXUnitTest.Sorting
{
    public class SortingAlgorithsTest
    {
        private BubbleSort bubbleSort;
        private SelectionSort selectionSort;

        public SortingAlgorithsTest()
        {
            bubbleSort = new BubbleSort();
            selectionSort = new SelectionSort();
        }
        
        [Fact]
        public void BubbleSort_Returns_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] {5, 2, 3, 9, 7, 10, 1, 4, 8, 6};
            // Act
            var sortedArray = bubbleSort.Sort(unsortedArray);
            // Assert
            Assert.Equal(new int [] {1,2,3,4,5,6,7,8,9,10}, sortedArray);
        }

        [Fact]
        public void SelectionSort_Return_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] { 5, 2, 3, 9, 7, 10, 1, 4, 8, 6 };
            // Act
            var sortedArray = selectionSort.Sort(unsortedArray.ToList());
            // Assert
            Assert.Equal(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, sortedArray.ToArray());
        }
    }
}
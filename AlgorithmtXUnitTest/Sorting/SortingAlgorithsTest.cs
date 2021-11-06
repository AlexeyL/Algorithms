using Algorithms.Sorting;
using System.Linq;
using Xunit;

namespace AlgorithmtXUnitTest.Sorting
{
    public class SortingAlgorithsTest
    {
        private BubbleSort bubbleSort;
        private SelectionSort selectionSort;
        private QuickSort quickSort;
        private InsertionSort insertionSort;

        int [] array = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public SortingAlgorithsTest()
        {
            bubbleSort = new BubbleSort();
            selectionSort = new SelectionSort();
            quickSort = new QuickSort();
            insertionSort = new InsertionSort();
        }
        
        [Fact]
        public void BubbleSort_Returns_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] {5, 2, 3, 9, 7, 10, 1, 4, 8, 6};
            // Act
            var sortedArray = bubbleSort.Sort(unsortedArray);
            // Assert
            Assert.Equal(array, sortedArray);
        }

        [Fact]
        public void SelectionSort_Returns_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] { 5, 2, 3, 9, 7, 10, 1, 4, 8, 6 };
            // Act
            var sortedArray = selectionSort.Sort(unsortedArray);
            // Assert
            Assert.Equal(array, sortedArray);
        }

        [Fact]
        public void QuickSort_Returns_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] { 5, 2, 3, 9, 7, 10, 1, 4, 8, 6 };
            // Act
            quickSort.Sort(unsortedArray, 0, unsortedArray.Length -1);
            // Assert
            Assert.Equal(array, unsortedArray);
        }

        [Fact]
        public void InsertionSort_Returns_Sorted_Array()
        {
            // Arrange
            var unsortedArray = new int[] { 5, 2, 3, 9, 7, 10, 1, 4, 8, 6 };
            // Act
            var soredList = insertionSort.Sort(unsortedArray);
            // Assert
            Assert.Equal(array, soredList);
        }
    }
}
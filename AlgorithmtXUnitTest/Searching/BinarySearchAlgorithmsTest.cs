using Algorithms.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.Searching
{
    public class BinarySearchAlgorithmsTest
    {
        private BinarySearch binarySearch;

        public BinarySearchAlgorithmsTest()
        {
            binarySearch = new BinarySearch();
        }

        [Fact]
        public void BinarySearch_SearchIterative_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var isFound = binarySearch.SearchIterative(array, item);

            // Assert
            Assert.False(isFound);
        }

        [Fact]
        public void BinarySearch_SearchIterative_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;
            
            // Act
            var isFound = binarySearch.SearchIterative(array, item);

            // Assert
            Assert.True(isFound);
        }

        [Fact]
        public void BinarySearch_SearchRecursive_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var isFound = binarySearch.SearchRecursive(array, item);

            // Assert
            Assert.False(isFound);
        }

        [Fact]
        public void BinarySearch_SearchRecursive_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;

            // Act
            var isFound = binarySearch.SearchRecursive(array, item);

            // Assert
            Assert.True(isFound);
        }
    }
}

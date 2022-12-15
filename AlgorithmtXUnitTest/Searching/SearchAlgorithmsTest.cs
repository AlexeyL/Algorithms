using Algorithms.Searching;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.Searching
{
    public class SearchAlgorithmsTest
    {
        private BinarySearch binarySearch;
        private InterpolationSearch interpolationSearch;

        public SearchAlgorithmsTest()
        {
            binarySearch = new BinarySearch();
            interpolationSearch = new InterpolationSearch();
        }

        [Fact]
        public void BinarySearch_SearchIterative_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var index = binarySearch.SearchIterative(array, item);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void BinarySearch_SearchIterative_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;
            
            // Act
            var index = binarySearch.SearchIterative(array, item);

            // Assert
            Assert.Equal(4, index);
        }

        [Fact]
        public void BinarySearch_SearchRecursive_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var index = binarySearch.SearchRecursive(array, item);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void BinarySearch_SearchRecursive_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;

            // Act
            var index = binarySearch.SearchRecursive(array, item);

            // Assert
            Assert.Equal(4, index);
        }

        [Fact]
        public void InteropolationSearch_SearchRecursive_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var index = interpolationSearch.SearchRecursive(array, item);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void InterpolationSearch_SearchRecursive_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;

            // Act
            var index = interpolationSearch.SearchRecursive(array, item);

            // Assert
            Assert.Equal(4, index);
        }

        [Fact]
        public void InteropolationSearch_SearchIterative_NotFound()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 99;

            // Act
            var index = interpolationSearch.SearchIterative(array, item);

            // Assert
            Assert.Equal(-1, index);
        }

        [Fact]
        public void InterpolationSearch_SearchIterative_Found()
        {
            // Arrange
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            var item = 5;

            // Act
            var index = interpolationSearch.SearchIterative(array, item);

            // Assert
            Assert.Equal(4, index);
        }
    }
}

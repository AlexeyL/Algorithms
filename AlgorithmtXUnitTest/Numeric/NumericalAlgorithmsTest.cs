using Algorithms.Numerical;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.Numeric
{
    public class NumericalAlgorithmsTest
    {
        NumericalAlgorithms numericalAlgorithms;

        public NumericalAlgorithmsTest()
        {
            numericalAlgorithms = new NumericalAlgorithms();
        }

        [Fact]
        public void RandomizeArray_Returns_ShuffledArray()
        {
            // Arrange
            var initialArray = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Act
            var shuffledarray = numericalAlgorithms.RandomizeAnArray(initialArray);

            // Assert
            Assert.NotEqual(initialArray, shuffledarray);
        }

        [Fact]
        public void FindGreatestCommotDivisor_ReturnsGCD()
        {
            // Arrange
            var numA = 4851;
            var numB = 3003;

            // Act
            var gcd = numericalAlgorithms.FindGreatestCommonDivisors(numA, numB);

            // Assert
            Assert.Equal(231, gcd);
        }

        [Fact]
        public void GetHammingDistance_ReturnException()
        {
            // Arrange
            var stringA = "abcdef";
            var stringB = "abc";

            // Act Assert
            Assert.Throws<ArgumentException>(() => numericalAlgorithms.GetHammingDistance(stringA, stringB));
        }

        [Fact]
        public void GetHammingDistance_ReturnEDistance()
        {
            // Arrange
            var stringA = "abcdef";
            var stringB = "abceee";

            // Act
            var distance = numericalAlgorithms.GetHammingDistance(stringA, stringB);

            // Assert
            Assert.Equal(2, distance);
        }
    }
}

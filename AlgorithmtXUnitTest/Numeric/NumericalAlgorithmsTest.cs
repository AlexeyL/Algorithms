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
        public void RaiseToPower_Return_RaisedNumber()
        {
            // Arrange
            var num = 2;
            var power = 6;

            // Act
            var result = numericalAlgorithms.RaiseToPower(num, power);

            // Arrange
            Assert.Equal(128, result);
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

        [Fact]
        public void GetFibonacciNum_Returns_Num()
        {
            // Arrange
            var num = 50;
            var memo = new Dictionary<int, long>();

            // Act
            var result = numericalAlgorithms.GetFibonacciNum(num, memo);

            // Assert
            Assert.Equal(12586269025, result);
        }

        [Fact]
        public void GetTraveler_Returns_NumberOfPossibleWays()
        {
            // Arrange
            var m = 3;
            var n = 3;
            var memo = new Dictionary<string, long>();

            // Act
            var result = numericalAlgorithms.GetTraveler(m, n, memo);

            // Assert
            Assert.Equal(6, result);
        }

        [Fact]
        public void GetSum_Returns_Boolean()
        {
            // Arrange
            var targetSum = 300;
            var numbers = new int[] { 5, 4, 7 };
            var memo = new Dictionary<int, bool>();

            // Act
            var result = numericalAlgorithms.GetSum(targetSum, numbers, memo);

            // Assert
            Assert.True(result);
        }
    }
}

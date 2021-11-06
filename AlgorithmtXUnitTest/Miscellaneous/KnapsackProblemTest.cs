using Algorithms.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.Miscellaneous
{
    public class KnapsackProblemTest
    {
        private List<KnapsackItem> items;

        public KnapsackProblemTest()
        {
            items = new List<KnapsackItem>()
            {
                new KnapsackItem("Guitar", 1500, 1),
                new KnapsackItem("Stereo", 3000, 4),
                new KnapsackItem("Laptop", 2000, 3)
            };
        }

        [Fact]
        public void KnapsackPropblem_FillKnapsack_Returns_Max_Value()
        {
            // Arrange
            var knapsackProblem = new KnapsackProblem();

            // Act
            var result = knapsackProblem.FillKnapsack(items, 4);

            // Assert
            Assert.Equal(3500, result);
        }

        [Fact]
        public void KnapsackPropblem_FillKnapsack_Returns_Max_Value_2()
        {
            // Arrange
            var knapsackProblem = new KnapsackProblem();
            items.Add(new KnapsackItem("IPhone", 2000, 1));

            // Act
            var result = knapsackProblem.FillKnapsack(items, 4);

            // Assert
            Assert.Equal(4000, result);
        }
    }
}

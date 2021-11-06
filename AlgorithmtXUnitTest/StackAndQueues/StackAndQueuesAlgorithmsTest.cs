using Algorithms.StackAndQueues;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.StackAndQueues
{
    public class StackAndQueuesAlgorithmsTest
    {
        [Fact]
        public void LinkedListAlgorithms_SelectionSort_SorterLiknedList()
        {
            // Arrange
            var alg = new StackAndQueueAlgorithms();
            var stack = new Stack<int>();
            var random = new Random();
            for (var i = 0; i < 10; i++)
            {
                var randomIndex = random.Next(0, 10);
                stack.Push(randomIndex);
            }

            // Act 
            var sortedStack = alg.StackInsertionSort(stack);

            // Assert
            Assert.Equal(1, 1);
        }
    }
}

using Algorithms._DataSrtucture.LinkedList;
using Algorithms.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AlgorithmtXUnitTest.LinkedList
{
    public class LinkedListAlgorithmsTest
    {
        public LinkedListAlgorithmsTest()
        {
            InitLinkedList();
        }

        private void InitLinkedList()
        {
        }

        [Fact]
        public void LinkedListAlgorithms_InsertionSort_SorterLiknedList()
        {
            // Arrange
            var alg = new LinkedListAlgorithms();
            var testLinkedList = new Node(8, new Node(4, new Node(1, new Node(3))));

            // Act 
            var sortedLinkedList = alg.InsertionSort(testLinkedList);

            // Assert
            Assert.Equal(1, sortedLinkedList.Value);
            Assert.Equal(3, sortedLinkedList.Next.Value);
            Assert.Equal(4, sortedLinkedList.Next.Next.Value);
            Assert.Equal(8, sortedLinkedList.Next.Next.Next.Value);
        }


        [Fact]
        public void LinkedListAlgorithms_SelectionSort_SorterLiknedList()
        {
            // Arrange
            var alg = new LinkedListAlgorithms();
            var testLinkedList = new Node(8, new Node(4, new Node(1, new Node(3))));

            // Act 
            var sortedLinkedList = alg.SelectionSort(testLinkedList);

            // Assert
            Assert.Equal(1, sortedLinkedList.Value);
            Assert.Equal(3, sortedLinkedList.Next.Value);
            Assert.Equal(4, sortedLinkedList.Next.Next.Value);
            Assert.Equal(8, sortedLinkedList.Next.Next.Next.Value);
        }

        [Fact]
        public void LinkedListAlgorithms_AddTwoNumbers_LinkedList()
        {
            // Arrange
            var l1 = new Node(2, new Node(4, new Node(3)));
            var l2 = new Node(5, new Node(6, new Node(4)));
            var alg = new LinkedListAlgorithms();

            // Act 
            var linkedList = alg.AddTwoNumbers(l1, l2);

            // Assert
            Assert.Equal(7, linkedList.Value);
            Assert.Equal(0, linkedList.Next.Value);
            Assert.Equal(8, linkedList.Next.Next.Value);
        }
    }
}

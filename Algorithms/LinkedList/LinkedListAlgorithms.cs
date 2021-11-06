using Algorithms._DataSrtucture.LinkedList;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.LinkedList
{
    public class LinkedListAlgorithms
    {
        /// <summary>
        /// sort linked list of int using isertion algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns>sorted linked list</returns>
        public Node InsertionSort(Node input)
        {
            // set limiter
            var sential = new Node();

            while (input != null)
            {
                var nextCell = input;

                input = input.Next;

                var afterMe = sential;

                while (afterMe.Next != null &&
                afterMe.Next.Value != null &&
                afterMe.Next.Value < nextCell.Value)
                {
                    afterMe = afterMe.Next;
                }

                // insert element
                nextCell.Next = afterMe.Next;
                afterMe.Next = nextCell;
            }

            // return sorted list without first emty node
            return sential.Next;
        }

        /// <summary>
        /// sort linked list using selection algorithm
        /// </summary>
        /// <param name="inputList"></param>
        /// <returns>sorted linked list</returns>
        public Node SelectionSort(Node inputList)
        {
            // add beginning empty node to the input linked list
            var input = new Node();
            input.Next = inputList;

            var sential = new Node();

            while (input.Next != null)
            {
                var bestAfterMe = input;
                var bestValue = bestAfterMe.Next.Value;

                var afterMe = input.Next;
                while (afterMe.Next != null)
                {
                    if (afterMe.Next.Value > bestValue)
                    {
                        bestAfterMe = afterMe;
                        bestValue = afterMe.Next.Value;
                    }

                    afterMe = afterMe.Next;
                }

                var bestCell = bestAfterMe.Next;
                bestAfterMe.Next = bestCell.Next;

                bestCell.Next = sential.Next;
                sential.Next = bestCell;
            }

            // return sorted list without first emty node
            return sential.Next;
        }

        /// <summary>
        /// method accepts two linked listst and returns third one each item of which represents sum of l1 and l2
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public Node AddTwoNumbers(Node l1, Node l2)
        {
            var result = new Node();
            var currCell = result;
            int rest = 0;

            while (l1 != null || l2 != null)
            {
                var l1Value = l1 != null ? l1.Value : 0;
                var l2Value = l2 != null ? l2.Value : 0;

                l1 = l1.Next;
                l2 = l2.Next;

                var summ = rest + l1Value.Value + l2Value.Value;
                rest = summ / 10;

                currCell.Next = new Node(summ % 10);
                currCell = currCell.Next;
            }

            return result.Next;
        }
    }
}

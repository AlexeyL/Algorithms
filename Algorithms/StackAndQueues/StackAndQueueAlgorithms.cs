using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.StackAndQueues
{
    public class StackAndQueueAlgorithms
    {
        /// <summary>
        /// sort stack of int using isertion algorithm
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public Stack<int> StackInsertionSort(Stack<int> items)
        {
            Stack<int> tempStack = new Stack<int>();
            Stack<int> sortedStack = new Stack<int>();
            
            var numOfItems = items.Count;

            sortedStack.Push(items.Pop());

            for (int i = 0; i < numOfItems - 1; i++)
            {
                // get next item
                var nextItem = items.Pop();

                // move all unsorted items to the tempStack
                // at this point we have numOfItems - i - 1 unsorted items
                for (int j = 0; j < numOfItems - i - 1; j++)
                {
                    tempStack.Push(items.Pop());
                }

                // move sorted items to tempSortedStack
                // insert new item in correct position
                Stack<int> tempSortedStack = new Stack<int>();
                for (int x = 0; x < sortedStack.Count; x ++)
                {
                    var item = sortedStack.Pop();
                    if (item > nextItem)
                    {
                        tempSortedStack.Push(nextItem);
                    }
                    else
                    {
                        tempSortedStack.Push(item);
                    }
                }

                sortedStack = tempSortedStack;

                items = tempStack;
            }

            return sortedStack;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Trees
{
    /// <summary>
    /// Heap is a binaty tree where each node contains value
    /// that is greather then value in any of its children
    /// </summary>
    public class HeapAlgorithms
    {
        /// <summary>
        /// method creates a heap of array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] MakeHeap(int[] array)
        {
            // add each element to the heap, one by one
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;

                while (index != 0)
                {
                    // find index of parent node
                    int parent = (index - 1) / 2;

                    // if child node value is less then parent value
                    // we are done
                    if (array[index] <= array[parent])
                    {
                        break;
                    }

                    // otherwise
                    // switch parent and child values
                    int temp = array[index];
                    array[index] = array[parent];
                    array[parent] = temp;

                    // set index to parent node
                    index = parent;
                }
            }

            return array;
        }

        /// <summary>
        /// method remove top heap item and rebulds the heap
        /// </summary>
        /// <param name="array"></param>
        /// <param name="count"></param>
        /// <returns>Removed item</returns>
        public int RemoveTopItem(ref int[] array, int count)
        {
            // save top heap element so we can return it
            int result = array[0];

            // move last elemet to the top
            array[0] = array[count - 1];

            // rebuild the heap
            int index = 0;

            while (true)
            {
                // find indexed of children elements
                int child1 = index * 2 + 1;
                int child2 = index * 2 + 2;

                // if index of child element is out of range
                // use parent index
                if (child1 > count) child1 = count;
                if (child2 > count) child2 = count;

                // if heap is build then return from while
                if (array[index] >= array[child1] && array[index] >= array[child2])
                    break;

                // get index of child that has bigger value
                int swapChild;
                if (array[child1] > array[child2])
                {
                    swapChild = child1;
                }
                else
                {
                    swapChild = child2;
                }

                // swap items
                int temp = array[index];
                array[index] = array[swapChild];
                array[swapChild] = temp;

                // go to the child level
                index = swapChild;
            }

            array[count - 1] = result;

            // return top item
            return result;
        }
    }
}

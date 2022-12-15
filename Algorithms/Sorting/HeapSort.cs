using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class HeapSort
    {
        /// <summary>
        /// method sort an array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sorted array</returns>
        public int[] SortRecurcive(int[] array)
        {
            int n = array.Length;

            // build a heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(array, n, i);
            }

            // one by one extract an element from heap
            for (int i = n - 1; i > 0; i --)
            {
                // move current element from heap
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;

                // call max heapify on the reduced heap
                Heapify(array, i, 0);
            }

            return array;
        }

        /// <summary>
        /// heapify a subtree rooted with node i which is an index in array[]
        /// </summary>
        /// <param name="array">array</param>
        /// <param name="n">size of a heap</param>
        /// <param name="i">root node index</param>
        private void Heapify(int[] array, int n, int i)
        {
            // initialize largest as root
            int largest = i;
            
            // left child
            int left = 2 * i + 1;

            // right child
            int right = 2 * i + 2;

            // if left child is larger than root
            if (left < n && array[left] > array[largest])
            {
                largest = left;
            }

            // if right child is larger than largest so far
            if (right < n && array[right] > array[largest])
            {
                largest = right;
            }

            // if largest is not root than switch them
            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;

                // recursively heapify the affected sub-tree
                Heapify(array, n, largest);
            }
        }


        /// <summary>
        /// method sort an array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sorted array</returns>
        public int[] SortIterative(int[] array)
        {
            int n = array.Length;

            MakeHeap(ref array);

            // one by one extract an element from heap
            for (int i = n - 1; i > 0; i--)
            {
                RemoveTopItem(ref array, i);
            }

            return array;
        }


        private int[] MakeHeap(ref int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;

                while (index != 0)
                {
                    int parent = (index - 1) / 2;

                    if (array[index] <= array[parent])
                        break;

                    int temp = array[index];
                    array[index] = array[parent];
                    array[parent] = temp;

                    index = parent;
                }
            }

            return array;
        }

        public void RemoveTopItem(ref int[] array, int count)
        {
            // save top heap element so we can return it
            int result = array[0];

            // move last elemet to the top
            array[0] = array[count];

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

            array[count] = result;

        }

    }
}

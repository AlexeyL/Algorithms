using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Sorting
{
    public class QuickSort
    {
        /// <summary>
        /// method sorts an array of int
        /// </summary>
        /// <param name="array">array of int</param>
        /// <param name="low">low index</param>
        /// <param name="high">high index</param>
        public void Sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                var partitionIndex = Partition(array, low, high);

                //3. Recursively continue sorting the array
                Sort(array, low, partitionIndex - 1);
                Sort(array, partitionIndex + 1, high);
            }
        }

        /// <summary>
        /// sort partition
        /// </summary>
        /// <param name="arr">array</param>
        /// <param name="low">low index</param>
        /// <param name="high">high index</param>
        /// <returns></returns>
        private int Partition(int[] arr, int low, int high)
        {
            //1. Select a pivot point.
            var pivot = arr[high];
            var lowIndex = low - 1;

            //2. Reorder the collection.
            for (var j = low; j < high; j ++)
            {
                if(arr[j] <= pivot)
                {
                    lowIndex++;

                    var temp = arr[lowIndex];
                    arr[lowIndex] = arr[j];
                    arr[j] = temp;
                }
            }

            var temp1 = arr[lowIndex + 1];
            arr[lowIndex + 1] = arr[high];
            arr[high] = temp1;

            return lowIndex + 1;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        /// <summary>
        /// Method sort an array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sorted array</returns>
        public int[] Sort(int[] items)
        {
            int temp, smallest;

            //The algorithm builds the sorted list from the left.
            //1. For each item in the array...
            for (var i = 0; i < items.Length - 1; i++)
            {
                //2. ...assume the first item is the smallest value
                smallest = i;
                
                //3. Cycle through the rest of the array
                for (int j = i + 1; j < items.Length; j++)
                {
                    //4. If any of the remaining values are smaller, 
                    //   find the smallest of these
                    if (items[j] < items[smallest])
                    {
                        smallest = j;
                    }
                }

                //5. Swap the found-smallest value with the current value
                temp = items[smallest];
                items[smallest] = items[i];
                items[i] = temp;
            }

            return items;
        }
    }
}

using System;

namespace Algorithms.Sorting
{
    public class BubbleSort
    {
        /// <summary>
        /// Method sort an array of int
        /// </summary>
        /// <param name="array"></param>
        /// <returns>sorted array</returns>
        public int[] Sort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array;
        }
    }
}
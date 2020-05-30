using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Searching
{
    public class BinarySearch
    {
        /// <summary>
        /// Binary search (iterative)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool SearchIterative(int[] array, int x)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = left + ((right - left) / 2);

                if (array[mid] == x)
                    return true;
                else if (x < array[mid])
                    right = mid - 1;
                else
                    left = mid + 1;
            }

            return false;
        }

        /// <summary>
        /// Binary search (recursive)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool SearchRecursive(int[] array, int x)
        {
            return SearchRecursive(array, 0, array.Length - 1, x);
        }

        /// <summary>
        /// Binary search (recursive)
        /// </summary>
        /// <param name="array"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        private bool SearchRecursive(int[] array, int left, int right, int x)
        {
            if (left > right)
                return false;

            int mid = left + ((right - left) / 2);

            if (array[mid] == x)
                return true;
            else if (x < array[mid])
                return SearchRecursive(array, left, mid - 1, x);
            else
                return SearchRecursive(array, mid + 1, right, x);
        }
    }
}

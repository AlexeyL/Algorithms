using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Searching
{
    // log(log(n))
    public class InterpolationSearch
    {
        /// <summary>
        /// intrpolation search (iterative)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns>index</returns>
        public int SearchIterative(int[] arr, int target)
        {
            int hi = arr.Length - 1;
            int lo = 0;
            int pos;

            while (lo < hi && target >= arr[lo] && target <= arr[hi])
            {
                pos = lo + ((hi - lo) / (arr[hi] - arr[lo])) * (target - arr[lo]);

                if (arr[pos] == target)
                    return pos;

                if (arr[pos] < target)
                    lo = pos + 1;

                if (arr[pos] > target)
                    hi = pos - 1;
            }

            return -1;
        }

        /// <summary>
        /// interpolation search (recursive)
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="target"></param>
        /// <returns>index</returns>
        public int SearchRecursive(int[] arr, int target)
        {
            // count of items in array
            int n = arr.Length - 1;

            int index = Search(arr, 0, n, target);

            return index;
        }

        private int Search(int[] arr, int lo, int hi, int target)
        {
            int pos;

            // since array is sorted, an element present in array
            // must be in range defined by corner
            if (lo <= hi && target >= arr[lo] && target <= arr[hi])
            {
                // probing the position with keeping uniform distribution in mind
                pos = lo + ((hi - lo) / (arr[hi] - arr[lo])) * (target - arr[lo]);

                // condition of target found
                if (arr[pos] == target)
                    return pos;

                if (arr[pos] < target)
                    return Search(arr, pos + 1, hi, target);

                if (arr[pos] > target)
                    return Search(arr, lo, pos - 1, target);
            }

            return - 1;
        }
    }
}

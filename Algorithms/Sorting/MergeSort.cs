using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sorting
{
    public class MergeSort
    {
        /// <summary>
        /// method sorts a list of int
        /// </summary>
        /// <param name="unsorted"></param>
        /// <returns></returns>
        public List<int> Sort(List<int> unsorted)
        {
            // Use recursion to break the collection
            // into progressively smaller collections.
            // Eventually, each collection will have just one element.

            if (unsorted.Count <= 1)
                return unsorted;

            List<int> left = new List<int>();
            List<int> right = new List<int>();

            int median = unsorted.Count / 2;

            for (int i = 0; i < median; i++)
            {
                left.Add(unsorted[i]);
            }

            for (int i = median; i < unsorted.Count; i++)
            {
                right.Add(unsorted[i]);
            }

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        /// <summary>
        /// Method takes two sorted sublists (left and right)
        /// of original list nad merges them into a new collection
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        private List<int> Merge(List<int> left, List<int> right)
        {
            // The new collection
            List<int> result = new List<int>();

            while (left.Any() || right.Any())
            {
                if (left.Any() && right.Any())
                {
                    // Comparing the first element of each sublist
                    // to see which is smaller
                    if (left.First() <= right.First())
                    {
                        result.Add(left.First());
                        left.Remove(left.First());
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Any())
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Any())
                {
                    result.Add(right.First());
                    right.Remove(right.First());
                }
            }

            return result;
        }
    }
}

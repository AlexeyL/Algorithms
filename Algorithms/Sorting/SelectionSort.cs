using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Sorting
{
    public class SelectionSort
    {
        public List<int> Sort(List<int> list)
        {
            var newList = new List<int>();
            var listCount = list.Count - 1;

            for (var i = listCount; i >= 0; i --)
            {
                var smallest = FindSmallest(list);
                newList.Add(list[smallest]);
                list.RemoveAt(smallest);
            }

            return newList;
        }

        private int FindSmallest(List<int> list)
        {
            var smallest = list[0];
            var smallestIndex = 0;

            for (var i = 0;  i < list.Count; i ++)
            {
                if (list[i] < smallest)
                {
                    smallest = list[i];
                    smallestIndex = i;
                }
            }

            return smallestIndex;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Miscellaneous
{
    public class KnapsackProblem
    {
        /// <summary>
        /// method finds items that have to be put in a knapsack
        /// to fill knapsack with most valueale items
        /// </summary>
        /// <param name="items"></param>
        /// <param name="knapsackSize"></param>
        public int FillKnapsack(List<KnapsackItem> items, int knapsackSize)
        {
            // create a matrix where rows are items to choose from
            // and columns are knapsack size
            int[,] knapsack = new int[items.Count, knapsackSize];

            // fill matrix
            for (var i = 0; i < items.Count; i ++)
            {
                for (var j = 0; j < knapsackSize; j ++)
                {
                    if (i == 0)
                    {
                        if (items[i].Weight <= j + 1) // j + 1 because j starts from 0 and smallest weight is 1
                        {
                            knapsack[i, j] = items[i].Value;
                        }
                    }
                    else
                    {
                        var previousMaxValue = knapsack[i - 1, j];
                        var currentItemValue = items[i].Weight <= j + 1 ? items[i].Value : 0; // j + 1 because j starts from 0 and smallest weight is 1

                        var remaingnSpace = j - items[i].Weight;
                        var valueOfRemaininSpace = remaingnSpace > -1 ? knapsack[i - 1, j - items[i].Weight] : 0;

                        knapsack[i, j] = Math.Max(previousMaxValue, currentItemValue + valueOfRemaininSpace);
                    }
                }
            }

            return knapsack[items.Count - 1, knapsackSize - 1];
        }
    }

    public class KnapsackItem
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public int Weight { get; set; }

        public KnapsackItem(string name, int value, int weight)
        {
            Name = name;
            Value = value;
            Weight = weight;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Numerical
{
    public class NumericalAlgorithms
    {
        /// <summary>
        /// Method randomizes an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns>randomized array</returns>
        public List<int> RandomizeAnArray(List<int> array)
        {
            var result = array.ToList();
            for (var i = 0; i < result.Count; i++)
            {
                var random = new Random();
                var randomIndex = random.Next(0, array.Count);

                var item = result[randomIndex];
                result[randomIndex] = array[i];
                result[i] = item;
            }

            return result;
        }

        /// <summary>
        /// Method finds greatest common divisor
        /// </summary>
        /// <param name="numA"></param>
        /// <param name="numB"></param>
        /// <returns>greatest common divisor</returns>
        public int FindGreatestCommonDivisors(int numA, int numB)
        {
            while (numB != 0)
            {
                int remainder = numA % numB;
                numA = numB;
                numB = remainder;
            }

            return numA;
        }

        /// <summary>
        /// Hamming distance is a metric for comparing two strings
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <returns>Number of different symbols</returns>
        public int GetHammingDistance(string s, string t)
        {
            if (s.Length != t.Length)
            {
                throw new ArgumentException("Strings must be equal length");
            }

            int distance =
                s.ToCharArray()
                .Zip(t.ToCharArray(), (c1, c2) => new { c1, c2 })
                .Count(m => m.c1 != m.c2);

            return distance;
        }
    }
}

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
        /// Method rise number to power
        /// </summary>
        /// <param name="num"></param>
        /// <param name="power"></param>
        /// <returns></returns>
        public double RaiseToPower(double num, int power)
        {
            if (power < 0)
            {
                throw new ArgumentOutOfRangeException("Power can't be negative");
            }

            if (power < 1)
            {
                return 0;
            }

            if (power == 1)
            {
                return num;
            }

            var dic = new Dictionary<int, double>();
            dic.Add(2, num * num);

            for (int i = 4; i <= power; i *= 2)
            {
                dic.Add(i, dic[i / 2] * num);
            }

            if (dic.Last().Key == power)
            {
                return dic.Last().Value;
            }

            if (power % 2 == 0)
            {
                var lastKey = dic.Keys.Reverse().First();
                var secondToLastKey = dic.Keys.Reverse().Skip(1).First();

                return dic[secondToLastKey] + dic[lastKey];
            }
            else
            {
                var index = dic.Keys.Last();
                var res = dic[index];
                
                while (index != power)
                {
                    res = res * num;
                    index++;
                }

                return res;
            }
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

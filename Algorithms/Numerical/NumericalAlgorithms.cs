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
        public int RaiseToPower(int num, int power)
        {
            if (power == 0 || power < 0) return num;

            for (var i = 0; i < power; i ++)
            {
                num = num * 2;
            }

            return num;
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

        /// <summary>
        /// method return fibonacci number
        /// </summary>
        /// <param name="num">number</param>
        /// <param name="memo">memo hash table</param>
        /// <returns></returns>
        public long GetFibonacciNum(int num, Dictionary<int, long> memo)
        {
            if (memo.ContainsKey(num))
                return memo[num];

            if (num == 0 || num == 1) return num;

            memo.Add(num, (GetFibonacciNum(num - 1, memo) + GetFibonacciNum(num - 2, memo)));

            return memo[num];
        }

        /// <summary>
        /// count number of possible way to travel from start to end
        /// in square with dimenssion m per n
        /// </summary>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public long GetTraveler(int m, int n, Dictionary<string, long> memo)
        {
            var key = $"{m},{n}";

            if (memo.ContainsKey(key))
                return memo[key];

            if (m == 1 && n == 1) return 1;
            if (m == 0 || n == 0) return 0;

            memo.Add(key, (GetTraveler(m - 1, n, memo) + GetTraveler(m, n - 1, memo)));

            return memo[key];
        }

        /// <summary>
        /// the fuction should return a boolean indicating whether or not it 
        /// is possible to generate the targetSum unsing numbers from the array
        /// same number can be used miltiple times
        /// </summary>
        /// <param name="targetSum"></param>
        /// <param name="numbeers"></param>
        /// <param name="memo"></param>
        /// <returns></returns>
        public bool GetSum(int targetSum, int[] numbers, Dictionary<int, bool> memo)
        {
            if (memo.ContainsKey(targetSum)) return memo[targetSum];
            if (targetSum == 0) return true;
            if (targetSum < 0) return false;

            for (var i = 0; numbers.Length > 0; i ++)
            {
                var reminder = targetSum - numbers[i];
                if (GetSum(reminder, numbers, memo))
                {
                    memo.Add(targetSum, true);
                    return true;
                }
            }

            memo.Add(targetSum, false);
            return false;
        }

    }
}

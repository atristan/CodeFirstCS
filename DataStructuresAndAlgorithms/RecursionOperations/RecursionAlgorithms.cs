using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms.RecursionOperations
{
    public static class RecursionAlgorithms
    {
        public static int GetFactorialWithForLoop(int input)
        {
            int result = input;

            for (int i = input; i >= 1; i--)
                result = result * i;

            return result;
        }

        public static double GetFactorialWithWhileLoop(int input)
        {
            double result = 1;

            while (input != 1)
            {
                result = result * input;
                input = input - 1;
            }

            return result;
        }

        public static double GetFactorialWithRecursion(int input)
        {
            if (input == 1)
                return 1;

            return input * GetFactorialWithRecursion(input - 1);
        }

        /// <summary>
        /// https://www.csharpstar.com/csharp-program-to-find-sum-of-digits-of-a-number-using-recursion/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int GetSumUsingRecursionFor(int input)
        {
            int result = -1;

            if (input != 0)
                return (input % 10 + GetSumUsingRecursionFor(input / 10));
            
            return result;
        }

        /// <summary>
        /// https://www.csharpstar.com/csharp-program-print-binary-value/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static int BinaryConverterFor(int input)
        {
            int result = -1;

            if (input != 0)
                result = (input % 2) + 10 * BinaryConverterFor(input / 2);

            return result;
        }

        /// <summary>
        /// https://www.csharpstar.com/calculate-power-using-recursion-csharp/
        /// </summary>
        /// <remarks>
        /// This can be written recursively as :
        ///     x(n/2) * x(n/2) , if n is even
        ///         (or)
        ///     x* x(n/2) * x(n/2), if n is odd
        /// 
        /// () indicate raised to that power.
        /// </remarks>
        /// <param name="input"></param>
        public static double CalculatePowerWithRecursionFor(int exponent, double baseValue)
        {
            if (exponent < 0)
                return -1.0;

            if (exponent == 1)
                return baseValue;

            if (exponent == 0)
                return 1;

            return baseValue * CalculatePowerWithRecursionFor(exponent - 1, baseValue);
        }

        /// <summary>
        /// https://www.csharpstar.com/fibonacci-series-in-csharp/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static List<int> GetFibonacciSeriesIteratively(int input)
        {
            int firstNo = 0, secondNo = 1, result = 0;
            List<int> results = new List<int>();

            if (input == 0)
                return new List<int>{0};

            if (input == 1)
                return new List<int>{1};

            for (int i = 2; i <= input; i++)
            {
                result = firstNo + secondNo;
                firstNo = secondNo;
                secondNo = result;
                results.Add(result);
            }

            return results;
        }

        /// <summary>
        /// https://www.csharpstar.com/binary-search-csharp/
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static object BinarySearchUsingRecursion(int[] input, int key, int min, int max)
        {
            if (min > max)
                return "Nil";

            int mid = (min + max) / 2;

            if (key == input[mid])
                return ++mid;

            if (key < input[mid])
                return BinarySearchUsingRecursion(input, key, min, mid - 1);

            return BinarySearchUsingRecursion(input, key, mid + 1, max);
        }

        /// <summary>
        /// https://www.csharpstar.com/binary-search-csharp/
        /// </summary>
        /// <param name="input"></param>
        /// <param name="key"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static object BinarySearchWithoutRecursion(int[] input, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (key == input[mid])
                    return ++mid;

                if (key < input[mid])
                    max = mid - 1;
                else
                    min = mid + 1;
            }

            return "Nil";
        }

        /// <summary>
        /// https://www.csharpstar.com/csharp-program-quick-sort/
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <param name="input"></param>
        public static void QuickSort(int left, int right, int[] input)
        {
            //int   pivot = input[left]
            //    , leftend = left
            //    , rightend = right;

            //while (left < right)
            //{
            //    while ((input[right] >= input[left]))
            //        right--;

            //    if (left != right)
            //    {
            //        input[left] = input[right];
            //        left++;
            //    }

            //    while ((input[left] >= pivot) && (left < right))
            //        left++;

            //    if (left != right)
            //    {
            //        input[right] = input[left];
            //        right--;
            //    }
            //}

            //if (left < pivot)
            //    QuickSort(left, pivot - 1);
        }

        /// <summary>
        /// https://www.csharpstar.com/towers-of-hanoi-in-csharp/
        /// </summary>
        /// <param name="totalDisks"></param>
        /// <param name="startPeg"></param>
        /// <param name="endPeg"></param>
        /// <param name="tempPeg"></param>
        public static void TowersOfHanoiRecursion(int totalDisks, char startPeg, char endPeg, char tempPeg)
        {
            if (totalDisks > 0)
            {
                TowersOfHanoiRecursion(totalDisks - 1, startPeg, tempPeg, endPeg);
                Console.WriteLine($"Move disk from {startPeg} to {endPeg}");
                TowersOfHanoiRecursion(totalDisks - 1, tempPeg, endPeg, startPeg);
            }
        }
    }
}

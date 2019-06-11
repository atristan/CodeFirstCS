using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public static class NumberAlgorithms
    {
        public static void SwapTwoNumsWithoutTempVar(int first, int second)
        {
            first = first + second;
            second = first - second;
            first = first - second;
        }

        public static void SwapTwoNumsWithXor(int first, int second)
        {
            first = second ^ first;
            second = second ^ first;
            first = first ^ second;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// A child is running up a staircase with n steps and can hop either 1, 2, or 3 steps at a time.
        /// Implement a method to count how many possible ways the child can run up the stairs.
        /// Answer will overflow integer datatype (over 4 billion) at 37 steps.
        /// </remarks>
        /// <param name="numberOfStairs"></param>
        /// <returns></returns>
        public static int ClimbingStairsComboRecursive(int numberOfStairs)
        {
            if(numberOfStairs > 36)
                throw new Exception("Int overflow");

            if (numberOfStairs <= 0)
                return 0;

            if (numberOfStairs == 1)
                return 1;

            if (numberOfStairs == 2)
                return 2;

            if (numberOfStairs == 3)
                return 4;

            return ClimbingStairsComboRecursive(numberOfStairs - 1) 
                 + ClimbingStairsComboRecursive(numberOfStairs - 2) 
                 + ClimbingStairsComboRecursive(numberOfStairs - 3);
        }

        public static int ClimbingStairsCombosIterative(int numberOfStairs)
        {
            if (numberOfStairs > 36)
                throw new Exception("Int overflow");

            if (numberOfStairs <= 0)
                return 0;

            if (numberOfStairs == 1)
                return 1;

            if (numberOfStairs == 2)
                return 2;

            if (numberOfStairs == 3)
                return 4;

            int[] prev = {1, 2, 4};

            int current = 3;

            while (current < numberOfStairs)
            {
                int preTotal = prev[0] + prev[1] + prev[2];
                prev[0] = prev[1];
                prev[1] = prev[2];
                prev[2] = preTotal;
                current++;
            }
            return prev[2];
        }

        public static int GetFactorialUsingForLoop(int input)
        {
            int result = input;
            for (int i = input - 1; i >= 1; i--)
                result = result * i;

            return result;
        }

        public static int GetFactorialUsingWhileLoop(int input)
        {
            int result = input;

            while (input != 1)
            {
                result = result * input;
                input = input - 1;
            }

            return result;
        }

        public static int GetFactorialUsingRecursion(int input)
        {
            if (input == 1)
                return 1;

            return input * GetFactorialUsingRecursion(input - 1);
        }

        /// <summary>
        /// Gets the next Fibonacci number specified by the input.
        /// </summary>
        /// <remarks>
        /// Formula for calculating the Fibonacci series:
        ///     F(n) = F(n - 1) + F(n - 2)
        ///         F(n) is the term number.
        ///         F(n - 1) is the previous term (n -1).
        ///         F(n - 2) is the term before the (n - 2).
        /// Starts with 0 or 1.
        /// Wrap this item in a loop with a specified length.  Operates one number at a time.
        /// </remarks>
        /// <returns>The next integer in the Fibonacci series specified by the input.</returns>
        public static int FibonacciSeriesIterativeApproach(int input)
        {
            int firstNum = 0, secondNum = 1, result = -1;

            if (input == 0)
                return 0;

            if (input == 1)
                return 1;

            for (int i = 2; i <= input; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
            }

            return result;
        }

        public static int FibonacciSeriesRecursiveApproach(int input)
        {
            if (input == 0)
                return 0;

            if (input == 1)
                return 1;

            return FibonacciSeriesRecursiveApproach(input - 1) + FibonacciSeriesRecursiveApproach(input - 2);
        }

        public static int GetRemainder(int numerator, int denominator)
        {
            if(denominator == 0)
                throw new Exception("Can not divide by zero.");

            if(numerator < denominator)
                throw new Exception("Number being divided (dividend) can not be less than the divisor.");

            return (numerator % denominator);
        }

        /// <summary>
        /// Checks whether the entered number is an Armstrong number or not.
        /// </summary>
        /// <remarks>
        /// An Armstrong number of 3 digits is an integer such that the sum of the cubes of its digits is equal to the number itself.
        /// </remarks>
        /// <returns></returns>
        public static bool IsArmstrongNumber(int input)
        {
            int remainder;
            double sum = 0.0;

            for (int i = input; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + Math.Pow(double.Parse(input.ToString()), 3.0);
            }

            if (sum == double.Parse(input.ToString()))
                return true;

            return false;
        }

        public static int GetGreatestCommonDenominator(int left, int right)
        {
            int result = -1;

            while (left != right)
            {
                if (left > right)
                    result = left - right;

                if (right > left)
                    result = right - left;
            }
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// LMC(a,b) = (a*b) / GCD(a,b)
        /// </remarks>
        /// <returns></returns>
        public static int GetLeastCommonMultiple(int left, int right)
        {
            return (left * right) / GetGreatestCommonDenominator(left, right);
        }

        public static bool IsNumberPrime(int input)
        {
            int counter = 0;
            for (int i = 1; i <= input / 2; i++)
            {
                if (input % i == 0)
                    counter++;
            }

            if (counter == 2)
                return true;

            return false;
        }

        /// <summary>
        /// https://www.csharpstar.com/csharp-program-to-reverse-a-number-check-if-it-is-a-palindrome/
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool IsNumberPalindrome(int input)
        {
            int temp = input, remainder, reverse = 0;

            while (temp > 0)
            {
                remainder = temp % 10;
                reverse = (reverse * 10) + remainder;
                temp /= 10;
            }

            if (temp == reverse)
                return true;

            return false;
        }

        public static string GetFizzBuzz()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i < 101; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    sb.Append($"FizzBuzz{Environment.NewLine}");
                else if (i % 3 == 0)
                    sb.Append($"Fizz{Environment.NewLine}");
                else if (i % 5 == 0)
                    sb.Append($"Buzz{Environment.NewLine}");
                else
                    sb.Append($"{i.ToString()}{Environment.NewLine}");
            }

            return sb.ToString();
        }

        public static bool IsNumberDivisibleBy(int divisibleValue, int divisibleByValue)
        {
            if (divisibleValue % divisibleByValue == 0)
                return true;

            return false;
        }

        public static List<int> GenerateFactorsFor(int value)
        {
            List<int> results = new List<int>();
            for (int x = 1; x <= value; x++)
            {
                if(value % x == 0)
                    results.Add(x);
            }

            return results;
        }
    }
}

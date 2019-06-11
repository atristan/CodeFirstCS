#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;

#endregion

namespace DataStructuresAndAlgorithms
{
    public static class ArrayAlgorithms
    {
        /// <summary>
        /// Rotates an integer array based on a given pivot point.
        /// </summary>
        /// <param name="value">The integer array to pivot.</param>
        /// <param name="pivot">The pivot point to rotate array on.</param>
        /// <returns></returns>
        public static int[] Rotate(int[] value, int pivot)
        {
            if (pivot < 0 || value == null)
                return new int[0];

            // Get whole number value to pivot on.
            pivot = pivot % value.Length;

            // Pivot on the first half.
            value = RotateSub(value, 0, pivot - 1);

            // Pivot on the second half.
            value = RotateSub(value, pivot, value.Length - 1);

            // Pivot whole data structure.
            value = RotateSub(value, 0, value.Length - 1);

            return value;
        }

        private static int[] RotateSub(int[] value, int start, int end)
        {
            // Loop through array starting at the specified pivot point.
            while (start < end)
            {
                // Set temp to start value.
                int temp = value[start];

                // Begin rotation around pivot.
                value[start] = value[end];

                // Line up next value in rotation.
                value[end] = temp;

                // Increment start spot
                start++;

                // Decrement end spot.
                end--;
            }

            return value;
        }

        /// <summary>
        /// Determine if two integers in an array sum to a given target.
        /// </summary>
        /// <param name="value">The integer array to parse.</param>
        /// <param name="target">The target sum.</param>
        /// <returns>Returns <c>true</c> if two values in the integer array sum up to the specified target, otherwise <c>false</c>.</returns>
        public static bool TwoIntegersSumToTarget(int[] value, int target)
        {
            // Loop through array to get left hand value.
            for (int i = 0; i < value.Length; i++)
            {
                // Loop through array again to get right hand value.
                for (int j = 0; j < value.Length; j++)
                {
                    // Check if same value
                    if (i != j)
                    {
                        // Add left hand to right hand value.
                        int sum = value[i] + value[j];

                        // Check if sum equals target.
                        if (sum == target)
                            return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Sorts an array.
        /// </summary>
        /// <param name="value">The integer array to sort.</param>
        /// <param name="desc">Flag indicating whether to sort asc or desc.</param>
        public static void Sort(int[] value, bool desc = true)
        {
            // Sort array ascending first.
            Array.Sort(value);

            // If desc flag true, reverse sort to desc.
            if(desc)
                Array.Reverse(value);
        }

        /// <summary>
        /// Gets the majority element in an unsorted array.
        /// </summary>
        /// <param name="value">The array.</param>
        /// <returns></returns>
        public static int GetMajorityElement(params int[] value)
        {
            // Create lookup container.
            Dictionary<int, int> lookup = new Dictionary<int, int>();
            int majority = value.Length / 2;

            // Iterate through all elements of the array.
            foreach (int i in value)
            {
                // If lookup contains the current key...
                if (lookup.ContainsKey(i))
                {
                    // Add element to lookup.
                    lookup[i]++;

                    // Check if lookup element is greater than majority.
                    if (lookup[i] > majority)
                        return i;
                }
                else
                    lookup.Add(i, 1);
            }

            throw new Exception("No majority element in array.");
        }

        /// <summary>
        /// Merges two sorted arrays into one.
        /// </summary>
        /// <param name="left">The left side of the merge.</param>
        /// <param name="right">The right side of the merge.</param>
        /// <param name="lastValue">Position of the last stored element in the left side of the operation.</param>
        /// <returns>The merged array in sorted order.</returns>
        /// <remarks>
        /// You are given two sorted arrays, A and B, where A has a large enough buffer at the end to hold B.
        /// This method merges B into A in sorted order.
        /// </remarks>
        public static int[] MergeTwoSortedArrays(int[] left, int[] right, int lastValue)
        {
            int leftIdx = lastValue;
            int rightIdx = right.Length - 1;
            int mergeIdx = left.Length - 1;

            while (rightIdx >= 0)
            {
                if (right[rightIdx] > left[leftIdx])
                {
                    left[mergeIdx] = right[rightIdx];
                    rightIdx--;
                }
                else if (right[rightIdx] < left[leftIdx])
                {
                    left[mergeIdx] = left[leftIdx];
                    leftIdx--;
                }

                mergeIdx--;
            }

            return left;
        }

        /// <summary>
        /// Swaps the min and max element in an integer array. 
        /// </summary>
        /// <param name="value">The array to manipulate.</param>
        public static void MinMaxArraySwap(int[] value)
        {
            if(value.Length == 0)
                return;

            int maxPosition = 0;
            int minPosition = 0;
            int valMax = 0;
            int valMin = 0;

            for (int i = 1; i < value.Length; i++)
            {
                if (value[maxPosition] < value[i])
                    maxPosition = i;

                if (value[minPosition] > value[i])
                    minPosition = i;
            }

            valMax = value[maxPosition];
            valMin = value[minPosition];

            value[maxPosition] = valMin;
            value[minPosition] = valMax;
        }

        /// <summary>
        /// Swaps the min and max element in an integer array. 
        /// </summary>
        /// <param name="value">The array to manipulate.</param>
        public static void ElegantMinMaxArraySwap(int[] value)
        {
            int min = 0;
            int max = 0;

            for (int i = 1; i < value.Length; i++)
            {
                if (value[min] > value[i])
                    min = i;

                if (value[max] < value[i])
                    max = i;
            }

            int temp = value[min];
            value[min] = value[max];
            value[max] = temp;
        }

        /// <summary>
        /// Takes an integer array and moves all the 0's to the end of it while maintaining the relative order of the non-zero elements.
        /// Ex.:  [0,1,0,3,12] => [1,3,12,0,0]
        /// </summary>
        /// <remarks>
        /// * Do this in-place without making a copy of the array.
        /// * Minimize the total number of operations.
        /// </remarks>
        /// <param name="input">The integer array to manipulate.</param>
        public static void Move(params int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == 0)
                    MoveZeroToEnd(input, i);
            }
        }

        private static void MoveZeroToEnd(int[] x, int idx)
        {
            // Iterate through entire array.
            for (int i = idx; i < x.Length - 1; i++)
            {
                // Set temp variable to current element.
                int temp = x[i];

                // Set current element eq to next element.
                x[i] = x[i + 1];

                // Set next element to current element.
                x[i + 1] = temp;
            }
        }

        /// <summary>
        /// Determines if an integer array contains duplicates.
        /// </summary>
        /// <param name="input">The integer array to check.</param>
        /// <returns>Returns <c>true</c> when duplicates found, otherwise <c>false</c>.</returns>
        public static bool ContainsDuplicates(params int[] input)
        {
            Dictionary<int, int> lookup = new Dictionary<int, int>();

            foreach (int i in input)
            {
                if (lookup.ContainsKey(i))
                    return true;

                lookup.Add(i, 1);
            }

            return false;
        }
    }
}

#region Includes

// .NET Libraries
using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataStructuresAndAlgorithms.StringOperations
{
    /// <summary>
    /// Provides several string algorithms for manipulating and working with strings.
    /// </summary>
    public static class StringAlgorithms
    {
        /// <summary>
        /// Removes duplicate characters from a string.
        /// </summary>
        /// <param name="key">The string to parse.</param>
        /// <returns>A string value with duplicate characters stripped.</returns>
        public static string RemoveDuplicateChars(string key)
        {
            // Initialize placeholders
            string table = string.Empty;
            string result = string.Empty;

            // Loop over each character
            foreach (char value in key)
            {
                // See if character is in the table
                if (table.IndexOf(value) == 1)
                {
                    // Append to the table and the result
                    table += value;
                    result += value;
                }
            }

            return result;
        }

        /// <summary>
        /// Checks if two words are anagrams of each other.
        /// ex.:  silent is an anagram of listen
        /// </summary>
        /// <param name="left">The left string value to compare.</param>
        /// <param name="right">The right string value to compare.</param>
        /// <returns></returns>
        public static bool IsAnagram(string left, string right)
        {
            // Get characters for both left and right sides of comparison.
            char[] char1 = left.ToLower().ToCharArray();
            char[] char2 = right.ToLower().ToCharArray();

            // Sort the arrays
            Array.Sort(char1);
            Array.Sort(char2);

            // Move sorted char array into new string values.
            string newValue1 = new string(char1);
            string newValue2 = new string(char2);

            // Return true when values match, otherwise false.
            return (newValue1 == newValue2);
        }

        /// <summary>
        /// Reverses a string using iteration and recursion.
        /// </summary>
        /// <param name="value">The string to invert.</param>
        /// <returns>The inversion of the value to invert.</returns>
        public static string ReverseString(string value)
        {
            string result = string.Empty;
            StringBuilder sb = new StringBuilder();
            
            // Iterate through characters in value to invert in reverse order.
            for (int i = value.Length - 1; i >= 0; i--)
                sb.Append(value[i]);

            // Save results to return variable.
            result = sb.ToString();

            return result;
        }

        /// <summary>
        /// Returns the word count for a string.
        /// </summary>
        /// <param name="value">The string value to count.</param>
        /// <returns>An int representing the word count in a string.</returns>
        public static int WordCount(string value)
        {
            // Initialize to -1 in case of error.
            int result = -1;

            // Check if string is empty.
            if (string.IsNullOrEmpty(value))
                return 0;

            // Trim trailing and leading whitespace.
            value = value.Trim();

            // Ensure only single space between words.
            while (value.Contains("  "))
                value = value.Replace("  ", " ");

            // Iterate over each word and increment counter.
            foreach (string x in value.Split(' '))
                result++;

            return result;
        }

        /// <summary>
        /// Returns <c>true</c> when all characters in a string are unique, otherwise returns <c>false</c>.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <param name="useDictionary">Flag indicating whether to use a dictionary for the lookup or not.</param>
        /// <returns>Bool value indicating if a string has all unique characters.</returns>
        public static bool IsUnique(string value, bool useDictionary)
        {
            // Uses dictionary
            Dictionary<char, int> lookup = new Dictionary<char, int>();

            // Iterate over each character in the string value.
            foreach (char c in value)
            {
                // Check if lookup contains character already.
                if (lookup.ContainsKey(c))
                    return false;

                // Add character to lookup.
                lookup.Add(c, 1);
            }

            return true;
        }

        /// <summary>
        /// Returns <c>true</c> when all characters in a string are unique, otherwise returns <c>false</c>.
        /// </summary>
        /// <param name="value">The string value to check.</param>
        /// <returns>Bool value indicating if a string has all unique characters.</returns>
        public static bool IsUnique(string value)
        {
            // Initialize temporary storage values.
            string left = string.Empty;
            string right = string.Empty;

            // Iterate over length of the string value.
            for (int i = 0; i < value.Length; i++)
            {
                // Get the left side of the comparison.
                left = value.Substring(i, 1);

                // Iterate over length of the string value.
                for (int j = 0; j < value.Length; j++)
                {
                    // Get the right side of the comparison.
                    right = value.Substring(j, 1);

                    // If left equals right, not unique; return false.
                    if ((left == right) && (i != j))
                        return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Returns string value with the replacement value in place of search value.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="replacement"></param>
        /// <returns></returns>
        public static string ReplaceSpacesWith(string value, string searchValue, string replacement)
        {
            // Trim trailing and leading white space.
            value = value.Trim();

            // Replace search value with replacement value.
            return value.Replace(searchValue, replacement);
        }

        /// <summary>
        /// Returns a list of all possible substrings from a given string.
        /// </summary>
        /// <param name="value">The string to parse.</param>
        /// <returns>A list of all possible substrings for a given string.</returns>
        public static List<string> ExtractAllPossibleSubstringsFrom(string value)
        {
            // Initialize return variable.
            List<string> results = new List<string>();

            // Iterate over entire string starting at the beginning of the string.
            for (int length = 1; length < value.Length; length++)
            {
                // Handle the ending index because counter is zero-based.
                for (int start = 0; start <= value.Length - length; start++)
                    // Add substring to list.
                    results.Add(value.Substring(start, length));
            }

            // Return results.
            return results;
        }
    }
}

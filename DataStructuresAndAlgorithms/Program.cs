using System;

using DataStructuresAndAlgorithms.StringOperations;

namespace DataStructuresAndAlgorithms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(StringAlgorithms.RemoveDuplicateChars("Csharpstar"));
            Console.WriteLine(StringAlgorithms.RemoveDuplicateChars("Google"));
            Console.WriteLine(StringAlgorithms.RemoveDuplicateChars("Yahoo"));
            Console.WriteLine(StringAlgorithms.RemoveDuplicateChars("CNN"));
            Console.WriteLine(StringAlgorithms.RemoveDuplicateChars("Line1\\nLine2\\nLine3"));
        }
    }
}

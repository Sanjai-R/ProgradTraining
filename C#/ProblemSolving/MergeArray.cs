using System;
using System.Collections.Generic;


namespace ProblemSolving
{
   
    internal class MergeArray
    {
        static int[] arr1 = { 7, 18, 17, 3 };
        static int[] arr2 = { 22, 29, 21, 2 };
        static int[] mergedArr = new int[arr1.Length + arr2.Length];
        static void Main(string[] args)
        {
            Merge();
            Array.Sort(mergedArr);
            PrintArray(mergedArr);
        }
        public static void Merge()
        {
            int start = 0;
            foreach (int i in arr1)
            {
                mergedArr[start++] = i;
            }
            foreach (int i in arr2)
            {
                mergedArr[start++] = i;
            }
        }
        public static void PrintArray(int[] arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}

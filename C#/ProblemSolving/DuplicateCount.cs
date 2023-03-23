using System;
using System.Collections;

namespace ProblemSolving
{
    
    internal class DuplicateCount
    {
        static int[] arr = { 1, 1, 2, 3, 3, 4, 5,3 ,1};
        static void main(string[] args)
        {
            int count = CountDuplicates(arr);
            Console.WriteLine($"total number of dupicate elements {count}");
        }

        public static int CountDuplicates(int[] arr) {
            Dictionary<int, int> dict = new Dictionary<int, int>(); 
            int count = 0;
            foreach (int i in arr)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i]++;
                }
                else
                {
                    dict[i] = 1;
                }
            }

            foreach (var x in dict)
            {
                if (x.Value > 1)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

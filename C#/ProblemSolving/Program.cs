using System.Collections.Generic;

namespace ProblemSolving
{
    internal class OddEvenSeparation
    {
        static int[] arr = { 12, 1, 27, 7, 6 };
        static List<int> oddArray = new List<int>();
        static List<int> evenArray = new List<int>();
        static void main(string[] args)
        {
            Separation();
            Console.WriteLine("Even Array");
            PrintArray(evenArray);
            Console.WriteLine("Odd Array");
            PrintArray(oddArray);
        }

        public static void Separation()
        {

            foreach (int i in arr)
            {
                if (i % 2 == 1)
                {
                    oddArray.Add(i);
                }
                else
                {
                    evenArray.Add(i);
                }
            }

        }
        public static void PrintArray(List<int> arr)
        {
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
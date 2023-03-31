using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Stocks
    {
        static void main(string[] args)
        {
            int[] arr = { 7, 1, 5, 3, 6, 4 };
            var min = arr[0];
            var profit = 0;
            foreach (var current in arr)
            {
                profit = Math.Max(profit, current - min);
                min = Math.Min(min, current);
                Console.WriteLine($"profit-{profit} min-{min}");
            }
            Console.WriteLine(profit);
        }
    }
}

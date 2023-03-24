using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class frontBackString
    {
        static void main(string[] args)
        {

            string str = Console.ReadLine();
            char last = str[str.Length - 1];
            string result = last + str + last;
            Console.WriteLine($"Original String {str} Modified String {result}");
        }
    }
}

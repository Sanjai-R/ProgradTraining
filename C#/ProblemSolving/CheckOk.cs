using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class CheckOk
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();
            string result = check(inputString);
            Console.WriteLine(result);
        }
        public static string check(string str)
        {
 
            if (str.Contains("ok"))
            {

                return str.Replace("ok", "");
            }
            else
            {
                return str;
            }
        }
    }
}

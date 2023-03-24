using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class CalendarMan
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your birthdate (DD/MM/YYYY) format:");
            DateTime date = DateTime.Parse(Console.ReadLine());
            int age = new DateTime(DateTime.Now.Subtract(date).Ticks).Year - 1;

            Console.WriteLine($"You are {age} years old.");
         
        }
    }
}

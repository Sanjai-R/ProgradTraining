using System;

namespace Basics
{
    internal class ExceptionHandling
    {
       static void Main(string[] args)
        {
            
            int a = 10;
            int b = 0;
            int[] arr = { 1, 2, 3, 4 };
            try
            {
                int c = arr[4];
                int d = a / b;
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine(de.Message);
                Console.WriteLine("you cannot divide a num by zero");
            }
            catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
                Console.WriteLine("you're trying to access array element out of range");
            }
            
            finally { Console.WriteLine("Finally called"); }


            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18)
                {
                    throw new UserDefinedException("You're not eligible for voting");
                }
                else
                {
                    Console.WriteLine("Welcome! you passed the age restriction");
                }
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public class UserDefinedException : Exception
        {
            public UserDefinedException(string message) : base(message) { }

        }
    }
}

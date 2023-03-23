using System;

namespace Basics
{
    internal class ExceptionHandling
    {
       static void Main(string[] args)
        {
            int age = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (age < 18) {
                    throw new UserDefinedException("you're not eligible to vote");
                }
            }catch (IndexOutOfRangeException ex) {
                Console.WriteLine(ex.Message);
            }
            catch(UserDefinedException ex)
            {
                Console.WriteLine("Not Allowed To Vote!! \n" + "Error Message : " + ex.Message);
            }
            finally { Console.WriteLine("Finally called"); }
        }
        public class UserDefinedException : Exception
        {
            public UserDefinedException(string message) : base(message) { }

        }
    }
}

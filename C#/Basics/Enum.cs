using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Enums
    {
        public enum days
        {
            mon, tue, wed, thu, fri, sat, sun
        }

        public static void Days()
        {
            Console.WriteLine("Enums \n");
            int a = (int)days.mon;
            Console.WriteLine(a);

            foreach (string k in Enum.GetNames(typeof(days)))
            {
                Console.WriteLine(k);
            }


            Console.WriteLine("\n");
        }
    }
}

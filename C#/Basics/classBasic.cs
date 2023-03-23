using System;
using System.Xml.Linq;


namespace Basics
{
   
    internal class ClassBasic
    {
        string name;
        public ClassBasic(string name)
        {
            this.name = name;
        }
        public static void Print()
        {
            Console.WriteLine("Static method triggered");
        }
    }

}

using System;

namespace week_1
{

    public struct Triangle
    {
        public int sideA;
        public int sideB;
        public int sideC;

        public int GetPerimeter()
        {
            return this.sideA + this.sideB + this.sideC;
        }
    }

    public enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday };
    internal class StructsAndEnums
    {
        // renamed the Main to main to run other files in the projects!
        static void main(string[] args)
        {
            Triangle triangle = new Triangle();
            triangle.sideA = 10;
            triangle.sideB = 20;
            triangle.sideC = 30;
            int trianglePerimeter = triangle.GetPerimeter();
            Console.WriteLine(trianglePerimeter);
            Console.WriteLine((int)Days.Friday);
            foreach (Enum day in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(day.ToString());
            }
        }
    }
}
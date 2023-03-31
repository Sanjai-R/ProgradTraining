namespace Problems
{

    public class SpecialCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }
    }

    public class OppositeCalculator : SpecialCalculator
    {
        public new int Add(int a, int b)
        {
            return base.Subtract(a, b);
        }

        public new int Subtract(int a, int b)
        {
            return base.Add(a, b);
        }
    }

    public class Programs
    {
        static void Main1(string[] args)
        {

            SpecialCalculator normalCalc = new SpecialCalculator();

            int sum = normalCalc.Add(5, 10);
            Console.WriteLine("Sum using normal calculator: " + sum);

            int difference = normalCalc.Subtract(10, 5);
            Console.WriteLine("Difference using normal calculator: " + difference);

            OppositeCalculator oppositeCalc = new OppositeCalculator();

            int oppositeSum = oppositeCalc.Add(5, 10);
            Console.WriteLine("Sum using opposite calculator: " + oppositeSum);

            int oppositeDifference = oppositeCalc.Subtract(10, 5);
            Console.WriteLine("Difference using opposite calculator: " + oppositeDifference);

            Console.ReadLine();
        }
    }
}
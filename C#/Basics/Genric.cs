namespace Basics
{

    class Program<T>
    {
        public Program(T message)
        {
            Console.WriteLine(message);
        }
    }
    class Test
    {
        public static void main()
        {
            Program<string> cp = new Program<string>("working");
            Program<int> cp1 = new Program<int>(25);
            Program<float> cp2 = new Program<float>(25.5f);
        }

    }

}
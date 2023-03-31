namespace Delegates
{
    internal class AsyncProgramming
    {

        public async Task start()
        {
            await Method1();
            Method2();
            Console.ReadLine();
        }
        async Task<int> Method1()
        {
            Console.WriteLine("Method1 has started");
            await Task.Delay(2000);
            Console.WriteLine("Method1 has ended");
            return 100;
        }
        void Method2()
        {
            Console.WriteLine("Method2");

        }
    }
}
namespace Delegates
{
    internal class BuiltinDelegates
    {
        delegate void PrintString(string text);
        static void PrintText1(String text)
        {
            Console.WriteLine(text);
        }

        static void start()
        {
            //Traditional Delegate
            PrintString p1 = PrintText1;
            p1("sanjai");

            //Builtin delegate Action
            Action<string> print = (text) => Console.WriteLine(text);
            // print("Hello World");

            //arguments
            Func<int, int, string> add = (x, y) => $"{x} + {y} = {x + y}";
            // print(add(10, 20));

            List<string> list = new List<string>() { "Vishnu", "Riyaz", "Nantha" };
            Func<List<string>, List<string>> s3 = (list) =>
            {
                list.Sort();
                return list;
            };
            var val = s3(list);

            //predict
            Predicate<int> isEvenNumber = (x) => x % 2 == 0;

            print(isEvenNumber(9).ToString());

            List<int> lst = new() { 4, 3, 5, 6, 7 };

            Predicate<List<int>> checkIfGreaterThanFive = (list) => list.All((a) => a > 5);

            Console.WriteLine(checkIfGreaterThanFive.Invoke(lst));


        }

    }
}
namespace Chocolate_dispenser
{
    internal class Program
    {
        public static Stack<String> _dispenser = new Stack<String>();
        public static Action<dynamic> print = (x) => Console.WriteLine(x);
        public static Dictionary<string, int> chocolateItems = new Dictionary<string, int> {
        {"green", 0},
        {"blue", 0},
        {"red", 0},
        {"pink", 0},
        {"crimson",0 },
        {"purple",0 },
        {"silver",0 }
    };
        public static int chocolateCount = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                giveMainPrompt();
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "a":
                        Mutation.addChocolates();
                        break;
                    case "b":
                        Console.Write("Enter the Number of Chocolates to be removed:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        var items = Mutation.removeChocolates(n);
                        Console.WriteLine("remove items from top---------");
                        printList(items);
                        break;
                    case "c":
                        Console.Write("Enter the Number of Chocolates to be Dispensed:");
                        int c = Convert.ToInt32(Console.ReadLine());
                        var displayItem = Query.dispenseChocolates(3);
                        printList(displayItem);
                        break;
                    case "d":
                        Query.dispenseChocolatesOfColor("green");
                        break;
                    case "e":
                        printDict(chocolateItems);
                        break;
                    case "f":
                        Console.WriteLine("Sorted Chocolates by Count");
                        printDict(chocolateItems.OrderByDescending(key => key.Value));
                        break;
                    case "g":
                        print("Enter the color to be changed");
                        var oldColor = Console.ReadLine();
                        print("Enter the new color");
                        var newColor = Console.ReadLine();
                        print("Enter the number of chocolates to be changed");
                        var value = Convert.ToInt32(Console.ReadLine());
                        Mutation.changeChocolateColor(oldColor, newColor, value);
                        break;
                    case "h":
                        print("Enter the color to be removed");
                        var color = Console.ReadLine();
                        Mutation.removeChocolateOfColor(color);
                        break;
                    case "i":
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        public static void printDict(dynamic _dict)
        {
            foreach (var i in _dict)
            {
                print($"{i.Key} - {i.Value}");
            }
        }
        public static void printList(List<String> _lst)
        {
            foreach (var item in _lst)
            {
                print(item);
            }
        }
        public static void giveMainPrompt()
        {
            print(@"Enter any option
                a) Add Chocolates
                b) Remove Chocolates
                c) Dispense Chocolates
                d) Fav color Chocolates
                e) No of Chocolates
                f) Sort Chocolates
                g) Change Color 
                h) Remove Color
                i) Exit");
        }
    }
}
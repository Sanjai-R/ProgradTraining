namespace Chocolate_dispenser
{
    internal class Mutation : Program
    {
        public static void addChocolates()
        {
            Console.WriteLine("Give the color of the chocolate");
            var color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Give the count of the chocolate");
            int count = Convert.ToInt32(Console.ReadLine());
            chocolateItems[color] += count;
            chocolateCount = count + chocolateCount;
            for (int i = 0; i < count; i++)
            {
                _dispenser.Push(color);   //adding in order to stack
            }

        }
        public static List<String> removeChocolates(int count)
        {

            List<String> _removedItems = new List<String>();
            if (count > _dispenser.Count || count < 0)
            {
                Console.WriteLine($"Check the count,it out of length,plz give within range of {_dispenser.Count}");
            }
            else
            {
                for (int i = 1; i <= count; i++)
                {
                    _removedItems.Add(_dispenser.Pop());
                }
            }

            return _removedItems;
        }
        public static void changeChocolateColor(string oldColor, string newColor, int value)
        {
            if (chocolateItems.ContainsKey(oldColor))
            {
                chocolateItems.Remove(oldColor);
                chocolateItems[newColor] += value;
            }
            else
            {
                print("No such color");
            }

        }
        public static void removeChocolateOfColor(string color)
        {
            if (chocolateItems.ContainsKey(color))
            {
                chocolateItems.Remove(color);
            }
            else
            {
                print("No such color");
            }
        }
        public static void changeChocolateColorAllOfxCount(string oldColor, string finalColor)
        {
            if (chocolateItems.ContainsKey(oldColor))
            {
                int count = chocolateItems[oldColor];
                chocolateItems.Remove(oldColor);
                chocolateItems[finalColor] += count;
            }
            else
            {
                print("No such color");
            }

        }

    }
}

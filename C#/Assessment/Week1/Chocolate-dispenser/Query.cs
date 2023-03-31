namespace Chocolate_dispenser
{
    internal class Query : Program
    {
        public static List<string> dispenseChocolates(int count)
        {
            List<string> _addedItems = new List<string>();

            if (count > _dispenser.Count || count < 0)
            {
                Console.WriteLine($"Check the count,it out of or below length,plz give within range of {_dispenser.Count}");
            }
            else
            {
                int noOfChocolates = chocolateCount - count;
                int stopper = 0;
                foreach (var i in _dispenser)
                {
                    if (stopper >= noOfChocolates)
                    {
                        _addedItems.Add(i);
                    }

                    stopper++;
                }
            }

            return _addedItems;
        }
        public static void dispenseChocolatesOfColor(string color)
        {
            int colorCOunt = chocolateItems[color];
            for (int i = 0; i < colorCOunt; i++)
            {
                print(i);
            }

        }

        public static void noOfChocolates()
        {
            string[] count = { "green", "silver", " blue", " crimson", "purple", "red", "pink" };

            foreach (var i in count)
            {
                _dispenser.Count();
            }
        }
    }
}

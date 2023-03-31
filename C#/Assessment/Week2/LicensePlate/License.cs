using System;
using System.Text.RegularExpressions;
using System.Text;

namespace LicensePlate
{
    public class License
    {
        public static Action<dynamic> print = (x) => Console.WriteLine(x);
        public static void start()
        {
            while (true)
            {
                giveMainPrompt();
                var opt = Console.ReadLine();
                switch (opt)
                {
                    case "a":
                        ConversionPlate("5F3Z-2e-9-w", 4);
                        print($"5F3Z - 2e-9 - w => {ConversionPlate("5F3Z - 2e-9 - w", 4)}");
                        break;
                    case "b":
                        string dmvNumber = Console.ReadLine();
                        int count = Convert.ToInt32(Console.ReadLine());
                        ConversionPlate(dmvNumber, count);
                        break;
                    case "c":
                        return;
                    default:
                        print("Invalid Option");
                        break;
                }
            }
        }
        public static void giveMainPrompt()
        {
            print(@"Enter any option
                a) Convert DMV To Plate Number By Default
                b) Convert DMV To Plate Number By Custom Input
                c) Exit");
        }
        public static string ConversionPlate(string dmv, int n)
        {
            string res = Regex.Replace(dmv, @"[^a-zA-Z0-9]+", ""); //removed non-alpha numeric chars
            res = res.ToUpper(); //to change Upper case
            StringBuilder sb = new StringBuilder(); //Initialize Empty String
            for (int i = res.Length - 1, count = 0; i >= 0; i--)
            {
                sb.Insert(0, res[i]);
                count++;

                if (count == n && i != 0)
                {
                    sb.Insert(0, '-');// Add dash separator after every n characters (except for the last group)
                    count = 0;
                }
            }

            return sb.ToString();

        }


    }
}

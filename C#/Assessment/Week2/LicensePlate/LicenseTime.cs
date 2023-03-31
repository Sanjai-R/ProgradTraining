using System;
using System.Text.RegularExpressions;
using System.Text;

namespace LicensePlate
{
    public class LicenseTime
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
                        print(License("Eric", 2, "Adam Caroline Rebecca Frank"));
                        print(License("Zebediah", 1, "Bob Jim Becky Pat"));
                        print(License("Aaron", 3, "Jane Max Olivia Sam"));
                        break;
                    case "b":
                        print("Enter your name");
                        string name = Console.ReadLine();
                        print("Enter No of Agents");
                        int agent = Convert.ToInt32(Console.ReadLine());
                        print("Enter others");
                        string others = Console.ReadLine();
                        print(License(name, agent, others));
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
                a) License take time By Default
                b) License take time By Custom Input
                c) Exit");
        }
        public static int License(string myName, int agents, string others)
        {
            // Split the list of names into an array
            string[] names = others.Split(' ');

            List<string> list = new List<string>(names); 
            list.Add(myName);
            list.Sort(); 
            int minutes = 20* (list.IndexOf(myName) / agents + 1);
            return minutes;
        }

    }
}

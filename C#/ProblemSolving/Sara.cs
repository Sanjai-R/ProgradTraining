using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class Sara
    {
        static List<string> lst = new List<string>();
        static void main(string[] args)
        {

            while (true)
            {

                Console.WriteLine(@"SELECT any option sara
                a) Creating Qn
                b) Display qn
                c) Check Your Personality
                d) Exit");
                String option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        CreateQuestions();
                        break;
                    case "b":
                        DisplayQuestions();
                        break;
                    case "c":
                        checkPersonality();
                        break;
                    case "d":
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }


            static void CreateQuestions()
            {
                Console.WriteLine("Write a qn Sara:");
                string qn = Console.ReadLine();
                lst.Add(qn);
            }
            static void DisplayQuestions()
            {
                foreach (var i in lst)
                {
                    Console.WriteLine(i);
                }
            }

            static void checkPersonality()
            {
                string[] ans = new string[lst.Count];
                int start = 0;
                int introvert = 0, extrovert = 0;
                foreach (var qn in lst)
                {
                    Console.WriteLine(qn);
                    string a = Console.ReadLine();
                    ans[start++] = qn;
                }
                for (int i = 0; i < start; i++)
                {
                    if (ans[i] == "yeah")
                    {
                        introvert++;
                    }
                    else
                    {
                        extrovert++;

                    }
                }
                if (extrovert > introvert)
                {
                    Console.WriteLine("You're an Extrovert Kinda person");
                }
                else
                {
                    Console.WriteLine("You're an Introvert Kinda person");

                }

            }

        }
    }
}

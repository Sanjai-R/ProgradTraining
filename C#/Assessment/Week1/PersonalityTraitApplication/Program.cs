namespace PersonalityTraitApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine(@"SELECT any option
                a) Be a Mentalist
                b) Mimic Ptolemy
                c) Birthday Calc
                d) Exit"

            );
                String option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        PersonalityCheck.start(); ;
                        break;
                    case "b":
                        ZodiacSign.start(); 
                        break;    
                    case "c":
                        BirthdayCalc.start(); ;
                        break;
                    case "d":
                        return;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
            
           
        }
    }
}
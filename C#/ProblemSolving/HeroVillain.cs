using System;
namespace Basics
{
    internal class Class1
    {
        static void main(string[] args)
        {
            int HShot = 0, VShot = 0;
            int HBullets = 50, VBullets = 50;
            while (HBullets > 0 && VBullets > 0)
            {
                Console.WriteLine($"hero fired {HShot} - Villain Fired {VShot}");
                Console.WriteLine($"hero bullets remaining {HBullets} - Villain bullets remaining {VBullets}");
                Console.WriteLine("==========================================================");

                if (VBullets < 3)
                {
                    Console.WriteLine("The very Next Shot,Villain Dead");
                    break;
                }
                else if (HBullets < 1)
                {
                    Console.WriteLine("The very Next Shot,Hero Dead");
                    break;
                }
                HShot++;
                VShot += 3;
                HBullets--;
                VBullets -= 3;
            }

        }
    }
}

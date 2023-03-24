using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class exchangeString
    {
        static void main(string[] args)
        {

            string name;
            name = Console.ReadLine();
            string res="";
            res = Convert.ToString(name[name.Length - 1]);
            for(int i=1;i<= name.Length - 2; i++)
            {
                res += Convert.ToString(name[i]);
            }
            res += Convert.ToString(name[0]);
            Console.WriteLine(res);

        }
    }
}

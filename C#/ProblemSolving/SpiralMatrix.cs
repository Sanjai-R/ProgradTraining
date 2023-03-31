using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    internal class SpiralMatrix
    {
        static void main(string[] args)
        {
            int[,] arr = new int[3, 4];
            int k = 1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = k;
                    k++;
                }
            }
            var result = new List<int>();
            int row = 0, col = 4, btm = 3;
            while (result.Count > 12)
            {
                for (int i = 0; i < col; i++)
                {
                    result.Add(arr[row, col]);
                    Console.Write(arr[row, col]);
                }
                row++;
                for (int j = 0; j < btm; j++)
                {
                    result.Add(arr[j, col]);
                    Console.Write(arr[j, col]);
                }
                col--;
                for (int i = col; i > 0; i++)
                {
                    result.Add(arr[col, i]);
                    Console.Write(arr[col, i]);
                }
            }
        }
    }

}


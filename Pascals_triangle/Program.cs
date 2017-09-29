using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pascals_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] dizi = new double[1455, 1455];
            dizi[0, 0] = 1;
            for (int i = 1; i <= 10; i++)
            {
                for (int k = 1; k <= 10 - i; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 10; j++)
                {
                    dizi[i, j] = dizi[i - 1, j - 1] + dizi[i - 1, j];
                    if (dizi[i, j] > 0)
                        Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

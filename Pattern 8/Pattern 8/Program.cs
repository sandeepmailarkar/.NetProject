using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int Star = 5;
            for (i = 1; i <= Star; i++)
            {
                for (j = 1; j <= i; j++)
                         {
                              Console.Write("*");

                         }
                Console.WriteLine();
            }
            for (i = Star; i >= 1; i--)
            {
                for (j = 1; j < i; j++)
                         {
                                Console.Write("*");
                          }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

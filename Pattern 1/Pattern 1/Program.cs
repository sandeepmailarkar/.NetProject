using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                int star = i + 1;
                for (int j = 1; j < star; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }
    }
}

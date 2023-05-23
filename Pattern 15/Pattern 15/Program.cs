﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5; 

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    
                    if (j == 1 || i == rows || j == i)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

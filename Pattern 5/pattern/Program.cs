﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern5
{
    internal class Program
    {
        static void Main(string[] args)

        {

            int n = 5;


            for (int i = 1; i <= n; i++)
            {
                int star = i + 1;
                for (int j = 1; j <= (n - i); j++)
                {
                    Console.Write(" ");
                }

                for (int k = 1; k < i * 2; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

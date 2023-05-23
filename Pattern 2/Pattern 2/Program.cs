using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int num = 5; 
        int i, j, k;


            for (i = 1; i <= num; i++)
            {
                for (j = 1; j <= num - i; j++)
                          {
                             Console.Write(" ");
                         }
                for (k = 1; k <= i; k++)
                         {
                             Console.Write("*");
                         }
                Console.WriteLine("");
            }
                Console.ReadLine();
        }
    }
}

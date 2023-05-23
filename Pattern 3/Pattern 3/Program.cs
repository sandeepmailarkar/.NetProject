using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
                for (int i = 5; i >= 1; i--)
                {
                int star = i + 0;
                    for (int j = 1; j <= star; j++)
                    {
                        Console.Write("*");
                    }
                  
                    Console.WriteLine();
                }
            

        }
    }
}

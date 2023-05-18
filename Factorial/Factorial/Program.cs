using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;
            int fact = 1;


            for (int i = 1; i <= num; i++)
            {
                fact = fact * i;
            }   
                Console.WriteLine(fact);
                Console.ReadLine();

            

            
        }
    }
}

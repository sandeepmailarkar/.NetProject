using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;  
            
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.ReadLine();
        }
    }
}

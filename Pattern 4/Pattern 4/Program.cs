using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            string series = new string('*', n);
            string spaces = string.Empty;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(spaces + series);
                spaces += ' ';
                series = series.Substring(1);
            }
            Console.ReadLine();
        }
    }
}

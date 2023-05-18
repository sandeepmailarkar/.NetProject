using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unboxing1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            object iobj = i;

            i = 200;

            Console.WriteLine(i);
            Console.WriteLine(iobj);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UNboxingOne
{
    internal class Program
    {
        int i = 100;


        static void Main(string[] args)
        {
            int i = 100;
            object iobj = i;
            int j = (int)iobj;
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();

        }
    }
}

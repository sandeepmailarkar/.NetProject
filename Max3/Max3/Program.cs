using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3
{
    internal class Program
    {
            public void check(int a, int b, int c)
                {
            int m = a;
            if (m < b)
            {
                m = b;

            }
            {
                if (m < c)
                { m = c;
                }
            }

            {
        

        static void Main(string[] args)

        {
            int a, b, c;
            Console.WriteLine("Enter 3 no.....");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());   
            Program o = new Program();
            o.check(a, b, c);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max
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
            if (m < c)
            {
                m = c;
            }
            Console.WriteLine("Max Value is " + m);

        }

    

        
        
        
        static void Main(string[] args)
        {
    int a, b, c;
    Console.WriteLine("Enter 3 Numbers...");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());    
    c = Convert.ToInt32(Console.ReadLine());
    Program obj = new Program();
    obj.check(a, b, c);

}
    }
}

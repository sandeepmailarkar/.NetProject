using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace EvenLoop
{
    internal class Program
    {
        public void show(int n)
        {
            int i = 0;
            while (i <= n)

            {
                i = i + 2;
                Console.WriteLine("Even no,,," + i);
            }
        }
        static void Main(string[] args)     
        {
            int n;
            Console.WriteLine("Enter the Value...");
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            obj.show(n);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosNegProgram
{
    public void Check(int n)
    {
        if (n >=0)
        {
            Console.WriteLine("positive Number");
        }
        else
        {
            Console.Write("Negitive number");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter n Value...");
            n = Convert.ToInt32(Console.ReadLine());    
            Program obj = new Program();
            obj.Check(n);
        }
    }
}

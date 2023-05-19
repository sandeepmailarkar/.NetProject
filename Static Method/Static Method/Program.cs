using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Method
{
    internal class Program
    {
        
    public static int Add(int a, int b)

            

        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

static void Main(string[] args)
        {
           
            {
                int result = Program.Add(3,5);
                int result1 = Program.Subtract(10, 5);
                int result2 = Program.Multiply(10, 5);
                Console.WriteLine("Result: " + result);
                Console.WriteLine("Result: " + result1);
                Console.WriteLine("result: " + result2);
                Console.ReadLine();
            }
        }
    }
}

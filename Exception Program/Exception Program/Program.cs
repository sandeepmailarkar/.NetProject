using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Program
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the First Number   ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number   ");
            int num2 = int.Parse(Console.ReadLine());
           
            try
            {
                int Result = num1 / num2;
                Console.WriteLine("Division Result:   " + Result);
               

            }

            catch(DivideByZeroException) 
            { 
                Console.WriteLine("You Cannot Divid a Number By Zero   ");
               


            }
            
            
           

            


            Console.WriteLine("Remaining Statment 1");
            Console.WriteLine("Remaining Statment 2");
            Console.WriteLine("Remaining Statment 3");
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excption_Handling
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Square of the number: " + Math.Pow(number, 2));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Wait for user input before closing the console window
            Console.ReadLine();
        }
    }
}

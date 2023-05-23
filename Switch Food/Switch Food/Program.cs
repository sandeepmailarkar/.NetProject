using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Food
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your Pizza flavour...");
            string Pizza = Console.ReadLine();

            switch (Pizza)
            {
                case "Fajita":
                    Console.WriteLine("You have selected Fajita...");
                    break;

                case "Margarito":
                    Console.WriteLine("You have selected Margarito...");
                    break;

                case "Cheese":
                    Console.WriteLine("You have selected Cheese...");
                    break;

                case "CornPizza":
                    Console.WriteLine("You have selected CornPizza...");
                    break;

                default:
                    Console.WriteLine("Pizza Flovour Not available...");
                    break;

                    Console.ReadLine();
            }
        }
    }
}

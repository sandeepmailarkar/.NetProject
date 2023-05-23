using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string name = "Raj";

            switch (name)
            {
                case "Raj":
                    Console.WriteLine("Welcome Raj...");
                    break;

                case "Akash":
                    Console.WriteLine("Welcome Akash");
                    break;

                case "Nikhil":
                    Console.WriteLine("Welcome Nikhil");
                    break;

                case "Mukesh":
                    Console.WriteLine("Welcome Mukesh");
                    break;

                case "Shiva":
                    Console.WriteLine("Welcome Shiva");
                    break;

                default:
                    Console.WriteLine("\"You are not Student of this class...\"");
                    break;

                    Console.ReadLine();
            }
        }
    }
}

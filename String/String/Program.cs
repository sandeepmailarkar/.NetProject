using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
                string message = "Hello, World!";
                Console.WriteLine(message);

                string name = "Alice";
                int age = 25;
                string introduction = "My name is " + name + " and I'm " + age + " years old.";
                Console.WriteLine(introduction);

                string firstName = "Bob";
                string lastName = "Smith";
                string fullName = $"{firstName} {lastName}";
                Console.WriteLine("Full Name: " + fullName);

                
                Console.ReadLine();
            
        }
    }
}

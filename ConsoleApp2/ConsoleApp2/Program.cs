using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Data
    { 
        public void Nikhil()
        {
            Console.WriteLine("im Sandeep");
        }
        public void Akash()
        {
            Console.WriteLine("hello in Sandeep");
        }
        private void Raj()
        {
            Console.WriteLine("hii im Sandeep");
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            Data obj = new Data();
            obj.Nikhil();
            obj.Akash();
        }
    }
}

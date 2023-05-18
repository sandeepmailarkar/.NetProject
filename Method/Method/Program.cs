using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    internal class Program
    {
        class A {


            public void m1()
            {
                Console.WriteLine("Method with Parameter");
            }
        }

        
        
            public void m1(int i, int j)
            {

                Console.WriteLine(i + j);

            }
        
        
    }

    class B {
        static void Main(string[] args)
        {
            A a = new A();
            a.m1();
            a.m2(10, 5);
            Console.ReadLine();
        }

    }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal abstract class Animal
    {
        public abstract void Name();
        public abstract void Type();
    }
    class sandeep : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Name is   ");
        }
        public override void Type()
        {
            Console.WriteLine("Its Wild Animal   ");
        }
    }
    class crocodile : Animal

    {
        public override void Name()
        {
            Console.WriteLine("Name is crocodile   ");
        }
        public override void Type()
        {
            Console.WriteLine("Its Water Animal   ");
        }
    }

    class program
    {

        static void Main(string[] args)
        {
            Animal[] arr = new Animal[]
            {
                
                new crocodile()
            };
            foreach (Animal a in arr)
            {
                a.Name();
                a.Type();
            }
        }

    }
}

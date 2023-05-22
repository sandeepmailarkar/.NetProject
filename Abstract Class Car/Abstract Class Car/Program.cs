using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class_Car
{
    internal class Program
    {
        public abstract class Car
        {
            public string Name { get; }

            public Car(string name)
            {
                Name = name;
            }

            public abstract string Description();
        }

        public class Sedan : Car
        {
            public Sedan(string name) : base(name)
            {
            }

            public override string Description()
            {
                return $"The {Name} is a sedan.";
            }
        }

        public class SUV : Car
        {
            public SUV(string name) : base(name)
            {
            }

            public override string Description()
            {
                return $"The {Name} is an SUV.";
            }
        }
        static void Main()
        {
            Sedan hondaAccord = new Sedan("Honda Accord");
            SUV toyotaRAV4 = new SUV("Toyota RAV4");

            Console.WriteLine(hondaAccord.Description());   
            Console.WriteLine(toyotaRAV4.Description());
        }
    }
}

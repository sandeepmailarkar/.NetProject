using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hello");
            stringBuilder.Append(", ");
            stringBuilder.Append("World!");

            string finalString = stringBuilder.ToString();
            Console.WriteLine(finalString);
            Console.ReadLine();
        }
    }
}

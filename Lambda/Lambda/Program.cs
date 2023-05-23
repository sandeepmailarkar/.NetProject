using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    internal class Program
    {
        static void Main()
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            List<int> evenNumber = GetevenNumber(number);
        }

        static List<int> GetevenNumber(List<int> number)
        {
            foreach (int n in number)
            {
                if (n % 2 == 0)
                {
                    GetevenNumber().Add(n);
                }
            }
            return evenNumber;
        }
    }
}

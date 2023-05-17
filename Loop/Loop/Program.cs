using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    internal class Program
    {
       public void Show(int n)
        {
            int i = 0;
            while (i <= n)

            {
                Console.WriteLine("WhellCome To PISYST");
                i++;
            }
        }     
        static void Main(string[] args)
        {
            

            int n;
            Console.WriteLine("Enter n Values...");
            n = Convert.ToInt32(Console.ReadLine());    
            Program obj = new Program();
            obj.Show(n);   
        }
    }
}

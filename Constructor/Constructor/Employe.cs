using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Employe
    {
        int empID;
        string empName;
        int empAGE;

        public Employe(int empID, string empName, int empAGE)
        {
            {
                this.empID = empID;
                this.empName = empName;
                this.empAGE = empAGE;
            }


            public int getID()
            {
                return empID;
            }

            public int getID()
            {
                return empName;
            }

            public int getID()
            {
                return empAGE;
            }



        }



        static void Main(string[] args)
        {
            Employe Sandeep = new Employe(10, "Sandeep", 23);


            Console.WriteLine("Employe ID is ", Sandeep.getID());
            Console.ReadLine();

        }
    } }

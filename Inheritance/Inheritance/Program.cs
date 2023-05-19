using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        class VisitingEmployee : Employee   
        {
            public int VisitingHours;
            public int Visitingsalary;

        }

        class PermanentEmloyee : Employee
        {
            public int PermanentHours;
            public int Permanentsalary;
        }
        class Employee
        {
            public int empID;
            public string empName;
            public int empAge;
            public int empContactNo;


        }
        static void Main(string[] args)
        {
            PermanentEmloyee Sandeep = new PermanentEmloyee();
            Sandeep.empID = 1;
           

            VisitingEmployee Raj = new VisitingEmployee();
            Raj.empID = 2;

            Console.WriteLine(Sandeep.empID);
            Console.WriteLine(Raj.empID);
            Console.ReadLine();
           
            
           
           


        }
    }
}
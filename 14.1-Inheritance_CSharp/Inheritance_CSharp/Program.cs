using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_CSharp
{

    class VisitingEmployees : Employees //inheriting from base class
    {
        public int VisitingSalary;
        public int VisitingHours;
    }

    class PermanentEmployees : Employees //inheriting from base class
    {
        public int PermanentSalary;
        public int PermanentHours;
    }

    class Employees //base class 
    {
        public int EmpID;
        public string EmpName;
        public int EmpAge;
        public int EmpContactID;
    }

    //multi level inheritance
    class derivedClass1 : Employees
    {
        public void show()
        {
            Console.WriteLine(" this is  derived class 1");
        }
    }
    class DerivedClass2 : derivedClass1
    {
        public void show2()
        {
            Console.WriteLine(" this is  derived class 2");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PermanentEmployees Urooj = new PermanentEmployees();
            Urooj.PermanentSalary = 10;

            VisitingEmployees Sara = new VisitingEmployees();
            Sara.VisitingHours = 20;

            derivedClass1 derivedClass1 = new derivedClass1();
            derivedClass1.show();

            Console.WriteLine("---------------");

            DerivedClass2 derivedClass2 = new DerivedClass2();
            derivedClass2.show();
            derivedClass2.show2();


            Console.WriteLine("---------------");

            derivedclass3 derivedclass3 = new derivedclass3();
            derivedclass3.show(); derivedclass3.show2();

            Console.WriteLine("---------------");

            Console.WriteLine(Urooj.PermanentSalary);
            Console.WriteLine(Sara.VisitingHours);
        }
    }
}

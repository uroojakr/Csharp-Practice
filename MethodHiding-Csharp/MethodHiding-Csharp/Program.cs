using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding_Csharp
{
    class parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }

    class child : parent
    {
        public new void show()
        {
            //base.show();
            Console.WriteLine("Child class method");
        }
    }

    class employee
    {
        public string firstName;
        public string lastName;
        public void  PrintfullName()
        {
            Console.WriteLine(firstName+ " " +lastName);
        }
    }
    class  PartTimeEmployee :employee
    {
        public new void PrintfullName()
        {
            base.PrintfullName();
            Console.WriteLine(firstName + " " + lastName +" PTE");
        }
    }
    class FullTimeEmployee :employee
    {
        public new void PrintfullName()
        {
            
            Console.WriteLine(firstName + " " + lastName+" FTE");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            child c = new child();
            //c.show();

            //casting for base class
           // ((parent)c).show();

            //parent p = new child();
            //p.show();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Urooj";
            PTE.lastName = "Akram";
            PTE.PrintfullName();



            Console.ReadLine();
        }
    }
}

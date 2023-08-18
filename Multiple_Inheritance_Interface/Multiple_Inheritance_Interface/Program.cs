
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance_Interface
{
    internal class Program
    {
        class Person
        {
            public void show()
            {
                Console.WriteLine("This is a method of Person Class");
            }
        }
         interface Employee 
        {
            void show();
        }
        interface Employee1
        {
            void show();
        }


        class Teacher : Person, Employee, Employee1
        {
            void Employee.show() { Console.WriteLine("method of employee interface"); }

            void Employee1.show() { Console.WriteLine("method of employee1 interface"); }
            public void show()
            {
                Console.WriteLine("This is the method of Employee Interface Implemented");
            }
        }
        static void Main(string[] args)
        {
            //Teacher t = new Teacher();  
            //t.show();
           

            Employee e = new Teacher(); 
            e.show();

            Employee1 e1 = new Teacher();
            e1.show();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction_Csharp
{
    class Employee
    {
        public int EmpId;
        public string EmpName;
        public double GrossPay;
        double TaxDeduction = 0.1;
        double netSalary;


        public Employee(int empId, string empName, double grossPay)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.GrossPay = grossPay;

        }

        void CalculateSalary()
        {
            if (GrossPay >= 30000)
            {
                netSalary = GrossPay - (TaxDeduction * GrossPay);
                Console.WriteLine("Your Salary is {0}", netSalary);
            }
            else
            {
                Console.WriteLine("Your Salary is {0}", GrossPay);
            }
        }
        public void ShowEmployeeDetails()
        {
            Console.WriteLine("Employee Name {0}", this.EmpName);
            this.CalculateSalary();
        }
    }
        //Abstract Example

        abstract class Person
        {
            public string FirstName;
            public string LastName;
            public int age;
            public long _PhoneNumber;

        public static string Institute_Name = "NUML";


        //abstract Property
        public abstract int ID { get; set; }
        public abstract string Name { get; set; }
        public abstract void PrintDetails();
        
        }
        class Student : Person
        {
            public int RollNo;
            public int Fees;
            public int studentID;
            public int studentName;
       


            public override void PrintDetails()
            {
                string name = this.FirstName + " " + this.LastName;
                Console.WriteLine("Student Name is : {0}", name);
                Console.WriteLine("Student Age is : {0}", this.age);
                Console.WriteLine("Student RollNo is : {0}", this.RollNo);
                Console.WriteLine("Student Fees is : {0}", this.Fees);
            }
        public override int ID
        {
            set
            {
                this.studentID = value;
            }
            get
            {
                return this.studentID;
            }

        }
        public override string Name 
        { 
            set
            {
                this.FirstName = value; 
            }
            get
            {
                return this.FirstName;
            } 
        }

    }
        // class Teacher : Person
        //{
        //    public string qualification;
        //    public int salary;
             
        //    public override void PrintDetails()
        //    {
        //    string name = this.FirstName + " " + this.LastName;
        //    Console.WriteLine("Teacher Name is : {0}", name);
        //    Console.WriteLine("Teacher Age is : {0}", this.age);
        //    Console.WriteLine("Teacher RollNo is : {0}", this.qualification);
        //    Console.WriteLine("Teacher Fees is : {0}", this.salary);
        //}
        //}

        
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee(32,"Urooj", 532244);
            obj.ShowEmployeeDetails();

            Student Urooj = new Student();
            Urooj.FirstName = "Urooj";
            Urooj.LastName = "Akram";
            Urooj.RollNo = 320;
            Urooj.Fees = 32223;
            Urooj.age = 10033;
            Urooj.Name = " UroOJ AKRAM";
            Urooj.ID = 322;

            Urooj.PrintDetails();
            Console.WriteLine(Urooj.Name);
            Console.WriteLine(Urooj.ID);


            //Teacher  Sara= new Teacher();
            //Sara.FirstName = "Sara";
            //Sara.LastName = " Khan";
            //Sara.PhoneNumber = 322322222;
            //Sara.salary = 32323;
            //Sara.qualification = "MS CS";


            //Sara.PrintDetails();



            Console.ReadLine();
        }
    }
}

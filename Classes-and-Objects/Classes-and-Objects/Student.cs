using System;
using System.Globalization;
using System.Net.WebSockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Classes_and_Objects
{
    class Student
    {
 
       int rollno;
       static string name;
       int age;
       int standard;
       public static int studentcnic;


        //contructor
        public Student(int rollno, int age) 
        {
            this.rollno = rollno;
            this.age = age;
        }

        ~Student() 
        {
            Console.WriteLine(" Destructor invoked ");
        }
        //private constrcutor
        public static void getTime()
        {
            Console.WriteLine(DateTime.Now);
        }

        // static constructor
       //static Student()
       // {
       //     studentcnic = 3335;
       //     Console.WriteLine("static constructor invoked");
       // }

        // copy constructor
        //public Student(Student e)
        //{
        //   this.rollno= e.rollno;
        //    this.age= e.age;
        //}




        public void setStudent(int roll, string name, int age, int  standard)
        {
            this.rollno = roll;
            name = name;
            this.age = age;
            this.standard = standard;
            
        }

      

        public void getStudent()
        { 
            Console.WriteLine(" Your rollno is: {0}",this.rollno);
            Console.WriteLine(" Your name is: {0}", name);
            Console.WriteLine(" Your age is: {0}", this.age);
            Console.WriteLine(" Your Class is: {0}", this.standard);
        }

        public static void fees() 
        {
            
            Console.WriteLine(" {0} fees is 50000", name);
                
         }




        static void Main(string[] args) 
        {

            Console.WriteLine("Enter Roll No");
            int roll = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name");
            string naam = Console.ReadLine();

            Console.WriteLine("Enter Age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Class");
            int standard = int.Parse(Console.ReadLine());

            //Student stu = new Student();
            //stu.setStudent(roll,naam, age, standard);

            ////calling static contructor
            //stu.getStudent();
            //Student.fees();

            //calling copy constructor
            Student obj = new Student(32, 16);
            obj.getStudent();

            //Student obj1 = new Student(obj);


            //calling private contructor
            //Student e = new Student();

            GC.Collect();

            Console.ReadLine();

        }

     
    }
}
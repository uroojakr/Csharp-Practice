using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        class Student
        {
            public int id { get; set; }
            public string Name { get; set; }
            public int standard { get; set; }
        }

        class School : IEnumerable 
        {
            List<Student> students = new List<Student>();

            public void Add(Student s)
            {
                students.Add(s);
            }

            public IEnumerator GetEnumerator()
            {
               return students.GetEnumerator();
            }
        }

        class program
        {
            static void show1(IEnumerator<int> i)
            {
                while(i.MoveNext()) 
                {
                    Console.WriteLine(i.Current);
                    if(i.Current == 6)
                    {
                        show2(i);
                    }

                }
            }

            static void show2(IEnumerator<int> i)
            {
                while (i.MoveNext())
                {
                    Console.WriteLine(i.Current);
                }
            }
        }


        static void Main(string[] args)
        {
            //Student student = new Student();    
            //student.id = 1;
            //student.Name = "Urooj";
            //student.standard = 14;

            //Student student2 = new Student();
            //student2.id = 13;
            //student2.Name = "Urooj";
            //student2.standard = 144;

            //Student student3 = new Student();
            //student3.id = 21;
            //student3.Name = "Urooj";
            //student3.standard = 1334;

            //School students = new School(); 
            //students.Add(student);
            //students.Add(student2);
            //students.Add(student3);

            //foreach(Student s in students)
            //{
            //    Console.WriteLine(s.id+" "+s.Name+" "+s.standard);
            //}
            List<int> numbers = new List<int>() { 3, 2, 6, 2 };

            IEnumerator<int> nums1 = numbers.GetEnumerator();
          //  show1(nums1);

            // Reset the enumerator by creating a new one
            IEnumerator<int> nums2 = numbers.GetEnumerator();
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

        

            //foreach(int i in numbers) 
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("-----------------");
            //IEnumerator<int> nums = numbers.GetEnumerator();

            //while(nums.MoveNext()) 
            //{
            //    Console.WriteLine(nums.Current.ToString());
            //}

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Properties_Csharp
{

    class Student
    {
        private int _StdID;
        private string _Name;
        private string _Fname;
        private int _SubjectTotalMarks = 100;

        //making properties 
        public int StdID
        {
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("ID cannot be zero or negative");
                }
                else
                {
                    this._StdID = value;
                }
            }
            get
            {
                return this._StdID;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("Enter a name");
                }
                else
                {
                    this._Name = value;
                }
            }
            get
            {
                return this._Name;
            }
        }

        public string Fname
        {
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this._Fname = value;
                }
                else
                {
                    Console.WriteLine("Enter Father Name");
                }
            }
            get
            {
                return this._Fname;

            }
        }

        public int SubjectTotalMarks
        {
            get
            { return this._SubjectTotalMarks; }
        }

        public int MyProperty { get; set; }
    }

    //static example
    class University
    {
        private static string UniversityName;
        private static string DepartmentName;

        public static string _UniversityName
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("you cannot enter null or empty value in university name");
                }
                else
                {
                    UniversityName = value;
                }
            }
            get
            {
                return UniversityName;
            }
        }

        // public int Age { get; set; }

        public static string _DepartmentName 
        { 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("you cannot have empty or null value");
                }
                else
                {
                    DepartmentName = value;
                }
            }
            get
            {
                return DepartmentName;
            }
        }
    }
        class Program
        {
            static void Main(string[] args)
            {
                Student student = new Student();
                student.StdID = 2;
                student.Name = "Urooj";
                student.Fname = "Akram";
                Console.WriteLine(student.StdID);
                Console.WriteLine(student.Name);
                Console.WriteLine(student.Fname);
                Console.WriteLine(student.SubjectTotalMarks);

                University._UniversityName = "NUML";
                Console.WriteLine("University Name is "+ University._UniversityName);
                University._DepartmentName = " Ghazali Block";
                Console.WriteLine("Department Name is {0}", University._DepartmentName);

            Console.ReadLine();
            }
        }
    }


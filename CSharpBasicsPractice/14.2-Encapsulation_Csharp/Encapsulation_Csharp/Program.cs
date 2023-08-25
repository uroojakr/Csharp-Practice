
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_Csharp
{

    class Person
    {
        private string Name;
        private int Age;

        public void setName(string Name)
        {
            if(string.IsNullOrEmpty(Name) == true)
            {
                Console.WriteLine(" Enter a valid Name");
            }
            else
            { 
                this.Name = Name; 
            }
       
        }
        public void getName() 
        {
            if (string.IsNullOrEmpty(this.Name) == true)
            {
               
            }
            else
            {
                Console.WriteLine("Name : ", this.Name);
            }
        }
        public void setAge(int Age)
        {
            if(Age > 0) 
            {
                Console.WriteLine("Your Age is :", this.Age);
            }
            else
            {
                Console.WriteLine("Age shouldn't be -ve or zero");
            }
           
        }
        public void getAge()
        {
            if (Age > 0)
            {
                Console.WriteLine("Your Age is :", this.Age);
            }
            else
            {
             
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.setName("");
            p.getName();
            p.setAge(13);
            p.getAge(); 
           
            Console.ReadLine(); 
        }
    }
}

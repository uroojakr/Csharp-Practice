using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_MethodFtnOverloading
{
    class Polymorphism
    {
        public void add()
        {
            int a = 4;
            int b = 23;
            int c = a + b;
            Console.WriteLine(c);
        }
        public int add(int a, int b)
        {
            int c = a + b;
            return c;
        }

        public void add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine(c);
        }
    }

        //operator overloading
        class NewClass
        {
            public string str;
            public int num;

        //make a function for overloading operator ;
        public static NewClass operator +(NewClass obj1, NewClass obj2)
        {
            NewClass obj3 = new NewClass();
            obj3.str = obj1.str + obj2.str;
            obj3.num = obj1.num + obj2.num;
            return obj3;
        }

        }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism pol = new Polymorphism();
            //pol.add();
            //Console.WriteLine(pol.add(3, 2));
            //pol.add("Urooj", "Akram");
            
            
            NewClass obj1 = new NewClass(); 
            obj1.str = "hello";
            obj1.num = 32;


            NewClass obj2 = new NewClass();
            obj2.str = "Urooj";
            obj2.num = 21;

            NewClass obj3 = new NewClass();
            obj3 = obj1 + obj2; //need to overload this + opertor or gives error

            Console.WriteLine(obj3.str);
            Console.WriteLine(obj3.num);

            Console.ReadLine();
        }
    }
}

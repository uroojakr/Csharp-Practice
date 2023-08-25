using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_CSharp
{
    internal class Program
    {
        class Example
        {
            public static void ShowArray<T>(T[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                }
            }

            public static bool Check<T>(T a, T b)
            {
                bool c = a.Equals(b);
                Console.WriteLine(typeof(T));
                return c;
            }
        }
        class GenericClass<T> //work on multiple dataypes
        { 
            //generic class example

            T box;

            //public GenericClass(T b) 
            //{
            //    this.box = b;
            //}
            //public T getBox()
            //{
            //    return this.box;
            //}

            //generic property
            public  T BOX 
            {
                set
                {
                    this.box = value;
                }
                get 
                {
                    return this.box;
                }
            
            }

        }
        static void Main(string[] args)
        {
            int[] numbers = new int[3];
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;

            double[] points = { 32.33, 32.3, 54.4 };

            string[] Name = { "Urooj", "hina", "Rabia" };
            Example.ShowArray(Name);
            Example.ShowArray(numbers);
            Example.ShowArray(points);
            Console.WriteLine(Example.Check(4, 4));


            //gneric class example 
            //GenericClass<int> g = new GenericClass<int>(20);
            //GenericClass<string> g1 = new GenericClass<string>("Urooj");
            //Console.WriteLine(g.getBox());
            //Console.WriteLine(g1.getBox());

            //generic property
            GenericClass<int> e = new GenericClass<int>();
            GenericClass<string> e2 = new GenericClass<string>();
            e2.BOX = "Sara";
            e.BOX =34;
           
            Console.WriteLine(e.BOX);
            Console.WriteLine(e2.BOX);


            Console.ReadLine();
        }
    }
}

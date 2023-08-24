using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods_in_Csharp
{
    internal class Program
    {
        public void show() //Declaring a non static method
        {
            Console.WriteLine("Hello Urooj");
        }
        public static void show1() //Declaring a static method
        {
            Console.WriteLine("Hello Urooj");
        }
        public static void sum(int a,int b) 
        {
            int result = a + b;
            Console.WriteLine(" result is {0}", result);

        }
        static void Main(string[] args)
        {
            Program.sum(32, 32);
            Program.show1();
            Program p1 = new Program();
            p1.show();
            Console.WriteLine();
        }
    }
}

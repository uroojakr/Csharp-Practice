using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_Function_Demo_CSharp
{
    public delegate void MyDelegate(int num);
    /*public delegate int MyDelegate(int num)*/
    internal class Program
    {
        public static void MyMethod(MyDelegate del, int a)
        {
            a += 10;
            del.Invoke(a);
        }



        static void Main(string[] args)
        {
            // MyDelegate obj = new MyDelegate(Program.MyMethod);
            //MyDelegate obj = delegate (int a)
            //{
            //    a += 10;
            //    return a;
            //};
            Program.MyMethod(new MyDelegate(delegate (int b) { b += 10; Console.WriteLine(b); }), 6);

            //Console.WriteLine( obj.Invoke(4));
            ////or
            //Console.WriteLine( obj(3));
            
            //Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    public delegate void MyDelegate(int num);
    public delegate int MyDelegate2(int num);
    public delegate int MyDelegate3(int num, int num2);

    internal class Program
    {
        static void Main(string[] args)
        {
            MyDelegate OBJ = (a) =>
            {
                a += 5;
                Console.WriteLine(a);
            };

            MyDelegate2 OBJ2 = (a) => a * a;

            MyDelegate3 OBJ3 = (a, b) => a + b;

            Console.WriteLine(OBJ2.Invoke(3));
            Console.WriteLine(OBJ3.Invoke(3,4));
            OBJ.Invoke(5);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_CSharp
{
    //making delegate, should have return type same as method, same signature

    public delegate void Calculation(int a, int b);
    public delegate void Show_Delegate();
    public delegate void Calculation2(int num);
    internal class Program
    {
        public static void Square(int num)
        {
            int square = num * num;
            Console.WriteLine("Square of {0} is {1},",num,square);
        }

        public static void Cube(int num)
        {
            int cube = num * num * num;
            Console.WriteLine("Cube of {0} is {1},", num, cube);
        }
        public static void Show()
        {
            Console.WriteLine("This is a show Method!");
        }
        public static void Addition(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Addition result is : {0}", result);
        }
        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multi result is : {0}", result);
        }
        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction result is : {0}", result);
        }
        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Div result is : {0}", result);
        }
        static void Main(string[] args)
        {
            Calculation obj = new Calculation(Program.Addition);
            //obj.Invoke(3,5);
            //obj = Subtraction;
            //obj(20, 10);
            //obj = Division;
            //obj(4, 2);
            //obj = Multiplication;
            //obj(4, 3);

            Calculation obj2 = new Calculation(Program.Division);
            obj2.Invoke(20, 10);

            Show_Delegate obj3 = new Show_Delegate(Show);
            obj3.Invoke();

            Calculation2 obj4 = new Calculation2(Square);
            obj4.Invoke(4);

            Calculation2 obj5 = new Calculation2(Cube);
            obj5.Invoke(4);
            obj += Subtraction;
            obj(3, 2);

            //or using first obj to refrence or point to cube
            obj4 = Cube;
            obj4.Invoke(3);

            Console.ReadLine();

        }
    }
}

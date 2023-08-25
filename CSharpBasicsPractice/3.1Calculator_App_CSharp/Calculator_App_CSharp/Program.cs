using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App_CSharp
{
    internal class Program
    {
        public static void Addition(int a,int b)
        {
            int result = a + b;
            Console.WriteLine("Addition Result is : {0}",result);
        }

        public static void Subtraction(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Subtraction Result is : {0}", result);
        }

        public static void Multiplication(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Multiplication Result is : {0}", result);
        }

        public static void Division(int a, int b)
        {
            int result = a / b;
            Console.WriteLine("Division Result is : {0}", result);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(" Enter a First Number");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter a Second Number");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine(" Enter Operator (+,-,*,/)");
            string op = Console.ReadLine();

            if(op.Equals("+"))
            {
                Addition(num1, num2);
            }else if(op.Equals("-")) 
            {
                Subtraction(num1, num2);    
            }
            else if(op.Equals("*")) 
            { 
                Multiplication(num1, num2); 
            }
            else if(op.Equals("/")) 
            {
                Division(num1, num2);   
            }
            else
            {
                Console.WriteLine("Invalid Option");
            }
            

            
        }
    }
}

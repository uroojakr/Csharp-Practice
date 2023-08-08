using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HelloWorld
{
    /* class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("hello world");

             int   i   = 56;
             float j = 6;
             TestFunction();
             bool b = SecondTestFunction(4);


             //Console.ReadKey();

             void TestFunction()
             {

             }
             static bool SecondTestFunction(int i)
             {
                 return i < 100;
             }

             int[] intArray = new int[20];

             List<int> list = new List<int>() { 1, 2, 3 };

             list.Add(3);

             byte number = 30;
             Console.WriteLine(number);

             var apples = 100;
             var orange = 30m;

             int ss = apples % 2;
             var div = apples / orange;
             Console.WriteLine(div.GetType());
             Console.WriteLine(div);

             DateTime today = new DateTime(2020, 8, 1, 0 , 0 ,40);
             Console.WriteLine(today);
             Console.WriteLine(DateTime.UtcNow); 
             Console.WriteLine(today.DayOfYear);
             Console.WriteLine(today.AddHours(4));

         }
     }*/

    // practice problems //
    // 1- Program to print an integer entered by user
  
    /*class UserInt
        {
            static void Main(string[] args)
            {


                int number;
                Console.WriteLine("Enter a Number");
                number = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("you entered the number, {0}, type of  {0} is {1}",number,number.GetType());
            
            }
        } */

    //2- Program for Operators
    /*class Operations
    {
        static void Main(string[] args)
        {
            float num4 = 0.2f;
            int num1, num2, num3, sum=0, div, mul;
            Console.WriteLine("Enter First Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            num2 = Convert.ToInt32(Console.ReadLine());
            sum = num1 + num2;
            mul = num1* num2;
            div = num2 % num1;
            Console.WriteLine("Sum is {0} Mul is {1} Div is {2}", sum, mul,div);
            Console.WriteLine(num4);
        }
    }*/

    //3- Calculating Rectangle Area
    class RectangleArea
    {
        static void Main(string[] args)
        {
            int squareheight, perimeter, area;
            Console.WriteLine("Enter Square Height");
            squareheight = Convert.ToInt32(Console.ReadLine());
            area = squareheight * squareheight;
            perimeter = 4 * squareheight;
            Console.WriteLine("Area {0} \n Perimeter {1}", area,perimeter);
        }
    }



} // namespace
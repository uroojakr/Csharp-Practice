using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;
using System.Runtime.InteropServices;

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
    /* class RectangleArea
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
    }*/

    //4- Enums in C#
    enum list
    {
        jan = 1,
        feb,
        march,
        april,
        may,
    }
    class EnumPractice
    {
        static void Main(string[] args)
        {
            //list year = list.jan;
            //Console.WriteLine(year);
            //Console.BackgroundColor = ConsoleColor.Yellow;

            //Console.WriteLine("Enter your Name ");
            //string name = Console.ReadLine();

            //Console.WriteLine("Enter your Bday  Jan = 1, Feb = 2, March = 3");
            //int value = int.Parse(Console.ReadLine());

            //list myYear = (list)value;

            //Console.WriteLine("My name is: {0} and my birth month is {1}", name, myYear);

            //string[] members = (string[])Enum.GetNames(typeof(list));

            //foreach (string member in members)
            //{
            //    Console.WriteLine(member);
            //}

            //int[] membersValues = (int[])Enum.GetValues(typeof(list));

            //foreach (int member in membersValues)
            //{
            //    Console.WriteLine(member);
            //}

            //  list MyYear = list.march;
            //int MyYear = (int)list.april;
            //switch (MyYear)
            //{
            //    case 1:
            //        Console.WriteLine("Hello this is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello this is feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello this is march");
            //        break;
            //    case 4:
            //        Console.WriteLine("Hello this is april");
            //        break;
            //    case 5:
            //        Console.WriteLine("Hello this is may");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Day");
            //        break;
            //}
            //string[] name = { "urooj", "sara" };
            //string[] car = new string[3];
            //string[] pen = new string[] { "picasso", "healy" };

            //int[,] numbers  = { { 3,2,5}, {2,4,2 } };

            //for (int i = 0; i < numbers.GetLength(0); i++)
            //    for (int j = 0; j < numbers.GetLength(1); j++)
            //    {
            //        {
            //            Console.WriteLine(numbers[i, j]);
            //        }
            //    }
            //foreach(int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}


        }
        static class product
        {
            public static int ProductId;
            public static string ProductName;
            public static string ProductDescription;    

            static product()
            {
                ProductId = 1;
                ProductName = "piano";
                ProductDescription = " antique piano ";
            }

        }

        
        

    }




    } // namespace
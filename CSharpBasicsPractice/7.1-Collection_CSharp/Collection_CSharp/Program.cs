using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] MyArray = new int[3];
            //MyArray[0] = 1;
            //MyArray[1] = 2;
            //MyArray[2] = 3;
            
           

            //Array.Resize(ref MyArray, 4);
            //MyArray[3] = 4;

            ArrayList MyList = new ArrayList(10);
            MyList.Add(10);
            Console.WriteLine(MyList.Capacity);

            //IN Obj data type, can store any type of data
            MyList.Add(30);
            MyList.Add(20);
            MyList.Add(60);
            MyList.Add(70);

            MyList.Insert(2, 33);
            MyList.RemoveAt(2);
            //give number direct
            MyList.Remove(33);
            foreach (Object i in MyList)
            {
                Console.Write(i + " ") ;
            }
            Console.WriteLine();

            

            Console.ReadLine();
        }
    }
}

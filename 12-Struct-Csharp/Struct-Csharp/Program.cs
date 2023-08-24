using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Csharp
{
    struct Program
    {
        int a;
        
        public void func1()
        {
            Console.WriteLine("this is my new function ...."+a);
        }

        static void Main(string[] args) 
        {
            Program test = new Program();
            Program p; 
            p.a = 10;
            p.func1();
            Console.ReadLine();
        }
    }

    interface myInterface
    {
        void show();
    }
    struct myStruct : myInterface
    {
        public void show()
        {
            Console.WriteLine(" Interface ");
        }
    }
}

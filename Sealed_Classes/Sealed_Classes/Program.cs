using System;

namespace Sealed_Classes
{
    sealed class BaseClass
    {
        public void show1()
        {
            Console.WriteLine("Method of Base Class");
        }
    }

    class DerivedClass
    {
        public void show2()
        {
            Console.WriteLine("Method of Derived Class..");
        }
    }

    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is a method of Class A !!");
        }
    }

    class B : A
    {
        public sealed override void Print()
        {
            Console.WriteLine("This is a method of Class B !!");
        }
    }

    class C
    {
        public void Print()
        {
            Console.WriteLine("This is a method of Class C !!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            C objC = new C();
            objC.Print();

            A objA = new B();
            objA.Print();

         
        }
    }
}

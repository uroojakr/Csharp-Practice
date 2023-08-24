using System;
using System.Threading.Channels;

internal class Method_Overriding
{
    class Parent
    {
        public virtual void print()
        {
            Console.WriteLine("This is a method of Parent Class");
        }
    }
    class Child :Parent
    {
        public override void print()
        {
            //base.print();
            Console.WriteLine("This is a method of Child Class");
        }

        public static void myMethod(string Child1, string Child2, string Child3) 
        {
            Console.WriteLine("The Youngest is "+Child3);
        }
    }

    class Program
    {
        static void Main(string[] args) 
        { 
            Parent p  = new Child();
            p.print();

            Child.myMethod(Child1: "john", Child2: "sara", Child3: "sidra");

           
            Console.ReadLine();

            
        
        }
    }
}
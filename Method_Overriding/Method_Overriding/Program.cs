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
    }

    class Program
    {
        static void Main(string[] args) 
        { 
            Parent p  = new Child();
            p.print();

            Console.ReadLine();
        
        }
    }
}
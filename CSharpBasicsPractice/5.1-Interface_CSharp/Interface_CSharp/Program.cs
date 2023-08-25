using Interface_CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Interface_CSharp { 
//{
//    interface IEmployee
//    {
//        void show();

//    }

//    //inheritance in interface

//    interface i1
//    {
//        void print();
//    }
//    interface i2
//    {
//        void print1();
//    }
//    interface i3 : i2, i1
//    {
//        void print2();
//    }
//    class PartTimeEmployees : IEmployee
//    {
//        public void show()
//        {
//            Console.WriteLine("This is a method of IEmployee Interface");
//        }
//    }
//}
//    internal class Program : i3
//    {
//        public void print()
//    {
//        Console.WriteLine("this is a methid of interface 1");
//    }
//    public void print1()
//    {
//        Console.WriteLine("this is a methid of interface 2");
//    }
//    public void print2()
//    {
//        Console.WriteLine("this is a methid of interface 3");
//    }
//    static void Main(string[] args)
//        {
//        PartTimeEmployees pte = new PartTimeEmployees();
//        pte.show();




//        //-
//        Program p = new Program();
//        p.print();
//        p.print1();
//        p.print2();

//        i3 i = new Program();
//        i.print();
//        Console.ReadLine();
//    }
//    }
class Program
{
    static void Main(string[] args)
    {
        ISpotify basicPlayer = new BasicPlayer();
        ISpotify premiumPlayer = new PremiumPlayer();

        MusicPlayerController controller = new MusicPlayerController();
        controller.UsePlayer(basicPlayer);
        Console.WriteLine("--------");
        controller.UsePlayer(premiumPlayer);
    }
}
}
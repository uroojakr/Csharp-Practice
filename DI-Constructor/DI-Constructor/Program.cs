using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DI_Constructor
{
    internal class Program
    {
        //tight coupling
        //class CurrentAccount
        //{
        //    public void PrintDetails()
        //    {
        //        Console.WriteLine("Details of current account");
        //    }
        //}
        //class SavingAccount
        //{
        //    public void PrintDetails()
        //    {
        //        Console.WriteLine("Details of Saving account");
        //    }
        //}

        //class Account
        //{
        //    CurrentAccount ca = new CurrentAccount();
        //    SavingAccount sa = new SavingAccount();

        //    public void PrintAccounts()
        //    {
        //        ca.PrintDetails();
        //        sa.PrintDetails();
        //    }
        //}

        //using DI
        public interface IAccount
        {
            void printDetails();
        }

        class CurrentAccount : IAccount
        {
            public void printDetails()
            {
                Console.WriteLine("Details of Current account");
            }
        }
      class SavingAccount : IAccount
        {
            public void printDetails()
            {
                Console.WriteLine("Details of Saving account");
            }
        }
        class Account
        {
            //constructor injection
            //private IAccount account;

            //public Account(IAccount account)
            //{
            //    this.account = account;
            //}

            //public void printAccounts() 
            //{
            //    myAccount.printDetails();
            //}

            //property injection
            //public IAccount account { get; set; }

            //public void printDetails()
            //{ 
            //    account.printDetails();
            //}

            //method injection
            public void PrintAccounts(IAccount account)
            {
                account.printDetails();
            }
        }

     


        static void Main(string[] args)
        {
            //tight coupling
            //Account a = new Account();
            //a.PrintAccounts();
            //Console.ReadLine();


            //cons
            //IAccount ca = new CurrentAccount(); //injector ko pass kia 
            //Account a = new Account(ca);
            //a.printAccounts();

            //IAccount sa = new SavingAccount();
            //Account a1 = new Account(sa);
            //a1.printAccounts();


            //prop
            //Account sa = new Account(); 
            //sa.account = new SavingAccount();
            //sa.printDetails();

            //Account ca = new Account(); 
            //ca.account = new CurrentAccount();
            //ca.printDetails();

            //method
            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //hashtable example
            Hashtable ht = new Hashtable();
            ht.Add("key1", 433);
            ht.Add("Name", "Urooj");
            ht.Add("Salary", 332333);
            ht.Add("Designation", "Manager");
            ht.Add("IsMarried", false);
            //or

            //Hashtable ht = new Hashtable()
            //{
            //    { "ID", 444 },
            //    {"Name", "Urooj" }
            //};

            // Console.WriteLine(ht["Designation"]);
            //Console.WriteLine(ht["Name"]);
            //foreach (Object key in ht.Keys)
            //{
            //    Console.WriteLine(key+" "+ht[key]);
            //}
            //ht.Remove("key1");
            //Console.WriteLine("----------------------");
            //foreach (Object key in ht.Keys)
            //{
            //    Console.WriteLine(key + " " + ht[key]);
            //}

            Console.WriteLine(ht.Contains("Name"));
            Console.WriteLine(ht.Count);

            Console.WriteLine("------- Non Generic Stack Example----------");

            Stack myStack = new Stack();
            myStack.Push("hello");
            myStack.Push(433);
            myStack.Push(5.11);
            myStack.Push(false);
            myStack.Push(null);

            foreach (object item in myStack) 
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------------------------------------------");
            myStack.Pop();
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Contains("hello"));

            Console.WriteLine("------- Non Generic Queue Example----------");
            Queue myQueue = new Queue();  
            myQueue.Enqueue("Sara");
            myQueue.Enqueue(3232);
            myQueue.Enqueue(43.3);
            myQueue.Enqueue(true);
           // myQueue.Enqueue(null);

            foreach (object item in myQueue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.Peek());

            //  Console.WriteLine(myQueue.Dequeue());
            Console.WriteLine("------------------------------------------------");
            while (myQueue.Count > 0)
            {
                Console.WriteLine(myQueue.Dequeue());
            }
            Console.WriteLine("------------------------LIST--GENERIC----------------------");
            List<int> ls = new List<int>();
            ls.Add(77);
            Console.WriteLine(ls.Capacity);

            employee emp1 = new employee()
            {
                Age = 44,
                Name = "Urooj",
                Job_Role = "Manager"
            };
            employee emp2 = new employee()
            {
                Age = 44,
                Name = "Huma",
                Job_Role = "Manager"
            };


            List<employee> empList = new List<employee>();

            empList.Add(emp1);
            empList.Add(emp2);


            Console.WriteLine(empList.Exists(emp => emp.Name.StartsWith("H")));
            //foreach (employee emp in empList)
            //{
            //    Console.WriteLine("employee name:{0}, employee Age: {1}, employee Job Role: {2}", emp.Name, emp.Age, emp.Job_Role);
            //}

            //List<int> myNumbers = new List<int>();
            //myNumbers.Add(34);
            //myNumbers.Add(40);
            //myNumbers.Add(60);
            //myNumbers.Add(60);

            //Console.WriteLine(myNumbers.Contains(40));

            Console.ReadLine();
        }
    }
}

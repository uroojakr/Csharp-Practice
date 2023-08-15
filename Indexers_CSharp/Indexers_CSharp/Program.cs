using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_CSharp
{
    internal class Program
    {
        class Employee
        {
            public int[] Age = new int[3]; // size is 3

            //to generate indexer
            public int this[int index]
            {
                set
                {
                    if (index >= 0 && index < Age.Length)
                    {
                        if (value > 0)
                        {
                            Age[index] = value;
                        }
                        else
                        {
                            Console.WriteLine(" Value is Invalid");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Index!");
                    }
                }
                

                

                get { return Age[index];  }
               
            }
            public int this[int index, int i ]
            {
                set
                {
                    Age[ index ] = value + i;
                }
                get 
                { 
                    return Age[index];
                }
                
            }
        }
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e[0, 1] = 3;
            e[2] = 1;
            Console.WriteLine(e[1]);
            Console.WriteLine(e[2]);

            Console.ReadLine();
        }
    }
}

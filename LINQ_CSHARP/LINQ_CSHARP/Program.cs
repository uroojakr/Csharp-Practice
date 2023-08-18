using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_CSHARP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //data source
            int[] scores = { 4, 64, 5, 12, 7 };

            //query expression
            IEnumerable<int> scoreQuery =
                from score in scores
                where score > 80
                select score;

            //execute query
            foreach(int i in scoreQuery)
            {
                Console.Write(i+" ");
            }

            //another example
            //data source
            int[] numbers = new int[7] { 0, 4, 22, 5, 34, 29,32 };

            //query expression
            var numQuery =
                from num in numbers
                where (num % 2 == 0)
                select num;

            //query execution
            foreach(var i  in numQuery)
            {
                Console.WriteLine(i);
            }

        }
    }
}

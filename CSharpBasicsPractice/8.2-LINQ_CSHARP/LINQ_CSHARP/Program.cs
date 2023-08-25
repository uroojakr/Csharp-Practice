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
                Console.WriteLine("{0,10}",i); //format specifier
            }

            //practice example
            IEnumerable<string> highScoresQuery = 
                from score in scores
                where score > 44
                orderby score descending
                select $"The score is {score}";

            //practice  example 2
            int highScoreCount = (
                from score in scores
                where score > 44
                select score
                ).Count();

            IEnumerable<int> queryMajority =
                scores.Where(c => c.Equals(64));
            if (queryMajority.Any())
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
            Console.WriteLine("High score count is {0}",highScoreCount);

            foreach (var i in  highScoresQuery)
            {
                Console.WriteLine(i);
            }

            string[] names = { "Urooj Akram", "Sana Rashid", "Maha Malik", "Sobia Khan" };
            IEnumerable<string> queryFirstName =
                from name in names
                let firstname = name.Split(' ')[0]
                where firstname !=""
                orderby firstname
                select firstname;

            foreach (string item in queryFirstName)
            {

                Console.WriteLine("First Names are: {0}", item);
            }
        }
    }
}

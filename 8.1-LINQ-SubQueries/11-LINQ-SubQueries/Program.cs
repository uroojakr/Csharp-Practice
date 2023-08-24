using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ_SUBQUERIES
{
    class Bouqet
    {
        public List<string> Flowers { get; set; }
    }
    //read only memory
    enum PlanetType
    {
        Rock,
        Ice,
        Gas,
        Liquid
    };

    record Planet(
        string name,
        PlanetType Type,
        int OrderFromSun
        )
    {
        public static readonly Planet Mercury =
            new(nameof(Mercury), PlanetType.Rock, 1);

        public static readonly Planet Venus =
            new(nameof(Venus), PlanetType.Rock, 2);

        public static readonly Planet Earth =
            new(nameof(Earth), PlanetType.Rock, 3);

        public static readonly Planet Mars =
            new(nameof(Mars), PlanetType.Rock, 4);

        public static readonly Planet Jupiter =
            new(nameof(Jupiter), PlanetType.Gas, 5);

        public static readonly Planet Saturn =
            new(nameof(Saturn), PlanetType.Gas, 6);

        public static readonly Planet Uranus =
            new(nameof(Uranus), PlanetType.Liquid, 7);

        public static readonly Planet Neptune =
            new(nameof(Neptune), PlanetType.Liquid, 8);

        // Yes, I know... not technically a planet anymore
        public static readonly Planet Pluto =
            new(nameof(Pluto), PlanetType.Ice, 9);
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers3 = new() { 1, 16, 4, 53, 12, 5, 6, 34 };

            IEnumerable<int> queryFactorofFour =
                from num in numbers3
                where num % 4 == 0
                select num;

            List<int> factorofFourList = queryFactorofFour.ToList();

            if (factorofFourList.Count > 2) // Ensure there are at least 3 elements
            {
                Console.WriteLine(factorofFourList[2]); // Access index 2
                factorofFourList[2] = 0; // Modify value at index 2
                Console.WriteLine(factorofFourList[2]); // Print modified value
            }
            else
            {
                Console.WriteLine("The list does not have enough elements.");
            }

          

            //Filtering Data
            string[] words = { "the", "quick", "brown", "fox", "Jumps" };

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;

            foreach(string word in query) 
            {
                Console.WriteLine(word);
            }

            //projection using select
            var query2 = from word in words
                         select word.Substring(0, 2);
                          

            foreach(string str in query2)
            {
                Console.WriteLine(str);
            }

            //zip
            IEnumerable<int> numbers = new[]
            {
                3,2,4,2,3,12
            };

            IEnumerable<char> letters = new[]
            {
                'A','F','G','Z'
            };

            foreach ((int number, char letter) in numbers.Zip(letters))
            {
                Console.WriteLine($"Number: {number} zipped with letter: {letter}");
            }

            List<Bouqet> bouqets = new List<Bouqet>()
            {
                    new Bouqet { Flowers = new List<string> { "sunflower", "daisy", "daffodil", "larkspur" }},
                    new Bouqet { Flowers = new List<string> { "tulip", "rose", "orchid" }},
                    new Bouqet { Flowers = new List<string> { "gladiolis", "lily", "snapdragon", "aster", "protea" }},
                    new Bouqet { Flowers = new List<string> { "larkspur", "lilac", "iris", "dahlia" }}
            };

            IEnumerable<List<string>> query3 = bouqets.Select(bq => bq.Flowers);

            IEnumerable<string> query4 = bouqets.SelectMany(bq => bq.Flowers);

            Console.WriteLine("Result for simple select");
            foreach(IEnumerable<String> bouqet in query3)
            {
                foreach(string item in  bouqet)
                { 
                    Console.WriteLine(item);
                }
                
            }


            Console.WriteLine("Result for simple SelectMany");

            foreach (string bouqet in query4)
            {
                Console.WriteLine(bouqet);
            }
            string[] planets = { "Mercury", "Venus", "Venus", "Earth", "Mars", "Earth" };

            IEnumerable<string> query5 = from planet in planets.Distinct()
                                         select planet;

            foreach(var str in query5)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();

            //set operations


        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryGenericCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("active", "meaning active");
            myDictionary.Add("passive", "meaning passive");
            myDictionary.Add("honest", "meaning honest");
            myDictionary.Add("amazing", "meaning amazing");


            string value;
            myDictionary.TryGetValue("amazing",out value);
           Console.WriteLine(value);

            Console.WriteLine(myDictionary["active"]);

            Console.WriteLine(myDictionary.Count);

            Employee emp1 = new Employee()
            {
                id = 223,
                name = "Ali",
                designation = "Manager",
                salary = 42323
            };

            Employee emp2 = new Employee()
            {
                id = 9223,
                name = "Sarah",
                designation = "Manager",
                salary = 42323
            };

            Employee emp3 = new Employee()
            {
                id = 2923,
                name = "Huma",
                designation = "Manager",
                salary = 42323
            };

            Dictionary<int,Employee> myEmployee = new Dictionary<int,Employee>();
            myEmployee.Add(emp1.id, emp1);
           myEmployee.Add(emp2.id, emp2);
            myEmployee.Add(emp3.id, emp3);

            Console.WriteLine(myEmployee.Count( emp => emp.Value.salary > 300 ));
            //or
            Console.WriteLine(myEmployee.Count(emp => emp.Value.name.StartsWith("H")));


            //foreach (KeyValuePair<string, string> pair in myDictionary)
            //{
            //    Console.WriteLine("Key is : "+pair.Key+" value is :"+ pair.Value);
            //}

            Console.ReadLine();
        }
    }
}

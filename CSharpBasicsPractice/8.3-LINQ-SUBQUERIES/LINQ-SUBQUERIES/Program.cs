using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LINQ_SUBQUERIES
{
    internal class Program
    {
       
     
        static void Main(string[] args)
        {
            List<Student> students = GetStudents();

            List<Student> GetStudents()
            {
                return new List<Student>
                {
                new Student {Name = "Hina", Score = 54},
                new Student {Name = "Urooj", Score = 65},
                new Student {Name = "Sana", Score = 97},
                new Student {Name = "Maria", Score = 87}
                };
            }

            double avgScore = students.Average(student => student.Score);
            DisplayAboveAvgStudents(students, avgScore);


            var aboveAvgStudents = from student in students
                                   where student.Score > avgScore
                                   select student;

            Console.WriteLine("Students with scores above average");
            foreach(var student in  aboveAvgStudents) 
            {
                Console.WriteLine($"{student.Name} : {student.Score}");
            }

            //method and query syntax

            int[] numbers = { 4, 6, 2, 6, 7 };


            //query syntax
            IEnumerable<int> numQuery1 =
                from num in numbers
                where num % 2 == 0
                orderby num
                select num;

            //method syntax
            IEnumerable<int> numQuery2 = numbers.Where( num => num % 2 == 0 ).OrderBy(num => num);

            foreach(int i in numQuery1)
            {
                Console.WriteLine(i + "");
            }

            Console.WriteLine(System.Environment.NewLine);

            foreach(int i in numQuery2)
            {
                Console.WriteLine( i + "");
            }

            List<int> numbers2 = new List<int>();
            numbers2.Add(4);
            numbers2.Add(6);
            numbers2.Add(65);
            numbers2.Add(21);
            numbers2.Add(87);
            numbers2.Add(43);


            //filtering query
            IEnumerable<int> filteringQuery =
                from num in numbers2
                where num < 33 || num >22
                select num;

            //ordering query
            IEnumerable<int> OrderingBy =
                from num in numbers2
                where num > 24 || num != 87
                select num;

            //grouping query
            string[] groupingQuery = { "Carrots", "Pasta", "Macaroni", "Beans", "Barley" };
            IEnumerable<IGrouping<char, string>> Groupingitems =
                from food in groupingQuery
                group food by food[0];

            foreach (var item in Groupingitems)
            {
                foreach (var key in item)
                {
                    Console.WriteLine(key);
                }
            }

            //anon type
            var person = new { Name = "uroooj", age = 23 };

            //new example
            string sentence = "The quick brown fox jumps over the Lazy Dog";
            string[] words = sentence.Split(' ');

            var query = from word in words
                        group word.ToUpper() by word.Length into gr
                        orderby gr.Key
                        select new { Length = gr.Key, word = gr };

            //method based query

            var query2 = words.
                GroupBy(w => w.Length, w => w.ToUpper()).
                Select(g => new { Length = g.Key, word = g }).
                OrderBy(o => o.Length);

            foreach(var obj in query)
            {
                Console.WriteLine("Words of length {0}, ",obj.Length);
                foreach(string word in obj.word)
                    Console.WriteLine(word);
            }

            //multiple inputs into one output using student class 

            //first data source
            List<Student> students1 = new List<Student>()
            {
                new Student
                {
                    FirstName="Urooj",
                    LastName = "Akram",
                    ID=54,
                    Street="43 Main Street",
                    City="KHI",
                    Score1 = new List<int> {8,9,9,9},
                },
                new Student
                {
                    FirstName="Sana",
                    LastName = "Khan",
                    ID=54,
                    Street="65 Street",
                    City="KHI",
                    Score1 = new List<int> {10,9,9,9},
                },
                new Student
                {
                    FirstName="Kiran",
                    LastName = "Rao",
                    ID=54,
                    Street="43 Main Street",
                    City="ISB",
                    Score1 = new List<int> {8,9,9,9},
                },
            };

            //second data source
            List<Teacher> teachers = new List<Teacher>()
            {
                new Teacher { FirstName = "Sana", LastName = "Khalid", ID= 44, City = "KHI"},
                new Teacher { FirstName = "Sara", LastName = "Khan", ID=32 , City = "ISB"},
                new Teacher { FirstName = "Maha", LastName = "Rao", ID= 65, City = "LHR"},
            };

            //create the query
            var PeopleInLHR = (from student in students1
                               where student.City.Equals("LHR")
                               select new
                               { 
                                    FirstName = student.FirstName, LastName = student.LastName,
                                   Id = student.ID
                               }
                               )
                              .Concat(from t in teachers
                                      where t.City.Equals("LHR")
                                      //select t.LastName);
                                      select new
                                      {
                                          FirstName = t.FirstName, LastName = t.LastName, Id = t.ID
                                      });

           Console.WriteLine("The following teachers live in LHR");
            foreach(var per in PeopleInLHR)
            {
                Console.WriteLine(per);
            }

            var IDRangeLessFifty = (from student in students1
                                    where student.ID < 50
                                    select new
                                    {
                                        ID = student.ID, Name = student.FirstName + " " + student.LastName, city = student.City
                                    }
                                    ).Concat(
                                    from t in teachers
                                    where t.ID < 50
                                    select new
                                    {
                                        ID = t.ID,
                                        Name = t.FirstName + " " + t.LastName,
                                        city = t.City
                                    }
                                    );
            Console.WriteLine("Following people have IDS in range <50 ");
            foreach (var idr in IDRangeLessFifty)
            {
                Console.WriteLine(idr);
            }

            //in-memory objects to xml

            //using data source in student list
            // creating query 
            var studentsToXML = new XElement("Root",
                from s1 in students1
                let scores = string.Join(",", s1.Score1)
                select new XElement("Student",
                   new XElement("First", s1.FirstName),
                   new XElement("Last", s1.LastName),
                   new XElement("Scores", scores)
                )
                );

            Console.WriteLine(studentsToXML);

            //operations on source element
            double[] radii = { 3, 2, 3 };

            //linq using method syntax
            IEnumerable<string> output =
                radii.Select(r => $"Area for circle with radii of '{r}' = {r * r * Math.PI:F2}");

            foreach(string s in output)
            {
                Console.WriteLine(s);
            }

            //execute without foreach
           

            //IEnumerable<int> queryFactorofFour = 
            //    from num in numbers
            //    where num % 4 == 0
            //    select num;

            //List<int> factorofFourList = queryFactorofFour.ToList();

            //Console.WriteLine(factorofFourList[2]);
            //factorofFourList[2] = 0;
            //Console.WriteLine(factorofFourList[2]);


            Console.WriteLine("--------------Using Query Method-----------------");
            var Query6 = students1.Where(s1 => s1.City.Equals("KHI")).Select(student => new { city = student.City, name = student.FirstName, ID = student.ID });
            
            foreach(var i in Query6 ) 
            {
                Console.WriteLine($"Name: {i.name}, ID: {i.ID}, City: {i.city}");
            }

            //Filtering
            var StudentsInKHI = students1.Where(s => s.City.Equals("KHI"));

            //projection
            var TeachersNames = teachers.Select(s => s.FirstName);

            //Sorting
            var sortedStudents = students1.OrderBy(s => s.LastName);

            //Aggregation - Count
            var TeacherCount = teachers.Count();

            //Aggregation - Average
            double averageScoreofStudents = students1.Average(s => s.Score1.Average());

            //Joining
            var CombiningData = students1.Join(
                teachers,student => student.FirstName,
                Teacher => Teacher.FirstName,
                (student, Teacher) => 
                (
                    studentName : student.FirstName,
                    teacherName : Teacher.LastName
                    )
                ) ;

            //grouping
            var teachrGroupBy = teachers.GroupBy(s => s.ID > 30);

            //any
            var HasISBStudents = students1.Any(s => s.City.Equals("ISB"));

            //All
            var allScoresAbove8 = students1.All(s => s.Score1.All(s2 => s2 > 5));

            //group join
            var GroupingTwoLists = students1.GroupJoin(teachers, student => student.City, teacher => teacher.City,(student, teacherGroup)=> new
            {
                StudentName = student.FirstName,
                TeachersInCity = teacherGroup.Select(teacher => teacher.FirstName)
            });

            DisplayGroupJoin(GroupingTwoLists);


            Console.WriteLine($"Teacher Count is {TeacherCount}");

            Console.WriteLine($"Avaerage Score is {averageScoreofStudents}");


            Console.WriteLine("---------------sorted students------------------");
            foreach (var student in sortedStudents ) 
            {
                Console.WriteLine($"{student.FirstName}, {student.ID}, {student.City}");
            }

            Console.WriteLine("-------------------Teachers Names--------------------");
            foreach (var teachernames in TeachersNames)
            {
                Console.WriteLine(teachernames);
            }

            Console.WriteLine("----------------------Combining Data---------------------");
            foreach(var data in CombiningData )
            {
                Console.WriteLine($"Teachers Name: {data.teacherName}, Students Name: {data.studentName}");
              
            }

            Console.WriteLine("------------------Group By-----------------------");
            foreach(var i in teachrGroupBy)
            {
                Console.WriteLine("Group");
                foreach(var j in i)
                {
                    Console.WriteLine($"{j.FirstName}, {j.LastName}, {j.City}, {j.ID}");
                }
            }
           

        }

        private static void DisplayGroupJoin(IEnumerable<dynamic> GroupingTwoLists)
        {
            Console.WriteLine("------------------Group Join-----------------------");
            foreach (var i in GroupingTwoLists)
            {
                Console.WriteLine($"{i.StudentName}");
                Console.WriteLine("Teachers in Same City");
                foreach (var j in i.TeachersInCity)
                {
                    Console.WriteLine($"{j}");
                }
                Console.WriteLine("----");
            }
        }

        private static void DisplayAboveAvgStudents(List<Student> students, double avgScore)
        {
            Console.WriteLine("Students with scores above average");
            var aboveAvgStudents = students.Where(student => student.Score > avgScore);

            foreach (var student in aboveAvgStudents)
            {
                Console.WriteLine($"{student.Name} : {student.Score}");
            }
        }
    }
}

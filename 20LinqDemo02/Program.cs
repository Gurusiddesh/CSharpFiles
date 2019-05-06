using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20LinqDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student{ Id=1,Name="Ram",Age=20,TotalMarks=250 },
                new Student{ Id=2,Name="Ravi",Age=21,TotalMarks=350 },
                new Student{ Id=3,Name="Raju",Age=22,TotalMarks=455 },
                new Student{ Id=4,Name="Ramya",Age=23,TotalMarks=490 },
                new Student{ Id=5,Name="Rakesh",Age=24,TotalMarks=550 },

            };
            //Deferred execution;
            students.Add(new Student() { Id = 6, Name = "Ratna", Age = 25, TotalMarks = 567 });

            var More_Than400 = from student in students
                               where student.TotalMarks >= 400
                               //where student.Age>20
                               select student;
            Console.WriteLine("Id\tName\tTotalMarks");

            foreach (var item in More_Than400)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}");
            }
           //immediate execution - The query executed immediatly;
            var More_Than400Count = (from student in students
                                       where student.TotalMarks >= 400
                                       //where student.Age>20
                                       select student).Count();
            students.Add(new Student() { Id = 7, Name = "Radha", Age = 25, TotalMarks = 585 });
            Console.WriteLine($"Number os students scored more than 400 marks is : {More_Than400Count}");

            IEnumerable<Student> orderbystudenttotalmarks = from student in students
                                                            orderby student.TotalMarks
                                                            select student;


            Console.WriteLine("Id\tName\tTotalMarks");

            foreach (var item in orderbystudenttotalmarks)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}");
            }

            IEnumerable<Student> orderbystudenttotalmarksdec = from student in students
                                                            orderby student.TotalMarks descending
                                                            select student;


            Console.WriteLine("Id\tName\tTotalMarks");

            foreach (var item in orderbystudenttotalmarksdec)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}");
            }

            var obj = new { Name = "Ramu" ,Age = 20 };//Annonymous Type object;
            Console.WriteLine($"Name:{obj.Name} Age:{obj.Age}");

            var only_Name_And_TotalMarks = from student in students
                                           select new { Name = student.Name, TotalMarks = student.TotalMarks };


            Console.WriteLine("Name\tTotalMarks");
            foreach (var item in only_Name_And_TotalMarks)
            {
                Console.WriteLine($"{item.Name}\t{item.TotalMarks}");
            }

        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
    }
}

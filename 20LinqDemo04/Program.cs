using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20LinqDemo04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>() {
                new Student{ Id=1,Name="Ram",Branch="CSE",TotalMarks=250 },
                new Student{ Id=2,Name="Ravi",Branch="ISE",TotalMarks=350 },
                new Student{ Id=3,Name="Raju",Branch="ECE",TotalMarks=455 },
                new Student{ Id=4,Name="Ramya",Branch="EEE",TotalMarks=490 },
                new Student{ Id=5,Name="Rakesh",Branch="CIVIL",TotalMarks=550 },
                new Student{ Id=6,Name="Ratna",Branch="MECH",TotalMarks=590 },
                new Student{ Id=7,Name="Rajesh",Branch="CIVIL",TotalMarks=580 },

            };

            var obj = students.Where(student => student.TotalMarks >= 400).ToList();
            foreach (var item in obj)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}\t{item.Branch}");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Student details on Order by of Total Marks");
            var orderbytrial = students.OrderBy(student => student.TotalMarks).ToList();
            foreach (var item in orderbytrial)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}\t{item.Branch}");
            }

            Console.WriteLine("--------------");
            Console.WriteLine("Student details on Descending Order by  of Total Marks");
            var orderbytrial1 = students.OrderByDescending(student => student.TotalMarks).ToList();
            foreach (var item in orderbytrial1)
            {
                Console.WriteLine($"{item.Id}\t{item.Name}\t{item.TotalMarks}\t{item.Branch}");
            }
        }
    }
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Branch { get; set; }
        public int TotalMarks { get; set; }
    }
}

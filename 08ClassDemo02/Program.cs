using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ClassDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.GetDetails();
            p1.PrintDetails();

            Person p2 = new Person();
            p2.GetDetails();
            p2.PrintDetails();
        }
    }

    class Person
    {
        private string Name;
        private int Age;

        public void GetDetails()
        {
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Age");
            Age = int.Parse(Console.ReadLine());
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{Name} is from Bangalore");
            Console.WriteLine($"Age is {Age}");
        }
    }
}

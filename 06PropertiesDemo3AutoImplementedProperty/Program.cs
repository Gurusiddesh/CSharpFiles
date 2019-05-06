using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06PropertiesDemo3AutoImplementedProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 100;
            s.Name = "Guru";
            s.City = "Bangalore";
            Console.WriteLine($"Id: {s.Id} Name:{s.Name} City{s.City}");
        }
    }
    class Student      //POCO class:plain old CLR Objects
    {
        //Auto implemented Property
        public int Id{get; set;}
        public string Name { get; set; }
        public string City { get; set; }
    }
}

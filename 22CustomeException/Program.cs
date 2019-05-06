using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22CustomeException
{
    class Program
    {

        static void Main(string[] args)
        {
            Student s = new Student() { Name = "Ram", Age = -22 };
            try
            {
                ValidateAge(s.Age);
            }
            catch(InvalidAgeException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.WriteLine($"Name is :{s.Name} and Age is:{s.Age}");
        }

        public static void ValidateAge(int age)
        {
            if (age<=0)
            {
                throw new InvalidAgeException();
            }
        }
    }
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class InvalidAgeException: Exception
    {
        public InvalidAgeException():base ("Invalid Age")
        {
           
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09ConstructorsDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d1 = new Demo();
            Console.WriteLine(d1.n);
            Console.WriteLine(d1.name);

            Demo d2 = new Demo(50,"sita");
            Console.WriteLine(d2.n);
            Console.WriteLine(d2.name);

            Demo d3 = new Demo(d2);
            Console.WriteLine(d3.n);
            Console.WriteLine(d3.name);
        }
    }

    class Demo
    {
        public int n;
        public string name;

        public Demo()
        {
            Console.WriteLine("Default Constructor");
            n = 10;
            name = "Ram";
        }

        public Demo(int num, string n1)
        {
            Console.WriteLine("Parameterised Constructor");
            n = num;
            name = n1;
        }

        public Demo(Demo d)
        {
            Console.WriteLine("Copy Constructor");
            n = d.n;
            name = d.name;
        }
    }
}

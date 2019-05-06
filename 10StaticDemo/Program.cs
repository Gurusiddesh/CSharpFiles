using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10StaticDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo.PrintCounter();

            Demo d1 = new Demo();
            d1.PrintN();

            Demo.PrintCounter();

            Demo d2 = new Demo();
            d2.PrintN();

            Demo.PrintCounter();

            //StaticExample se = new StaticExample();  cannot create obj of static class. If we create its of no use bcoz of absense of instance method

        }
    }
    class Demo
    {
        public static int counter;
        public int n;

        static Demo()
        {
            Console.WriteLine("Static Constructor");
            counter = 0;
        }

        public Demo()
        {
            counter++;
        }

        public static void PrintCounter()
        {
            Console.WriteLine($"Counter : {counter}");
        }

        public void PrintN()
        {
            Console.WriteLine($"n : {n}");
        }
    
    }

    // Making class as static using static keyword, bcoz not allowing any one to create object of static class
    static class StaticExample
    {
        public static int x;
        public static void Print()
        {

        }

    }
}

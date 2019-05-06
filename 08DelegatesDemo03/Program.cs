using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DelegatesDemo03
{
    class Program
    {
        delegate void Example();
        static void Main(string[] args)
        {
            Demo d = new Demo();
            Example e = new Example(d.Print);
            e += d.Output;
            e += Demo.Display;
            e += Show;
            e += d.Output;
            e -= Demo.Display;
            e += d.Print;
            e();

            Console.WriteLine("----------");
            e -= d.Print;
            e();
        }

        public static void Show()
        {
            Console.WriteLine("Show Method");
        }
    }

    class Demo
    {
        
        public void Print()
        {
            Console.WriteLine("Print Method");
        }
        public void Output()
        {
            Console.WriteLine("Output Method");
        }

        public static void Display()
        {
            Console.WriteLine("Display Method");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17InterfacesDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.Print();
            d.Display();

            IPrint p = new Demo();
            p.Print();
        }
    }

    interface IPrint
    {
        void Print();
    }

    class Demo:IPrint
    {
        public void Print()
        {
            Console.WriteLine("Print Method");
        }

        public void Display()
        {
            Console.WriteLine("Display Method");
        }
    }
}

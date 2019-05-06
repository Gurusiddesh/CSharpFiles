using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.Print();

            B b = new B();
            b.Display();
            b.Print();

            C c = new C();
            c.Display();
            c.Print();
            c.Show();

            D d = new D();
            d.Display();
            d.Print();
            d.Output();
           
        }
    }

    class A
    {
        public void Print()
        {
            Console.WriteLine("Print Method ");
        }
    }

    class B:A
    {
        public void Display()
        {
            Console.WriteLine("Diplay Method ");
        }
    }

    class C:B
    {
        public void Show()
        {
            Console.WriteLine("Show method");
        }

    }

    class D:B
    {
        public void Output()
        {
            Console.WriteLine("Output Method");
        }
    }
}

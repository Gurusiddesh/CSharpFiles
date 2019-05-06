using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02SealedMethod
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class A
    {
        public virtual void Display()
        {
            Console.WriteLine("Display of A");
        }
    }

    class B:A
    {
        public sealed override void Display() //sealed method;
        {
            Console.WriteLine("Display of A");
        }
    }

    class C:B
    {
        public override void Display() //sealed method cannot overide in derived class;
        {
            Console.WriteLine("Display of A");
        }
    }

}

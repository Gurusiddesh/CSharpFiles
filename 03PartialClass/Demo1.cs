using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PartialClass
{
    partial class Demo
    {
        partial void Output();
        public void Display()
        {
            Console.WriteLine("Display Method");
            Output();
        }
    }
}

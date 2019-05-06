using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PartialClass
{
    partial class Demo
    {
        public void Print()  
        {
            Console.WriteLine("Print Method");
        }
        partial void Output()
        {
            Console.WriteLine("Output method");

        }
    }
}

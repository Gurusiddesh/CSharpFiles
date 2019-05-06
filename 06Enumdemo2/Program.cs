using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Enumdemo2
{
    enum Branch:byte //memory useage;
    {
        Mech =100,//customize values;
        CS=200,
        ISE,
        Auto
    }
    class Program
    {
        static void Main(string[] args)
        {
            Branch branch = Branch.CS;
            Console.WriteLine((int)branch);
        }
    }
}

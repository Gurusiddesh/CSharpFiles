using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07EnumsDemo1
{
    //enums are grouped interger constants; used for better readability;
    enum Branch
    {
        Mech,
        Cs,
        ISE,
        EEE
    }
    class Program
    {
        static void Main(string[] args)
        {
            Branch branch = Branch.Cs;
            Console.WriteLine((int)branch);
        }
    }
}

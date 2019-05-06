using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11PrivateConstrutorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoP.objectname.PrintN();
            DemoP.objectname.IncrementN();
            DemoP.objectname.PrintN();
            DemoP.objectname.IncrementN();
            DemoP.objectname.PrintN();
            DemoP.objectname.IncrementN();
            DemoP.objectname.PrintN();
        }
    }

    class DemoP
    {
        public static DemoP objectname= new DemoP();
        private int n;
        private DemoP()
        {
            n = 10;
            Console.WriteLine("Private Constructor");
        }

        public void PrintN()
        {
            Console.WriteLine($"n : {n}");
        }

        public void IncrementN()
        {
            n++;
        }
    }
}

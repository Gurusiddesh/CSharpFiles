using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DelegatesDemo01
{
    class Program
    {
        delegate int Calcultor(int a, int b);
        static void Main(string[] args)
        {
            Calcultor c = new Calcultor(Add);
            Console.WriteLine(c(10, 20));
            c = Multiply;
            Console.WriteLine(c(10,20));
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a* b;
        }
    }
}

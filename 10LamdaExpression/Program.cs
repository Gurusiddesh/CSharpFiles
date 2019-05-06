using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10LamdaExpression
{
    class Program
    {
        delegate int Add(int a, int b);
        static void Main(string[] args)
        {
            Add fun = delegate (int n1, int n2) { return n1 + n2; };
            Add fun1 = (int n1, int n2) => { return n1 + n2; };
            Add fun2 = (n1, n2) => {return n1 + n2; };
            Add fun3 = (n1, n2) => n1 + n2;
            Console.WriteLine(fun(10,20));
            Console.WriteLine(fun1(20, 20));
            Console.WriteLine(fun2(30, 20));
            Console.WriteLine(fun3(40, 20));
        }
    }
}

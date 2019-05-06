using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14CompileTimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10,20));
            Console.WriteLine(Add(10,20,30));
            Console.WriteLine(Add("hello","world"));
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Add(int a, int b , int c)
        {
            return a + b + c;
        }
        public static string Add(string a,string b)
        {
            return a + b;
        }
    }
}

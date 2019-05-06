using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Functin2demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers for addition");
            int num1, num2;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            int sum = Add(num1, num2);
            Console.WriteLine(sum);
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}

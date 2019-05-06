using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05RecursiveFunctiondemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the factorial number");
            int num = int.Parse(Console.ReadLine());
            int result = Factorial(num);
            Console.WriteLine("Factorial of " +num + " is " +result);
        }
        public static int Factorial(int n)
        {
            if (n == 1)
                return 1;
            return n * Factorial(n - 1);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CallByReferencedemoSwap6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of a and b");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before function call a = {a} and b = {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After function call a = {a} and b = {b}");
        }

        public static void Swap(ref int m, ref int n)
        {
            int temp = m;
            m = n;
            n = temp;
            Console.WriteLine($"Within function call m ={m} and n = {n}");
        }
    }
}

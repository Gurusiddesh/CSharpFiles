using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 20;
            Console.WriteLine($"Before Swap a= {a} and b={b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After Swap a={a} and b={b}");

            float m = 10.12f, n = 20;
            Console.WriteLine($"Before Swap m= {m} and n={n}");
            Swap(ref m, ref n);
            Console.WriteLine($"After Swap m={m} and n={n}");
        }
        public static void Swap<T>(ref T a,ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }
    }
}

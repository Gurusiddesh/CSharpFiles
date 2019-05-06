using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
            // Action is a Generic Delegate which takes upto 16 parameters; and does not return anything its used for void;
        {
            Action d1 = delegate () {
                Console.WriteLine("Ankpro");
            };
            d1();

            Action<string> d2 = delegate (string s) {
                Console.WriteLine(s);
            };
            d2("Hello");

            Action<int> d3 = delegate (int a) {
                Console.WriteLine(a);
            };
            d3(10);

            Func<int, int> f1 = (x) => x * x; //any return type;
            Console.WriteLine(f1(4));

            Func<int, int, int> f2 = (x, y) => x + y;
            Console.WriteLine(f2(10,20));

            Func<int, int, int, float> f3 = (p, t, r) => (p * t * r) / 100;
            Console.WriteLine(f3(1000,2,2));

            Predicate<int> isEven = (n) => n % 2 == 0; //use only when return type is bool;
            Console.WriteLine(isEven(10));

            Predicate<int> isPositive = (num) => num >= 0;
            Console.WriteLine(isPositive(-1));


        }
    }
}

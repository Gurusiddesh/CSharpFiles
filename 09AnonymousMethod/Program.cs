using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09AnonymousMethod
{
    class Program
    {
        delegate void Demo();
        delegate int Cal(int a, int b);
        static void Main(string[] args)
        {
            Demo d = delegate () {
                Console.WriteLine("Anonymous Method");
            };
            d();
            Cal c = delegate (int a, int b) {
                return a + b;
            };
            Console.WriteLine(c(10, 20)); 
        }
    }
}

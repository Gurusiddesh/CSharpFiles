using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ParamsDemo6
{
    class Program
    {
        static void Main(string[] args)
        {
            int addition = Add(10, 20,30);
            Console.WriteLine(addition);
        }

        public static int Add(params int[] numbers)
        {
            int total = 0;
            foreach (var i in numbers)
            {
                total = total + i;

            }
            return total;
        }
    }
}

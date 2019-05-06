using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Linq- language integrated query;
// its returns collections in the form of objects;


namespace _20LINQDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 10, 20, 30, 5, 4, -3, -2, 6, 9, 0 };

            Console.WriteLine("All Numbers");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Positive numbers");
            var q = from n in numbers
                    where n >= 0
                    where n%2==0
                    select n;

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }
        }
    }
}

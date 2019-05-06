using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18GenericCOllections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            numbers.Add(10);
            numbers.Add(20);
            numbers.Add(30);
            numbers.Add(-10);
            numbers.Add(-29);
            Console.WriteLine(numbers.Count);

            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("--------");
            numbers.Remove(20);
            Console.WriteLine() ;
            Console.WriteLine(numbers.Count);
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-----------");
            numbers.RemoveAll(n=> n <= 0);

            Console.WriteLine($"Count After Removeall{numbers.Count}");
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }


        }
    }
}

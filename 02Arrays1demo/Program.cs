using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02Arrays1demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] city_names = new string[5];
            Console.WriteLine("enter the 5 city names");
            for (int i = 0; i < 5; i++)
                city_names[i] = Console.ReadLine();
            Console.WriteLine("the entered city_names are...\n");
            for(int i=0; i<5; i++)
                Console.WriteLine(city_names[i]);
        }
    }
}

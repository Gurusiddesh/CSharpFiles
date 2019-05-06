using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CallByReferencedemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 50;
            Modify(ref a, out b);//both ref and out are call by refernce method 
            Console.WriteLine(a);
            Console.WriteLine(b);
        }

        public static void Modify(ref int m, out int n) //ref means optional and out means mandatory with = sign to variables
        {
            //m =20;
            n = 100;
        }
    }
}

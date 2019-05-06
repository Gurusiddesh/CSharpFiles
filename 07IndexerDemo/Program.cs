using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07IndexerDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d[0] = 10;
            d[1] = 20;
            d[2] = 30;
            d[3] = -40;  
            d[4] = 50;
            
            Console.WriteLine("Numbers of array");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }
    class Demo
    {
        private int[] numbers = new int[5];
        public int this[int i]
        {
            set
            {
                if(value>=0)
                numbers[i] = value;
            }
            get { return numbers[i]; }
        }
    }
}

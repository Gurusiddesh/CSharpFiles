using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            
            Console.WriteLine(d.Num);
            d.Num = 20;
        }
    }

    class Demo
    {
        private int num=10;

        public int Num
        {
            
            set { num = value; }
            get { return num; }
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08DelegatesDemo02
{
    delegate void Demo();
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Demo d = new Demo(c.GetRadius);
            //d();

            d+= c.ShowArea;
            d();
        }
    }
    class Circle
    {
        private int radius;

        public void GetRadius()
        {
            Console.WriteLine("Enter Radius");
            radius = int.Parse(Console.ReadLine());

        }
        public void ShowArea()
        {
            float area = 3.14f * radius * radius;
            Console.WriteLine(area);
        }
    }
}

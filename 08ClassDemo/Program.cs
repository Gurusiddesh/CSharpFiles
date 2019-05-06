using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.GetRadius();
            c1.Area();

            Circle c2 = new Circle();
            c2.GetRadius();
            c2.Area();

            Circle c4= new Circle();
            c4.GetRadius();
            c4.Area();
        }
    }
    class Circle
    {
        private int Radius;

        public void GetRadius()
        {
            Console.WriteLine("Enter Radius");
            Radius = int.Parse(Console.ReadLine());
        }

        public void Area()
        {
            double AreaOfCircle = 3.14f * Radius * Radius;
            Console.WriteLine($"Area Of The Circle is {AreaOfCircle}");
        }
    }
}

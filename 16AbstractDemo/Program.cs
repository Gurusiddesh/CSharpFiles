using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16AbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer1 = new LaserJet();
            printer1.Print();
            Printer printer2 = new InkJet();
            printer2.Print();
            Printer printer3 = new DotMtrix();
            printer3.Print();

            Animal a1 = new Mammals();
            a1.Move();
            Animal a2 = new Reptiles();
            a2.Move();
            Animal a3 = new Birds();
            a3.Move();
        }
    }

    abstract class Printer
    {
        public abstract void Print();

    }

    class LaserJet : Printer
    {
        public override void Print()
        {
            Console.WriteLine("LaserJet Printer");
        }

    }

    class InkJet : Printer
    {
        public override void Print()
        {
            Console.WriteLine("InkJet Printer");
        }

    }

    class DotMtrix : Printer
    {
        public override void Print()
        {
            Console.WriteLine("DotMatrix Printer");
        }

    }

    abstract class Animal
    {
        public abstract void Move();
    }
    class Mammals : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Mammals Move by walking and running");
        }
    }

    class Reptiles : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Reptiles Move by crawling");
        }
    }


    class Birds : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Birds Move by flying");
        }
    }

 }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15RunTimePolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal a = new Animal();
            //a.Move();
            //Mammals m = new Mammals();
            //m.Move();
            //Birds b = new Birds();
            //b.Move();

            Animal a;
            a = new Animal();
            a.Move();
            a= new Mammals();
            a.Move();
            a = new Birds();
            a.Move();
            a = new Reptiles();
            a.Move();
        }
    }

    class Animal
    {
        public virtual void Move()
        {
            Console.WriteLine("Animals Move");
        }
    }
    class Mammals:Animal
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
        
    }
}

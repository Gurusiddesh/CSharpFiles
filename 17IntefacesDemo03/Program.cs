using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17IntefacesDemo03
{
    class Program
    {
        static void Main(string[] args)
        {
            IExtracurricularActivities activities = new Student();
            activities.dace();
            activities.Karate();
            activities.Rangoli();
            activities.Sing();
        }
    }
    interface IDance
    {
        void dace();
    }
    interface ISing
    {
        void Sing();
    }
    interface IKarate
    {
        void Karate();
    }
    interface IExtracurricularActivities:IDance,ISing,IKarate
    {
        void Rangoli();
    }
    class Student : IExtracurricularActivities
    {
        public void dace()
        {
            Console.WriteLine("Dance");
        }

        public void Karate()
        {
            Console.WriteLine("Karate");
        }

        public void Rangoli()
        {
            Console.WriteLine("Rangoli");
        }

        public void Sing()
        {
            Console.WriteLine("Sing");
        }
    }
}

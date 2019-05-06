using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05NamedAndDefaultParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(CalculateSI(1000, 2, 2)); //Common method
            //Console.WriteLine(CalculateSI(1000,2));//Default Parameters
            Console.WriteLine("Enter time and Principle Amount");
            int Time = int.Parse(Console.ReadLine());
            int PrincipleAmt = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateSI( principleAmount: PrincipleAmt, time: Time, rateOfInterest: 2));//User Input
            //Console.WriteLine(CalculateSI(time: 2, principleAmount: 2000, rateOfInterest: 2));//Named Parameters Eg
        }

        public static double CalculateSI(int principleAmount, int time, int rateOfInterest=2)//Default Parameters Value roi
        {
            double si = (principleAmount * time * rateOfInterest) / 100;
            return si;
        }
    }
}

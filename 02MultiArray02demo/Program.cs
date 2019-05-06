using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02MultiArray02demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
            Console.WriteLine("enter 9 numbers");
            for (int row = 0; row < 3; row++)
            
                for (int column = 0; column < 3; column++)
                
                    numbers[row, column] = int.Parse(Console.ReadLine());
                
            
            Console.WriteLine("entered numbers are");
            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)

                    Console.Write(numbers[row, column]+"\t");
                Console.WriteLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04JaggedArraydemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[4][];
            jagged[0] = new int[3];
            jagged[1] = new int[1];
            jagged[2] = new int[2];
            jagged[3] = new int[4];

            Console.WriteLine("Enter 3 numbers for 0th row");
            for (int i = 0; i < 3; i++)
                jagged[0][i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 1 number for 1st row");
            for (int i = 0; i < 1; i++)
                jagged[1][i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 2 numbers for 2nd row");
            for (int i = 0; i < 2; i++)
                jagged[2][i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter 4 numbers for 3rd row");
            for (int i = 0; i < 4; i++)
                jagged[3][i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Jaged array ");
            for (int i = 0; i < 3; i++)
                Console.Write(jagged[0][i] + "\t");
                Console.WriteLine();
            

            for (int i = 0; i < 1; i++)
            
                Console.Write(jagged[1][i]+"\t");
                Console.WriteLine();
            

            for (int i = 0; i < 2; i++)
            
                Console.Write(jagged[2][i]+"\t");
               Console.WriteLine();
            

            for (int i = 0; i < 4; i++)
            
                Console.Write(jagged[3][i]+"\t");
               Console.WriteLine();
        }
    }
}

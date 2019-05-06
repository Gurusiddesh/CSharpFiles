using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ArrayAdditiondemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers1 = new int[3, 3];
            int[,] numbers2 = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("enter first array numbers");
            for (int row = 0; row < 3; row++)
            
                for (int column = 0; column < 3; column++)
                
                    numbers1[row, column] = int.Parse(Console.ReadLine());

            Console.WriteLine("enter second array numbers");
            for (int row = 0; row < 3; row++)
            
                for (int column = 0; column < 3; column++)

                    numbers2[row, column] = int.Parse(Console.ReadLine());

            for (int row = 0; row < 3; row++)

                for (int column = 0; column < 3; column++)

                    sum[row, column] = numbers1[row, column] + numbers2[row, column];

            Console.WriteLine("the sum is ");
            for (int row = 0; row < 3; row++)
            { 
                for (int column = 0; column < 3; column++)
                
                    Console.Write(sum[row, column] + "\t");
                Console.WriteLine();
            }
                
            

   


        }
    }
}

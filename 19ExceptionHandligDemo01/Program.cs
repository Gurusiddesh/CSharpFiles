using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ExceptionHandligDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[2] { 2, 4 };
            try
            {
                Console.WriteLine(arr[1]/arr[0]);
                Console.WriteLine(arr[1]);
                throw new Exception();
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("We Are in Divide By Zero Exception");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");
            }
            Console.WriteLine("Program Executed Normally");
        }
    }
}

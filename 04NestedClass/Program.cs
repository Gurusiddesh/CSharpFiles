using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04NestedClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Outside.Inside inside = new Outside.Inside();
            inside.Print();

            Outside o = new Outside();
            o.Display();
        }

        class Outside
        {
            private void Output()
            {
                Console.WriteLine("Private Method of Outside Class");
            }
            //Inside i = new Inside();// we can call Inside class method in Outside class by creating its obj;
            public void Display()
            {
                Console.WriteLine("Outside class Method");
               // i.Print();
            }

           public class Inside
            {
                Outside outside = new Outside();
                
                
                public void Print()
                {
                    Console.WriteLine("Inside Class Method");
                    //Outside outside = new Outside();
                    outside.Output();// we can access private method of Outside class in Inside class;
                }
            }
        }
    }
}

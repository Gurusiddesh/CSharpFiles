using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Structuresdemo3
{
    class Program
    {
        public struct Book
        {
            public int Price;
            public int Number_Of_Pages;
            public string Title;
            public string Author;
        }
        public static void Print(Book b2)
        {
            Console.WriteLine($"Author {b2.Author} Title{b2.Title} Price{b2.Price} Pages{b2.Number_Of_Pages}");
        }
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Price = 200;
            b1.Number_Of_Pages = 300;
            b1.Author = "Balguru Swamy";
            b1.Title = "Ansi C";
            Print(b1);

        }

       

    }
}

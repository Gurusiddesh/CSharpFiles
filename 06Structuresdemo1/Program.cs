using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Structuresdemo1
{
    class Program
    {
        struct Book
        {
            public int Price;
            public string Author;
            public string Title;
            public int Number_Of_Pages;
        }
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.Author = "Balaguru swamy";
            b1.Title = "Ansi C";
            b1.Price = 250;
            b1.Number_Of_Pages = 300;

            Console.WriteLine($"Title {b1.Title} ");
            Console.WriteLine($"Author {b1.Author}");
            Console.WriteLine($"Price {b1.Price}");
            Console.WriteLine($"Number of Pages {b1.Number_Of_Pages}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Structuresdemo2
{
    class Program
    {
        struct Book
        {
            public int Price;
            public string Author;
            public int Number_Of_Pages;
            public string Title;
        }
        static void Main(string[] args)
        {
            Book[] books = new Book[4];

            Console.WriteLine("Enter Book Details");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Title");
                books[i].Title = Console.ReadLine();

                Console.WriteLine("Author");
                books[i].Author = Console.ReadLine();

                Console.WriteLine("Price");
                books[i].Price = int.Parse(Console.ReadLine());

                Console.WriteLine("Number Of Pages");
                books[i].Number_Of_Pages = int.Parse(Console.ReadLine());

                if (i<3)
                {
                    Console.WriteLine("Enter next Book Details");
                }
                
            }

            Console.WriteLine("Details of Books");
            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}\t {book.Author}\t{book.Price}\t{book.Number_Of_Pages}");
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21AttributesDemo
{
    [Author("Aru")]
    class Program
    {
        [Author("Guru")]
        static void Main(string[] args)
        {
            int sum = Add(10, 20);
            Console.WriteLine(sum);
        }
        [Obsolete(message:"Addition",error:true)]
        public static int Add(int a, int b)
        {
            return a + b;
        }
        
    }
    [System.AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    sealed class AuthorAttribute : Attribute
    {
        public AuthorAttribute(string author)
        {
            Author = author;
        }
        public string Author { get; set; }
    }
}

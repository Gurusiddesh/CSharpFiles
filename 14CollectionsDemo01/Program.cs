using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14CollectionsDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arraylist = new ArrayList();
            ArrayList l1 = new ArrayList() { 10, 20, 'A', "NewArraylist" };
            Console.WriteLine($"Number of elements in arraylist is {arraylist.Count}");
            arraylist.Add(10);
            arraylist.Add("Hello");
            arraylist.Add(true);
            arraylist.Add(10.23f);
            arraylist.Add("String");
            arraylist.Add(1002);
            arraylist.Insert(2, "New");
            Console.WriteLine($"Number of elements in arraylist before removing is {arraylist.Count}");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }
            arraylist.Remove("Hello");
            
            arraylist.AddRange(l1);
            arraylist.InsertRange(3, l1);
            arraylist.RemoveAt(3);
            arraylist.RemoveRange(3, 4);
            Console.WriteLine("--------");
            Console.WriteLine(arraylist.Contains("New"));
            Console.WriteLine(arraylist.Contains(1000));



            Console.WriteLine($"Number of elements in arraylist after removing is {arraylist.Count}");
            foreach (var item in arraylist)
            {
                Console.WriteLine(item);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18GenericCollectionSortedListDemo03
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(10, "Hello");
            sl.Add(20, "Thankyou");
            sl.Add(40, "Bye");
            sl.Add(30, "Hiiii");

            Console.WriteLine("Count of elements"+sl.Count);
            foreach (KeyValuePair<int, string> item in sl)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);
            }

            Console.WriteLine("---------");
            sl.Remove(20);
            Console.WriteLine("Count of elements" + sl.Count);
            foreach (KeyValuePair<int, string> item in sl)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

        }


    }
}

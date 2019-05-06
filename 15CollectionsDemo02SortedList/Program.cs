using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15CollectionsDemo02SortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList s1 = new SortedList();
            s1.Add(17, "Davangere");
            s1.Add(16, "Chitradurga");
            s1.Add(04, "Bangalore");
            s1.Add(28, "Vijaypur");
            s1.Add(32, "Kalaburgi");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }
            Console.WriteLine("--------------");
            s1.Remove(16);

            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key +"\t"+item.Value);
            }

            Console.WriteLine(s1.Contains(17));
            Console.WriteLine(s1.Contains(16));
            Console.WriteLine(s1.ContainsValue(17));
            Console.WriteLine(s1.ContainsValue("Vijaypur"));
            s1.RemoveAt(1);
            Console.WriteLine("--------------");
            foreach (DictionaryEntry item in s1)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }


        }
    }
}

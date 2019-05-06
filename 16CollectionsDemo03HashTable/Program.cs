using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16CollectionsDemo03HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2,"Two");
            ht.Add(3, "Three");
            ht.Add(4, "Four");
            //ht.Add(4, "Five");  no duplicate in Hashtable;

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key+ "\t" + item.Value);
            }
        }
    }
}

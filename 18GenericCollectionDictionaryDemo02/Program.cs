using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18GenericCollectionDictionaryDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> rto = new Dictionary<int, string>();
            rto.Add(17, "Davangere");
            rto.Add(16, "Chitradurg");
            rto.Add(28,"Bijapur");
            rto.Add(32, "Kalburgi");
            Console.WriteLine($"Count Of Item in Dictionary {rto.Count}");
            foreach (KeyValuePair<int, string> item in rto)
            {
                Console.WriteLine(item.Key+"\t"+ item.Value);
            }

            Console.WriteLine("-----------");
            rto.Remove(16);
            rto.Reverse();

            Console.WriteLine($"Count Of Item in Dictionary {rto.Count}");
            foreach (KeyValuePair<int, string> item in rto)
            {
                Console.WriteLine(item.Key + "\t" + item.Value);
            }

        }
    }
}

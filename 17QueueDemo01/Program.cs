using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17QueueDemo01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue("String");
            q.Enqueue('A');
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            q.Dequeue();
            Console.WriteLine("-------");
            Console.WriteLine(q.Count);
            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("-------Stack demo-------");
            Stack s = new Stack();
            s.Push(10);
            s.Push("String");
            s.Push('A');
            Console.WriteLine(s.Count);

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_______POP DEMO______");
            s.Pop();
            s.Pop();
            Console.WriteLine(s.Count);
            foreach (var item in s)
            {
                Console.WriteLine(item);
            }

        }
    }
}

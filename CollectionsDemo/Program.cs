using System;
using System.Collections;
namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // collections allow you to store multiple elements
            //Collection is a general term
            // classes that we use are
            // ArrayList > allows insertion deletion anywhere
            // stack >LIFO 
            // queue >FIFO
            // HashTable > which uses <key,value>
            // collections are dynamic, no memory is wasted
            ArrayList list = new ArrayList();
            // gives you inbuild methods
            list.Add(1);   // boxing happening here
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add("ajay");
            list.Add(10.8);
            //for(int i=0;i<list.Count; i++)
            //    Console.WriteLine(list[i]);
            foreach (var x in list)     // unboxing happening here
            {
               // x = 100;
                Console.WriteLine(x);
            }
            list.Insert(1, 100);
            Console.WriteLine("after inserting 100 ");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            list.RemoveAt(0);
            Console.WriteLine("after deleting from index 0 ");
            for (int i = 0; i < list.Count; i++)
                Console.WriteLine(list[i]);
            list.Remove(100);
            Console.WriteLine("after deleting element 100 ");
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = 100;
                Console.WriteLine(list[i]);
            }
            // LIFO
            Stack stack = new Stack();
            stack.Push(100);
            stack.Push(200);
            stack.Push(300);
            stack.Push("karan");
            stack.Push(10.8);
            Console.WriteLine("stack elements ");

            foreach (var i in stack)
                Console.WriteLine(i);


            stack.Pop();
            Console.WriteLine("stack elements after deletion ");

            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }

            // FIFO
            Queue queue = new Queue();
            queue.Enqueue(1000);
            queue.Enqueue(2000);
            queue.Enqueue(3000);
            Console.WriteLine("queue elements ");

            foreach (int i in queue)
                Console.WriteLine(i);

            queue.Dequeue();

            Console.WriteLine("queue elements after deletion ");

            foreach (int i in queue)
                Console.WriteLine(i);

            Hashtable ht = new Hashtable();
            ht[100] = "ajay";
            ht[101] = "deepak";
            ht["deepak"] = 10;
            foreach (var i in ht.Keys)
            {
                Console.WriteLine(i + " " + ht[i]);
            }
        }

    }
}

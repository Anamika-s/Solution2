using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    internal class NonGenericCollections
    {
        static void Main()
        {
           // Generic collection are collections but type-safe
           // ArrayList > List<type>
           // Stack > Stack<type>

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            foreach(int i in list)
                Console.WriteLine(i);
        
          Stack<string> stack = new Stack<string>();
            stack.Push("aaa");

            foreach (string i in stack)
                Console.WriteLine(i);


            Queue<float>    queue = new Queue<float>();
            queue.Enqueue(100.7f);
            foreach (float i in queue)
                Console.WriteLine(i);
            Dictionary<int, string> names = new Dictionary<int, string>();
            names[10] = "jatin";











        }



    }
}

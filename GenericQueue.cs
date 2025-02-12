using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class GenericQueue
    {
        public void InsertInGenericQueue()
        {
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("This");
            queue.Enqueue("is");
            queue.Enqueue("mumbai");
            queue.Enqueue("pune");

            Console.WriteLine("After Enqueue to Queue = ");
            foreach (string ele in queue)
            {
                Console.WriteLine(ele);
            }
            queue.Dequeue();
            Console.WriteLine("After Enqueue to Queue = ");
            foreach (string ele in queue)
            {
                Console.WriteLine(ele);
            }
        }
    }
}

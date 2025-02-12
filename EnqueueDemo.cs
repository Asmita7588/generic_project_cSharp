using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class EnqueueDemo
    {
        public void insertIntoQueue()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            Console.WriteLine("Enqueue To QUeue : ");

            foreach (Object ele in q)
            {
                Console.WriteLine(ele);
            }
            q.Dequeue();

            Console.WriteLine();

            Console.WriteLine("Dequeue To QUeue : ");

            foreach (Object ele in q)
            {
                Console.WriteLine(ele);
            }

        }
    }
}

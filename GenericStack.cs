using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class GenericStack
    {
        public void InsertInGenericStack()
        {
            Stack<int> stackInt = new Stack<int>();
            stackInt.Push(4);
            stackInt.Push(5);
            stackInt.Push(7);
            stackInt.Push(9);
            stackInt.Push(8);

            Console.WriteLine("Element push in  generic stack : ");
            foreach (int i in stackInt)
            {
                Console.WriteLine(i);

            }
            stackInt.Pop();

            Console.WriteLine("after element removed(pop) from  generic stack : ");
            foreach (int i in stackInt)
            {
                Console.WriteLine(i);

            }

        }
    }
}

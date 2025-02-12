using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class InsertInStack
    {
        public void InsertEleInStack()
        {
            Stack stack = new Stack();
            stack.Push("hii");
            stack.Push("i");
            stack.Push("am");
            stack.Push("Asmita");
            stack.Push("Girhepunje");

            Console.WriteLine("Push To Stack : ");    

            foreach (object ele in stack)
            {
                Console.WriteLine(ele);
            }
            Console.WriteLine("After pop up : ");
            stack.Pop();
            foreach (object ele in stack)
            {
                Console.WriteLine(ele);
            }
        }
    }
}

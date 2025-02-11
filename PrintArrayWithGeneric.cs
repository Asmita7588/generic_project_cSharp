using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class PrintArrayWithGeneric
    {
        public static void ToPrint<T>(T[] inputArr)
        {
            foreach (var element in inputArr)
            {
                Console.WriteLine(element);
            }

        }
    }
}

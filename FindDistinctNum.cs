using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class FindDistinctNum
    {

        public void DistinctNum()
        {
            int[] intArray = { 1, 4, 5, 34, 54, 67, 8, 8, 4, 67, 1, 2, 3, 4, 5 };

            var methodSyntax = intArray.Distinct();

            var querySyntax = (from num in intArray  select num).Distinct();

            Console.WriteLine("Using method Syntax :");

            foreach (var ele in methodSyntax) { 
                Console.Write(ele + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Using query Syntax :");

            foreach (var qele in querySyntax)
            {
                Console.Write(qele + " ");
            }

            
        }

    }
}

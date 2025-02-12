using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class NonGenericArrayList
    {
        //Non-generic ArrayList
        public void InsertInArrayList()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Hii");
            arrayList.Add(DateTime.Now);
            arrayList.Add(3.45);

            foreach (Object element in arrayList)
            {
                Console.WriteLine(element);
                Console.WriteLine();
            }
        }
    }
}

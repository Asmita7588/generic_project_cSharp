using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class SortedListDemo
    {
        // it is the combination of ArrayList And HashTable

        public void InsertInSortedList()
        {
            SortedList sortedList = new SortedList();

            sortedList.Add("c", DateTime.Now);
            sortedList.Add("f", "Wednesday");
            sortedList.Add("g", 12);
            sortedList.Add("a", 123.56);

            Console.WriteLine("Sorted element  using SortedList :");
            foreach(DictionaryEntry d in sortedList)
            {
                Console.WriteLine(d.Key + " " + d.Value);
            }
        }
    }
}

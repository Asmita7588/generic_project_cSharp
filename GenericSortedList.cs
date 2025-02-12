using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class GenericSortedList
    {
        public void InsertInGenericSortedList()
        {

          SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("G", "trainning");
            sl.Add("C", "a");
            sl.Add("H", "Center");
            sl.Add("B", "is");
            sl.Add("A", "This");
            sl.Add("F", "panvel");

            foreach (KeyValuePair<string, string> kvp in sl) { 
                Console.WriteLine("Key = " + kvp.Key + " and " +"value = " + kvp.Value);
            }

                
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class HashTableKeyValue
    {
        //similar to a ArrayList but hashtable store object in key Value 
        public void InsertIntoHashTable()
        {

            Hashtable hashtable = new Hashtable();

            hashtable.Add("one", "Csharp");
            hashtable.Add("Two", "Fsharp");
            hashtable.Add("Three", "Vb.net");
            hashtable.Add("four", "ASP.net");

            foreach (DictionaryEntry d in hashtable) { 
                Console.WriteLine(d.Key + " " + d.Value);
                Console.WriteLine();

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class GenericDictionary
    {
        public void InsertInDictionary()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();
            dic.Add(1, "pune");
            dic.Add(2, "Mumbai");
            dic.Add(3, "panvel");
            dic.Add(4, "dhule");

            foreach (KeyValuePair<int, string> pair in dic)
            {
                Console.WriteLine("key = " +pair.Key + ", " +"value = " + pair.Value);
            }
        }
    }
}

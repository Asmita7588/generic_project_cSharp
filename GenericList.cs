using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class GenericList
    {
        public void DispayList()
        {
            List<String> list = new List<String>();

            list.Add("Asmita");
            list.Add("Chetan");
            list.Add("we");
            list.Add("are");
            list.Add("Siblings");

            foreach (String ele in list)
            {
                Console.WriteLine(ele);
            }

        }
    }
}

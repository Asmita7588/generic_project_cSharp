using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class CompareTwoTypes
    {
        public static void ComapareTypes<T1, T2>(T1 value1, T2 value2)
        {

            if (value1 == null || value2 == null)
            {
                Console.WriteLine("One or both values are null and cannot be compared.");
                return;
            }

            double num1, num2;

            bool isNum1 = double.TryParse(value1.ToString(), out num1);
            bool isNum2 = double.TryParse(value2.ToString(), out num2);

            if (isNum1 && isNum2)
            {
                if (num1 > num2)
                {
                    Console.WriteLine($"{value1} is greater than {value2}");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine($"{value1} is smaller than {value2}");
                }
                else
                    Console.WriteLine($"{value1} is equal to {value2}");
            }
        }
    }
}

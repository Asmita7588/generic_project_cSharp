using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class FindMinMaxUsingGenerics
    {
        public static void FindMinOfThree<T>(T a, T b, T c)
        {
           double num1,num2, num3;

            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);
            bool isNum3 = double.TryParse(c.ToString(), out num3);
            if (num1 < num2)
            {
                if (num1 < num3)
                    Console.WriteLine("num1 is the smallest: " + num1);
                else
                    Console.WriteLine("num3 is the smallest: " + num3);
            }
        else if (num2 < num3)
            {
                Console.WriteLine("num2 is the smallest: " + num2);
            }
            else
            {
                Console.WriteLine("num3 is the smallest: " + num3);
            }


        }

        public static void FindMaxOfThree<T>(T a, T b, T c)
        {
            double num1, num2, num3;

            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);
            bool isNum3 = double.TryParse(c.ToString(), out num3);

            if (num1 > num2)
            {
                if (num1 > num3)
                    Console.WriteLine("num1 is the largest: " + num1);
                else
                    Console.WriteLine("num3 is the largest: " + num3);
            }
            else if (num2 > num3)
            {
                Console.WriteLine("num2 is the largest: " + num2);
            }
            else
            {
                Console.WriteLine("num3 is the largest: " + num3);
            }
        }
    }
}

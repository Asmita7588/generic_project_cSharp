using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPracticePrablem
{
    internal class CalculatorUsingGenerics
    {
        public static void Calculator()
        {
            while (true)
            {
                Console.WriteLine("\n--- Menu-Driven Calculator ---");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
                {
                    Console.WriteLine("Invalid input! Please enter a valid option.");
                    continue;
                }

                if (choice == 5)
                {
                    Console.WriteLine("Exiting the calculator. Goodbye!");
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (choice == 1)
                    Console.WriteLine("Result: " + Add(num1, num2));
                else if (choice == 2)
                    Console.WriteLine("Result: " + Sub(num1, num2));
                else if (choice == 3)
                    Console.WriteLine("Result: " + Mul(num1, num2));
                else if (choice == 4)
                    Console.WriteLine("Result: " + Div(num1, num2));
            }

        }



        public static T Add<T>(T a, T b) 
        {
           double num1 , num2;
            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);
            
            double sum = num1 + num2;
            return (T)Convert.ChangeType(sum, typeof(T));

        }

        public static T Sub<T>(T a, T b)
        {
            double num1, num2;
            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);

            double sub = num1 - num2;
            return (T)Convert.ChangeType(sub, typeof(T));

        }

        public static T Mul<T>(T a, T b)
        {
            double num1, num2;
            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);

            double mul = num1 * num2;
            return (T)Convert.ChangeType(mul, typeof(T));

        }

        public static T Div<T>(T a, T b)
        {
            double num1, num2;
            bool isNum1 = double.TryParse(a.ToString(), out num1);
            bool isNum2 = double.TryParse(b.ToString(), out num2);

            if (Convert.ToDouble(b) == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return default;
            }
            double div = num1 / num2;
            return (T)Convert.ChangeType(div, typeof(T));

        }

    }
}

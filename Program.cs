using GenericPracticePrablem;

internal class Program
{
    public static void Main(string[] args)
    {
        string[] inputStr = { "Hii", "i", "Asmita" };
        int[] inputInt = { 0, 1, 2, 3, 4, 5, 6, 7 };
        double[] inputDouble = { 0.1, 0.3, 4.5 };

        PrintArrayWithGeneric.ToPrint(inputStr);
        PrintArrayWithGeneric.ToPrint(inputInt);
        PrintArrayWithGeneric.ToPrint(inputDouble);


        int num1 = 10, num2 = 20;
        Console.WriteLine("Before Swapping :" + "\n num1 = " + num1 + "\nnum2 = " + num2);
        SwapTwoNum.Swap(ref num1, ref num2);
        Console.WriteLine("Before Swapping :" + "\n num1 = " + num1 + "\nnum2 = " + num2);

        //compare two types

        CompareTwoTypes.ComapareTypes(10, 4.5);
        CompareTwoTypes.ComapareTypes(12, 12.0);
        CompareTwoTypes.ComapareTypes(23, 23.0);

        CompareTwoTypes.ComapareTypes(110, 4.5);
        CompareTwoTypes.ComapareTypes(12, 132.0);
        CompareTwoTypes.ComapareTypes(243, 23.0);

        // find min of three
        FindMinMaxUsingGenerics.FindMinOfThree(1, 3, 12);

        FindMinMaxUsingGenerics.FindMaxOfThree(1, 3, 12);
        FindMinMaxUsingGenerics.FindMaxOfThree(10, 5, 20);
        FindMinMaxUsingGenerics.FindMaxOfThree(4.5, 9.8, 2.3);
        FindMinMaxUsingGenerics.FindMaxOfThree("15", "30", "25");

        //calculator
        CalculatorUsingGenerics.Calculator();



    }
}
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


        
    }
}
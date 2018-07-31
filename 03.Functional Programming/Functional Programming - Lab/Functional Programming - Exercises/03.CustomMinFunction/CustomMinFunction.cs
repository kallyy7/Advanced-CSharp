using System;
using System.Linq;

public class CustomMinFunction
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> minFunc = GetMinNumber;
        
        Console.WriteLine(minFunc(inputNumbers));
    }

    private static int GetMinNumber(int[] numbers)
    {
        return numbers.Min();
    }
}

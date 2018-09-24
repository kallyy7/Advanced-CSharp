using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] inputSizes = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        string results = string.Empty;

        for (int row = 0; row < inputSizes[0]; row++)
        {
            for (int col = 0; col < inputSizes[1]; col++)
            {
                char @char = (char)('a' + row);
                char midChar = (char)(@char + col);

                results += $"{@char}{midChar}{@char} ";
            }
            results += Environment.NewLine;
        }
        Console.WriteLine(results);
    }
}

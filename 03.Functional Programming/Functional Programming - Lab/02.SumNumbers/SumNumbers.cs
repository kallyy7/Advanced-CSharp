using System;
using System.Linq;

public class SumNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Console.WriteLine(input.Length);
        Console.WriteLine(input.Sum());
    }
}
using System;
using System.Linq;

public class AddVAT
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(n => n + (n * 0.2))
            .ToList();

        inputNumbers
        .ForEach(n => Console.WriteLine($"{n:f2}"));
    }
}
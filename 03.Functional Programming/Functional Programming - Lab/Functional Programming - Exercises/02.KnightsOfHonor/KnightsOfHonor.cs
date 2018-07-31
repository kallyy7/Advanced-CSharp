using System;
using System.Linq;

public class KnightsOfHonor
{
    public static void Main()
    {
        var inputNames = Console.ReadLine()
            .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .ToList();
        inputNames
            .ForEach(x => Console.WriteLine($"Sir {x}"));
    }
}
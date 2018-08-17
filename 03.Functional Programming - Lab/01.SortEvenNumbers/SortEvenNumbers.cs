using System;
using System.Linq;

public class SortEvenNumbers
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .OrderBy(x => x);

        Console.WriteLine(string.Join(", ", input));
    }
}
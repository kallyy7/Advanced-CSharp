using System;
using System.Linq;

public class CountUppercaseWords
{
    public static void Main()
    {
        var input = Console.ReadLine()
            .Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
            .Where(i => char.IsUpper(i[0]))
            .ToArray();

        Console.WriteLine(string.Join(Environment.NewLine, input));
    }
}
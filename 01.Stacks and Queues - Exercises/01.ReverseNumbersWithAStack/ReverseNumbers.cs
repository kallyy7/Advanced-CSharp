using System;
using System.Collections.Generic;
using System.Linq;

public class ReverseNumbers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(" ".ToCharArray(),StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        Stack<int> reversedNumbers = new Stack<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            reversedNumbers.Push(numbers[i]);
        }

        Console.WriteLine(string.Join(" ", reversedNumbers));
    }
}
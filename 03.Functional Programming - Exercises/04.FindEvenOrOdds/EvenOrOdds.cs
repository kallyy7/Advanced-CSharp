using System;
using System.Linq;

public class EvenOrOdds
{
    public static void Main()
    {
        var inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
        string command = Console.ReadLine();

        Action<int[], string> evenOrOdd = GetEvenOrOddNumber;
        evenOrOdd(inputNumbers, command);
    }

    private static void GetEvenOrOddNumber(int[] inputNumbers, string command)
    {
        int startNumber = inputNumbers[0];
        int endNumber = inputNumbers[1];
        Action<int, int> evenNumbers = GetEvenNumbers;
        Action<int, int> oddNumbers = GetOddNumbers;

        if (command.Equals("even"))
        {
            evenNumbers(startNumber, endNumber);
        }
        else if (command.Equals("odd"))
        {
            oddNumbers(startNumber, endNumber);
        }
    }

    private static void GetEvenNumbers(int startNumber, int endNumber)
    {
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 2 == 0)
            {
                Console.Write(i + " ");
            }
        }
    }
    private static void GetOddNumbers(int startNumber, int endNumber)
    {
        for (int i = startNumber; i <= endNumber; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class BasicStackOperations
{
    public static void Main()
    {
        int[] commands = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int popNumbers = commands[1];
        int existNumber = commands[2];

        int[] inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> numbers = new Stack<int>(inputNumbers);

        for (int i = 0; i < popNumbers; i++)
        {
            numbers.Pop();
        }

        if (numbers.Contains(existNumber))
        {
            Console.WriteLine("true");
        }
        else
        {
            try
            {
                Console.WriteLine(numbers.Min());
            }
            catch
            {
                Console.WriteLine(0);
            }
        }
    }
}
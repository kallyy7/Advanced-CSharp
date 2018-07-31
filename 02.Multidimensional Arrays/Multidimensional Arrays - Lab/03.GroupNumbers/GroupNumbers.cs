using System;
using System.Linq;

public class GroupNumbers
{
    public static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int[] sizes = new int[3];
        foreach (var number in numbers)
        {
            int remainder = number % 3;
            if (remainder < 0)
            {
                string current = remainder.ToString().Trim('-');
                remainder = int.Parse(current);
            }
            sizes[remainder]++;
        }

        int[][] array =
        {
            new int[sizes[0]],
            new int[sizes[1]],
            new int[sizes[2]]
        };
        int[] offsets = new int[3];

        foreach (var number in numbers)
        {
            int remainder = number % 3;

            if (remainder < 0)
            {
                string current = remainder.ToString().Trim('-');
                remainder = int.Parse(current);
            }

            int index = offsets[remainder];
            array[remainder][index] = number;
            offsets[remainder]++;
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < array[i].Length; j++)
            {
                Console.Write(array[i][j] + " ");
            }

            Console.WriteLine();
        }
    }
}
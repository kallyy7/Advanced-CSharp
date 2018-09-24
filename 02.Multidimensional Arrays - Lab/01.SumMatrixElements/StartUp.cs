using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = input[0];
        int columns = input[1];
        int[][] matrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
        }

        Console.WriteLine(rows);
        Console.WriteLine(columns);
        Console.WriteLine(matrix.Select(x => x.Sum()).Sum());
    }
}
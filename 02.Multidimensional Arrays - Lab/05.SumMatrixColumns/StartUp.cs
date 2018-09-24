using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToArray();

        int[,] matrix = new int[input[0], input[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] inputRow = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }

        for (int row = 0; row < matrix.GetLength(1); row++)
        {
            int sum = 0;

            for (int col = 0; col < matrix.GetLength(0); col++)
            {
                sum += matrix[col, row];
            }
            Console.WriteLine(sum);
        }
    }
}
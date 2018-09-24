using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[inputSize, inputSize];
        int sum = 0;

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

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (row == col)
                {
                    sum += matrix[row, col];
                }
            }
        }
        Console.WriteLine(sum);
    }
}
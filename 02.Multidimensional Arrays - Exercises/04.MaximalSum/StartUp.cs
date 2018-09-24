using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int[] inputSize = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int[,] matrix = new int[inputSize[0], inputSize[1]];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] inputRow = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = inputRow[col];
            }
        }
        int maxSum = int.MinValue;
        int maxRow = int.MinValue;
        int maxCol = int.MinValue;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int column = 0; column < matrix.GetLength(1) - 2; column++)
            {
                int sum = matrix[row, column] + matrix[row, column + 1] + matrix[row, column + 2] +
                          matrix[row + 1, column] + matrix[row + 1, column + 1] + matrix[row + 1, column + 2] +
                          matrix[row + 2, column] + matrix[row + 2, column + 1] + matrix[row + 2, column + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = column;
                }
            }
        }
        Console.WriteLine($"Sum = {maxSum}");
        Console.WriteLine("{0} {1} {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol + 1], matrix[maxRow, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol + 2]);
    }
}

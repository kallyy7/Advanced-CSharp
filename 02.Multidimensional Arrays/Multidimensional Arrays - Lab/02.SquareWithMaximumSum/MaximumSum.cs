using System;
using System.Linq;

public class MaximumSum
{
    public static void Main()
    {
        int[] input = Console.ReadLine()
            .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int rows = input[0];
        int[][] matrix = new int[rows][];

        for (int i = 0; i < rows; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
        }

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.Length - 1; row++)
        {
            for (int col = 0; col < matrix[row].Length - 1; col++)
            {
                int currentSum = matrix[row][col] +
                                 matrix[row + 1][col] +
                                 matrix[row][col + 1] +
                                 matrix[row + 1][col + 1];

                if(currentSum > bestSum)
                {
                    bestSum = currentSum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine($"{matrix[bestRow][bestCol]} {matrix[bestRow][bestCol+1]}");
        Console.WriteLine($"{matrix[bestRow+1][bestCol]} {matrix[bestRow+1][bestCol+1]}");
        Console.WriteLine(bestSum);

    }
}
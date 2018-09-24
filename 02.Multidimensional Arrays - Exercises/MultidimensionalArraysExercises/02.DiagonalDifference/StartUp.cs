using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());
        int[][] matrix = new int[inputSize][];
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            primaryDiagonal += matrix[i][Math.Abs(0 - i)];
        }

        for (int i = 0; i < matrix.Length; i++)
        {
            secondaryDiagonal += matrix[i][Math.Abs(matrix[0].Length - 1 - i)];
        }
        int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

        Console.WriteLine(difference);
    }
}

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
        string[][] matrix = new string[inputSize[0]][];
        int counter = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            matrix[i] = Console.ReadLine()
                .Split()
                .ToArray();
        }

        for (int i = 0; i < matrix.Length - 1; i++)
        {
            for (int j = 0; j < matrix[i].Length - 1; j++)
            {
                if (matrix[i][j] == matrix[i][j + 1] &&
                    matrix[i][j] == matrix[i + 1][j] &&
                    matrix[i][j] == matrix[i + 1][j + 1])
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
}

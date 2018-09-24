using System;

public class StartUp
{
    public static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());
        char[,] matrix = new char[inputSize, inputSize];

        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            char[] inputSymbols = Console.ReadLine()
                .ToCharArray();

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[rows, col] = inputSymbols[col];
            }
        }
        string symbol = Console.ReadLine();

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col].ToString() == symbol)
                {
                    Console.WriteLine($"({row}, {col})");
                    return;
                }
            }
        }
        Console.WriteLine($"{symbol} does not occur in the matrix");
    }
}


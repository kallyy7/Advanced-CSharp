using System;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        int inputSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[inputSize, inputSize];

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
        string[] inputCommand = Console.ReadLine()
            .Split();

        while (!inputCommand[0].Equals("END"))
        {
            int row = int.Parse(inputCommand[1]); ;
            int col = int.Parse(inputCommand[2]);
            int value = int.Parse(inputCommand[3]);

            if (row < 0 || row >= matrix.GetLength(0) ||
                col < 0 || col >= matrix.GetLength(1))
            {
                Console.WriteLine("Invalid coordinates");
           
            }
            else
            {
                switch (inputCommand[0])
                {
                    case "Add":
                  

                        matrix[row, col] += value;
                        break;
                    case "Subtract":
                    

                        matrix[row, col] -= value;
                        break;
                }
            }

            inputCommand = Console.ReadLine()
                .Split();
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}
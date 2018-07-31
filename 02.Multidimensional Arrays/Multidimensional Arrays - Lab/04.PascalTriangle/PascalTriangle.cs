using System;

public class PascalTriangle
{
    public static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        ulong[][] triangle = new ulong[height][];

        for (int row = 0; row < height; row++)
        {
            triangle[row] = new ulong[row + 1];
            triangle[row][0] = 1;
            triangle[row][triangle[row].Length - 1] = 1;

            for (int colIndex = 1; colIndex < triangle[row].Length - 1; colIndex++)
            {
                triangle[row][colIndex] = triangle[row - 1][colIndex - 1] + 
                                          triangle[row - 1][colIndex];
            }
        }

        foreach (var row in triangle)
        {
            Console.WriteLine(string.Join(" ", row));
        }
    }
}
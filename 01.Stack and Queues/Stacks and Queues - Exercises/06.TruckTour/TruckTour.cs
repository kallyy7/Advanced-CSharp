using System;
using System.Linq;

public class TruckTour
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int smallestIndex = 0;
        int fuel = 0;

        for (int i = 0; i < n; i++)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int amountOfPetrol = input[0];
            int distance = input[1];

            fuel += amountOfPetrol - distance;

            if (fuel < 0)
            {
                fuel = 0;
                smallestIndex = i + 1;
            }
        }

        Console.WriteLine(smallestIndex);
    }
}
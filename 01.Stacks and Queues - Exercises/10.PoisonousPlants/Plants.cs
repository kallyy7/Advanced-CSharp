using System;
using System.Collections.Generic;
using System.Linq;

public class Plants
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        List<int> plants = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int days = 0;

        while (true)
        {
            List<int> deadPlants = new List<int>();

            for (int index = 0; index < plants.Count - 1; index++)
            {
                if (plants[index] < plants[index + 1])
                {
                    deadPlants.Add(index + 1);
                }
            }

            if (deadPlants.Count == 0)
            {
                break;
            }

            foreach (int index in deadPlants)
            {
                plants[index] = -1;
            }

            plants.RemoveAll(p => p == -1);
            days++;
        }
        Console.WriteLine(days);
    }
}

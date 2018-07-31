using System;
using System.Collections.Generic;

public class HotPotato
{
    public static void Main()
    {
        string[] names = Console.ReadLine().Split();
        int n = int.Parse(Console.ReadLine());

        Queue<string> childrens = new Queue<string>(names);

        while (childrens.Count > 1)
        {
            for (int i = 0; i < n - 1; i++)
            {
                childrens.Enqueue(childrens.Dequeue());
            }

            Console.WriteLine($"Removed {childrens.Dequeue()}");
        }

        Console.WriteLine($"Last is {childrens.Dequeue()}");
    }
}


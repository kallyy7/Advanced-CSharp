using System;
using System.Collections.Generic;
using System.Linq;

public class MaxElement
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> elements = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            int[] command = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            if (command[0].Equals(1))
            {
                elements.Push(command[1]);
            }
            else if (command[0].Equals(2))
            {
                elements.Pop();
            }
            else if (command[0].Equals(3))
            {
                Console.WriteLine(elements.Max());
            }
        }
    }
}
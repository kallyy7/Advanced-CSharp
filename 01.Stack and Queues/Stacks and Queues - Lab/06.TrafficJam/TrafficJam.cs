using System;
using System.Collections.Generic;

public class TrafficJam
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string command = Console.ReadLine();

        Queue<string> cars = new Queue<string>();
        int counter = 0;

        while (!command.Equals("end"))
        {
            if (command.Equals("green"))
            {
                for (int i = 0; i < n; i++)
                {
                    if (cars.Count < 1)
                    {
                        break;
                    }

                    Console.WriteLine($"{cars.Dequeue()} passed!");
                    counter++;
                }
            }
            else
            {
                cars.Enqueue(command);
            }

            command = Console.ReadLine();
        }

        Console.WriteLine($"{counter} cars passed the crossroads.");
    }
}
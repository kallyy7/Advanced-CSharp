namespace CrossRoads
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main()
        {
            int greenLightInSec = int.Parse(Console.ReadLine());
            int freeWindowInSec = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            Queue<string> cars = new Queue<string>();
            int carCounter = 0;
            int index = 0;
            string car = string.Empty;
            bool carCrash = false;

            while (!command.Equals("END"))
            {
                if (command.Equals("green"))
                {
                    int currentGreenLight = greenLightInSec;
                    int currentFreeWindow = freeWindowInSec;

                    for (int i = cars.Count - 1; i >= 0; i--)
                    {
                        if (currentGreenLight.Equals(0))
                        {
                            break;
                        }
                        string currentCar = cars.Dequeue();
                        int indexSum = currentGreenLight;
                        currentGreenLight -= currentCar.Length;
                        carCounter++;

                        if (currentGreenLight < 0)
                        {
                            indexSum += currentFreeWindow;
                            currentFreeWindow += currentGreenLight;
                            
                            if (currentFreeWindow < 0 && carCrash == false)
                            {
                                index = indexSum;
                                car = currentCar;
                                carCrash = true;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }
                command = Console.ReadLine();
            }

            if (carCrash)
            {
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{car} was hit at {car[index]}.");
            }
            else
            {
                Console.WriteLine("Everyone is safe.");
                Console.WriteLine($"{carCounter} total cars passed the crossroads.");
            }
        }
    }
}
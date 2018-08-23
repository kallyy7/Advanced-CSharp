namespace ParkingFeud
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            var parkingRowsAndColls = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int samEntrance = int.Parse(Console.ReadLine()) - 1;
            var parkingLots = Console.ReadLine().Split();
            int totalDistance = 0;

            while (parkingLots.Contains(parkingLots[samEntrance]))
            {
                int otherIndex = 0;

                for (int i = 0; i < parkingLots.Length; i++)
                {
                    if (samEntrance != i && parkingLots[i].Equals(parkingLots[samEntrance]))
                    {
                        otherIndex = i;
                    }
                }
                int samsDistance = CalculateDistance(parkingRowsAndColls, samEntrance, parkingLots[samEntrance]);
                int otherCarsDistance = CalculateDistance(parkingRowsAndColls, otherIndex, parkingLots[samEntrance]);

                if (samsDistance <= otherCarsDistance)
                {
                    totalDistance += samsDistance;
                    break;
                }
                totalDistance += samsDistance * 2;
                parkingLots = Console.ReadLine().Split();     
            }
            Console.WriteLine($"Parked successfully at {parkingLots[samEntrance]}." +
                              Environment.NewLine + $"Total Distance Passed: {totalDistance}");
        }

        private static int CalculateDistance(int[] parkingRowsAndColls, int otherIndex, string parkingLots)
        {
            char column = parkingLots[0];
            int row = int.Parse(parkingLots[1].ToString());
            int diffRows = Math.Abs(otherIndex - row);
            int distance = 0;

            if (otherIndex == row || otherIndex - row == -1)
            {
                distance = column - 64;
            }
            else if (otherIndex - row > 0)
            {
                diffRows += 1;

                if (diffRows % 2 == 0)
                {
                    distance = diffRows * (parkingRowsAndColls[1] + 3) + column - 64;
                }
                else
                {
                    distance = diffRows * (parkingRowsAndColls[1] + 3) + parkingRowsAndColls[1] - (column - 65);
                }
            }
            else
            {
                diffRows -= 2;

                if (diffRows % 2 == 0)
                {
                    distance = diffRows * (parkingRowsAndColls[1] + 3) + column - 64;
                }
                else
                {
                    distance = diffRows * (parkingRowsAndColls[1] + 3) + parkingRowsAndColls[1] - (column - 65);
                }
            }
            return distance;
        }
    }
}
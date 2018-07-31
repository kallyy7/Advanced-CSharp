using System;
using System.Linq;

public class BalancedParentheses
{
    public static void Main()
    {
        string[] input = Console.ReadLine()
            .Split()
            .ToArray();

        bool balanced = false;

        for (int i = 0; i < input[0].Length / 2; i++)
        {
            char rightSide = input[0][i];
            char leftSide = input[0][input[0].Length - i - 1];

            if (rightSide.Equals('{') && leftSide.Equals('}'))
            {
                balanced = true;
            }
            else if (rightSide.Equals('(') && leftSide.Equals(')'))
            {
                 balanced = true;
            }
            else if (rightSide.Equals('[') && leftSide.Equals(']'))
            {
                    balanced = true;
            }
            else
            {
                balanced = false;
            }
        }

        if (balanced)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}
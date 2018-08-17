using System;
using System.Collections.Generic;
using System.Linq;

public class SimpleCalculator
{
    public static void Main()
    {
        string[] input = Console.ReadLine().Split();

        Stack<string> calc = new Stack<string>(input.Reverse());

        while (calc.Count > 1)
        {
            int firstNumber = int.Parse(calc.Pop());
            string @operator = calc.Pop();
            int secondNumber = int.Parse(calc.Pop());

            if (@operator.Equals("+"))
            {
                calc.Push((firstNumber + secondNumber).ToString());
            }
            else if (@operator.Equals("-"))
            {
                calc.Push((firstNumber - secondNumber).ToString());
            }
        }

        Console.WriteLine(calc.Pop());
    }
}


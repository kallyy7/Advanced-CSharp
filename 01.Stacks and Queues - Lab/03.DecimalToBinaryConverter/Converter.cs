using System;
using System.Collections.Generic;

public class Converter
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        Stack<int> binaryNumber = new Stack<int>();

        if (number.Equals(0))
        {
            Console.WriteLine(0);
            Environment.Exit(0);
        }

        while (number > 0)
        {
            binaryNumber.Push(number % 2);
            number /= 2;
        }

        Console.WriteLine(string.Join("",binaryNumber));
    }
}


using System;
using System.Collections.Generic;

public class ReverseStrings
{
    public static void Main()
    {
        char[] input = Console.ReadLine().ToCharArray();

        Stack<char> words = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            words.Push(input[i]);
        }

        Console.WriteLine(string.Join("", words));
    }
}
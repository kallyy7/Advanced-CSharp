using System;
using System.Collections.Generic;

public class StackFibonacci
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<long> numbers = new Stack<long>();
        long a = 0;
        long b = 1;

        numbers.Push(a);
        numbers.Push(b);

        for (int i = 1; i < n; i++)
        {
            long c = a;
            a = numbers.Peek();
            numbers.Push(c + b);
            b = numbers.Peek();
        }

        Console.WriteLine(numbers.Peek());
    }
}

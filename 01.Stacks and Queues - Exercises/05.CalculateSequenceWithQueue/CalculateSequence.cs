using System;
using System.Collections.Generic;

public class CalculateSequence
{
    public static void Main()
    {
        long n = long.Parse(Console.ReadLine());

        Queue<long> numbers = new Queue<long>();
        numbers.Enqueue(n);
        int count = 1;

        while (count <= 50)   
        {
            long currentNumber = numbers.Peek();

            numbers.Enqueue(currentNumber + 1);
            numbers.Enqueue(2 * currentNumber + 1);
            numbers.Enqueue(currentNumber + 2);

            Console.Write(numbers.Dequeue() + " ");
            count++;
        }
    }
}
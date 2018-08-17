using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class MatchingBrackets
{
    public static void Main()
    {
        string inputLine = Console.ReadLine();

        Queue<string> expression = new Queue<string>();
        string pattern = @"(\(+[\d\s-*+\/]*\))";

        MatchCollection matches = Regex.Matches(inputLine, pattern);

        foreach (Match match in matches)
        {
            expression.Enqueue(match.ToString());
        }
        
        Console.WriteLine(string.Join(Environment.NewLine,expression));
    }
}


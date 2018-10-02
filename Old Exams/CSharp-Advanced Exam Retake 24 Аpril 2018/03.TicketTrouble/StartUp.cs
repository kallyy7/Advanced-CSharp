using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class StartUp
{
    public static void Main()
    {
        string location = Console.ReadLine();
        string content = Console.ReadLine();

        string patternTicket = @"((?<opener>\[)|{)(?(opener)[^\[\]]*?|[^{}]*?)(?(opener){|\[)" + location +
        @"(?(opener)}|\])(?(opener)[^\[\]]*?|[^{}]*?)(?(opener){|\[)(?<seat>[A-Z][0-9]{1,2})(?(opener)}|\])(?(opener)[^\[\]]*?|[^{}]*?)(?(opener)\]|})";
        MatchCollection ticketMatch = Regex.Matches(content, patternTicket);
        List<string> seats = new List<string>();

        foreach (Match match in ticketMatch)
        {
            if (match.Success)
            {
                string currentSeat = match.Groups[3].ToString();

                if (seats.Count < 2)
                {
                    seats.Add(currentSeat);
                }
                else
                {
                    for (int i = 0; i < seats.Count; i++)
                    {
                        string seat = seats[i];
                        string rowPattern = @"[A-Z]+(\d*)";
                        Match matchRowSeat = Regex.Match(seat, rowPattern);
                        Match matchRowCurrentSeat = Regex.Match(currentSeat, rowPattern);

                        if (matchRowSeat.Groups[1].ToString() == matchRowCurrentSeat.Groups[1].ToString() &&
                            seat != currentSeat)
                        {
                            if (seats[seats.Count - 1] == seat)
                            {
                                seats.RemoveAt(seats.Count - 2);
                            }
                            else
                            {
                                seats.RemoveAt(seats.Count - 1);
                            }

                            seats.Add(currentSeat);
                        }
                    }
                }
            }
        }       
        Console.WriteLine($"You are traveling to {location} " +
                          $"on seats {string.Join(" and ", seats)}.");
    }
}

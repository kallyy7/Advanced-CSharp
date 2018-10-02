using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        string favGenre = Console.ReadLine();
        string shortOrLong = Console.ReadLine();
        string input = Console.ReadLine();

        var movieData = new Dictionary<string, TimeSpan>();
        TimeSpan totalDuration = TimeSpan.Zero;

        while (!input.Equals("POPCORN!"))
        {
            string[] movie = input.Split('|').ToArray();

            string name = movie[0];
            string genre = movie[1];
            TimeSpan duration = TimeSpan.Parse(movie[2]);

            if (genre == favGenre)
            {
                if (!movieData.ContainsKey(name))
                {
                    movieData.Add(name, duration);
                }
            }

            totalDuration += duration;
            input = Console.ReadLine();
        }

        if (shortOrLong == "Short")
        {
            movieData = movieData.OrderBy(m => m.Value).ToDictionary(m => m.Key, m => m.Value);
        }
        else
        {
            movieData = movieData.OrderByDescending(m => m.Value).ToDictionary(m => m.Key, m => m.Value);
        }

        foreach (var movie in movieData)
        {
            Console.WriteLine(movie.Key);
            string yes = Console.ReadLine();

            if (yes == "Yes")
            {
                Console.WriteLine($"We're watching {movie.Key} - {movie.Value}");
                Console.WriteLine($"Total Playlst Duration: {totalDuration}");
                break;
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

public class FilterByAge
{
    public static void Main()
    {
        int numberOfPeople = int.Parse(Console.ReadLine());
        var dataPeople = new Dictionary<string, int>();

        for (int i = 0; i < numberOfPeople; i++)
        {
            string[] inputInfo = Console.ReadLine()
                .Split(" ,".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string currentName = inputInfo[0];
            int currentAge = int.Parse(inputInfo[1]);

            dataPeople.Add(currentName, currentAge);
        }

        string inputCondition = Console.ReadLine();
        int inputAge = int.Parse(Console.ReadLine());
        string inputFormat = Console.ReadLine();

        dataPeople = Condition(inputCondition, inputAge, dataPeople);
        FormatPrint(inputFormat, dataPeople);
    }

    private static Dictionary<string, int> Condition(string condition, int age, Dictionary<string, int> people)
    {
        if (condition.Equals("older"))
        {
            people = people.Where(x => x.Value >= age).ToDictionary(x => x.Key, x => x.Value);
        }
        else
        {
            people = people.Where(x => x.Value < age).ToDictionary(x => x.Key, x => x.Value);
        }

        return people;
    }

    private static void FormatPrint(string format, Dictionary<string, int> people)
    {
        if (format.Equals("name age"))
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key} - {person.Value}");
            }
        }
        else if (format.Equals("name"))
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Key}");
            }         
        }
        else if (format.Equals("age"))
        {
            foreach (var person in people)
            {
                Console.WriteLine($"{person.Value}");
            }
        }

        return;
    }
}
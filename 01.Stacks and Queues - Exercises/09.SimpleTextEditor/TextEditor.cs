using System;
using System.Collections.Generic;

public class TextEditor
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());

        string text = string.Empty;
        Stack<string> editor = new Stack<string>();

        for (int currendCommand = 0; currendCommand < input; currendCommand++)
        {
            string[] commandInfo = Console.ReadLine().Split();

            switch (commandInfo[0])
            {
                case "1":
                    editor.Push(text);
                    string textToAdd = commandInfo[1];
                    text += textToAdd;
                    break;
                case "2":
                    editor.Push(text);
                    int startIndex = text.Length - int.Parse(commandInfo[1]);
                    text = text.Remove(startIndex);
                    break;
                case "3":
                    int index = int.Parse(commandInfo[1]);
                    Console.WriteLine(text[index - 1]);
                    break;
                case "4":
                    text = editor.Pop();
                    break;
            }
        }
    }
}

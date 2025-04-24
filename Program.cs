// Week 3 Assignment 3.1.3
//MON Apr 21, 2025

using System;
class Program
{
    static void Main()
    {
        Console.Write("Please input a string");
        string input = Console.ReadLine();

        int spaceCount = CountSpaces(input);

        Console.WriteLine($"\"{input}\"contains{spaceCount} spaces.");
    }


    static int CountSpaces(string str)
    {
        int count = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                count++;
            }
        }
        return count;
    }
}
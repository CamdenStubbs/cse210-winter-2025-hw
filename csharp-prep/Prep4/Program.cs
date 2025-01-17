using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        int number;
        int sum = 0;
        int greatest = 0;
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a list of positive and/or negative integers.\nType 0 when finished");
        do
        {
            number = int.Parse(Console.ReadLine());
            if (number > 0 || number < 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        foreach (int i in numbers)
        {
            sum += i;

            if (i > greatest)
            {
                greatest = i;
            }
        }

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"Sum of Numbers: {sum}");
        Console.WriteLine($"Average of Numbers: {average}");
        Console.WriteLine($"Highest Number: {greatest}");
    }
}
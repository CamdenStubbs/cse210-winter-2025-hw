using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string name = PromptUserName();
        int favNumber = PromptUserNumber();
        int favSquareNumber = SquareNumber(favNumber);
        DisplayResult(name, favSquareNumber);

    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int SquareNumber(int number)
    {
        int squareNumber = number*number;
        return squareNumber;
    }

    static void DisplayResult(string name, int squareNumber)
    {
        Console.Write($"{name}, the square of your number is {squareNumber}");
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        int guess = 0;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        while (magicNumber != guess)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }

            else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }

            else if (magicNumber == guess)
                {
                    Console.WriteLine("You Guessed it!");
                }
        }
    }
}
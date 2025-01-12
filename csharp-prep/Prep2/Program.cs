using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.WriteLine("What is your current grade percentage? Please input an integer between 0-100. ");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);

        if (gradeNumber >= 90)
            {
                letter = "A";
            }
        
        else if (gradeNumber >= 80 && gradeNumber < 90)
            {
                letter = "B";
            }

        else if (gradeNumber >= 70 && gradeNumber < 80)
            {
                letter = "C";
            }
        
        else if (gradeNumber >= 60 && gradeNumber < 70)
            {
                letter = "D";
            }
        
        else if (gradeNumber < 60)
            {
                letter = "F";
            }

        Console.WriteLine($"You got a {letter}.");

        if (gradeNumber >= 70)
            { 
                Console.WriteLine("Good Job! You passed!");
            }
        
        else
            {
                Console.WriteLine("Better luck next time!");
            }
    }
}
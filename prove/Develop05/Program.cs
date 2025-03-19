using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"\nTotal Points: {goalManager.GetTotalPoints()}");
            Console.WriteLine("\nPlease enter an integer to choose an option:\n");
            Console.WriteLine("0: Quit\n1: Create Goal\n2: List Goals\n3: Record Goal Progress\n4: Save Goal List\n5: Load Goal List\n6: Remove Goal\n");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == 0)
            {
                break;
            }
            if (userInput == 1)
            {
                Console.WriteLine("What goal would like to create?\n");
                Console.WriteLine("Options:\n1: Simple Goal\n2: Eternal Goal\n3: Checklist Goal");
                int goalOption = int.Parse(Console.ReadLine());
                if (goalOption == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.CreateGoal();
                    goalManager.AppendGoal(simpleGoal);
                }

                if (goalOption == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.CreateGoal();
                    goalManager.AppendGoal(eternalGoal);
                }

                if (goalOption == 3)
                {
                    ChecklistGoal checklistGoal = new ChecklistGoal();
                    checklistGoal.CreateGoal();
                    goalManager.AppendGoal(checklistGoal);
                }
            }

            else if (userInput == 2)
            {
                Console.WriteLine("\n[] = Not Complete | [X] = Completed\n");
                goalManager.ListGoals();
            }

            else if (userInput == 3)
            {
                goalManager.Record();
                goalManager.CalcTotalPoints();
            }

            else if (userInput == 4)
            {
                goalManager.SaveGoalList();
            }

            else if (userInput == 5)
            {
                GoalManager loadedGoalManager= new GoalManager();
                loadedGoalManager.LoadGoals();
                goalManager = loadedGoalManager;
                goalManager.CalcTotalPoints();
            }

            else if (userInput == 6)
            {
                Console.WriteLine("Which goal would you like to remove?");
                int numberInput = int.Parse(Console.ReadLine());
                goalManager.RemoveGoal(numberInput);
                Console.WriteLine("\nGoal Removed!");
                goalManager.CalcTotalPoints();
            }

        }
    }
}
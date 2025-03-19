using System.IO;

class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _totalPoints;

    public GoalManager()
    {
        _totalPoints = 0;
    }

    public void SaveGoalList()
    {
        Console.WriteLine("Enter a filename to save the goal list: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.FormatGoal());
                }
            }
        Console.WriteLine("Successful Save!\n");
    }

    public void AppendGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }

    public void SetTotalPoints(int points)
    {
        _totalPoints = points;
    }

    public void ListGoals()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.Write($"{i}. " );
            goal.Display();
            i++;
        }
    }

    public void Record()
    {
        Console.WriteLine("What goal did you complete?");
        int userInput = int.Parse(Console.ReadLine());
        _goals[userInput - 1].IsComplete();
    }

    public void AddTotalPoints(int points)
    {
        _totalPoints += points;
    }
    public void CalcTotalPoints()
    {
        SetTotalPoints(0);
        foreach (Goal goal in _goals)
        {
            AddTotalPoints(goal.CalcPoints());
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("Enter a filename to load the goal list: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            if (parts[0] == "SimpleGoal")
            {
                SimpleGoal simpleGoal = new SimpleGoal();
                simpleGoal.ReadGoal(parts);
                AppendGoal(simpleGoal);
            }
            else if (parts[0] == "EternalGoal")
            {
                EternalGoal eternalGoal = new EternalGoal();
                eternalGoal.ReadGoal(parts);
                AppendGoal(eternalGoal);
            }
            else if (parts[0] == "ChecklistGoal")
            {
                ChecklistGoal checklistGoal = new ChecklistGoal();
                checklistGoal.ReadGoal(parts);
                AppendGoal(checklistGoal);
            }
        }
        
        Console.WriteLine("Successful Load!\n");
    }

    public void RemoveGoal(int i)
    {
        _goals.Remove(_goals[i-1]);
    }

}
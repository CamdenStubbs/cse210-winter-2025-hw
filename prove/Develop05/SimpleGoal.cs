class SimpleGoal : Goal
{
    public SimpleGoal() : base()
    {}

    public override void CreateGoal()
    {
        Console.WriteLine("What is the title of your goal?");
        string title = Console.ReadLine();
        SetTitle(title);
        Console.WriteLine($"What is the description of {GetTitle()}?");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.WriteLine("How many points is this goal worth?");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }
    
    public override void IsComplete()
    {
        SetComplete(true);
    }

    public override int CalcPoints()
    {
        int points = 0;
        if (GetComplete() == true)
        {
            points = GetPoints();
        }
        return points;
    }


    public override void Display()
    {
        if (GetComplete() != true)
        {
            Console.WriteLine($"({GetPoints()} points) {GetTitle()}: {GetDescription()} []");
        }
        else
        {
            Console.WriteLine($"({GetPoints()} points) {GetTitle()}: {GetDescription()} [X]");
        }
    }

    public override string FormatGoal()
    {
        return $"SimpleGoal;{GetTitle()};{GetDescription()};{GetPoints()};{GetComplete()}";
    }

    public override void ReadGoal(string[] parts)
    {
        SetTitle(parts[1]);
        SetDescription(parts[2]);
        SetPoints(int.Parse(parts[3]));
        SetComplete(bool.Parse(parts[4]));
    }
}
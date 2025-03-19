class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _desiredAmount;
    private int _completedAmount;

    public ChecklistGoal() : base()
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
        Console.WriteLine($"How many times will you have to complete this goal for bonus points?");
        int desiredAmount = int.Parse(Console.ReadLine());
        _desiredAmount = desiredAmount;
        Console.WriteLine($"What is the bonus point value?");
        int bonusPoints = int.Parse(Console.ReadLine());
        _bonusPoints = bonusPoints;
    }

    public override void IsComplete()
    {
        SetComplete(true);
        _completedAmount ++;
    }

    public override void Display()
    {
        if (GetComplete() != true)
        {
            Console.WriteLine($"({GetPoints()} points) ({_bonusPoints} bonus points) {GetTitle()}: {GetDescription()} [] (0/{_desiredAmount} Completed)");
        }
        else
        {
            Console.WriteLine($"({GetPoints()} points) ({_bonusPoints} bonus points) {GetTitle()}: {GetDescription()} [X] ({_completedAmount}/{_desiredAmount} Completed)");
        }
    }

    public override int CalcPoints()
    {
        int points = 0;
        if (GetComplete() == true)
        {
            for (int i=0;i<_completedAmount;i++)
            {
                points += GetPoints();
            }
        }

        if (_completedAmount >= _desiredAmount)
        {
            points += _bonusPoints;
        }
        return points;
    }

    public override string FormatGoal()
    {
        return $"ChecklistGoal;{GetTitle()};{GetDescription()};{GetPoints()};{GetComplete()};{_completedAmount};{_desiredAmount};{_bonusPoints}";
    }

        public override void ReadGoal(string[] parts)
    {
        SetTitle(parts[1]);
        SetDescription(parts[2]);
        SetPoints(int.Parse(parts[3]));
        SetComplete(bool.Parse(parts[4]));
        _completedAmount = int.Parse(parts[5]);
        _desiredAmount = int.Parse(parts[6]);
        _bonusPoints = int.Parse(parts[7]);
    }
}
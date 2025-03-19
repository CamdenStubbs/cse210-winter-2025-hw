class Goal
{
    private string _title;
    private string _description;
    private int _points;
    private bool _complete;

    public Goal()
    {
        _title = "";
        _description = "";
        _points = 0;
        _complete = false;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetComplete(bool complete)
    {
        _complete = complete;
    }

    public bool GetComplete()
    {
        return _complete;
    }

    public virtual void CreateGoal()
    {
        Console.WriteLine("What is the title of your goal?");
        string title = Console.ReadLine();
        SetTitle(title);
        Console.WriteLine($"What is the description of {_title}?");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.WriteLine("How many points is this goal worth?");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
    }

    public virtual void IsComplete()
    {
        _complete = true;
    }

    public virtual int CalcPoints()
    {
        int points = 0;
        if (_complete == true)
        {
            points = _points;
        }
        return points;
    }

    public virtual void Display()
    {
        Console.WriteLine($"({_points} points) {_title}: {_description}");
    }

    public virtual string FormatGoal()
    {
        return "";
    }

    public virtual void ReadGoal(string[] parts)
    {
        Goal goal = new Goal();
        goal._title = parts[1];
        goal._description = parts[2];
        goal._points = int.Parse(parts[3]);
        goal._complete = bool.Parse(parts[4]);
    }
    
}
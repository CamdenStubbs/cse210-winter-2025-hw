class Activity
{
    private string _date;
    private int _minutes;

    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public int GetMinutes()
    {
        return _minutes;
    }

    public virtual double CalcDistanceKm()
    {
        return 1;
    }

    public virtual double CalcSpeedKm()
    {
        return 1;
    }

    public virtual double CalcPaceKm()
    {
        return 1;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} Activity ({_minutes} min): Distance: Speed: Pace:");
    }
}
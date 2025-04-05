class Running : Activity
{
    private double _distance;
    
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double CalcSpeedKm()
    {
        return _distance / GetMinutes() * 60;
    }

    public override double CalcPaceKm()
    {
        return GetMinutes() / _distance;
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()} Running ({GetMinutes()} min): Distance: {_distance} km, ");
        Console.WriteLine($"Speed: {CalcSpeedKm()} kph, Pace: {CalcPaceKm()} min per km");
    }
}
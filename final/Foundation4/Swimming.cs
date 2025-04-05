class Swimming : Activity
{
    private int _swimmingLaps;
    
    public Swimming(string date, int minutes, int swimmingLaps) : base(date, minutes)
    {
        _swimmingLaps = swimmingLaps;
    }

    public override double CalcDistanceKm()
    {
        return _swimmingLaps * 50.0 / 1000;
    }

    public override double CalcSpeedKm()
    {
        return CalcDistanceKm() / GetMinutes() * 60;
    }

    public override double CalcPaceKm()
    {
        return GetMinutes() / CalcDistanceKm();
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()} Swimming ({GetMinutes()} min): Distance: {CalcDistanceKm()} km, ");
        Console.WriteLine($"Speed: {CalcSpeedKm()} kph, Pace: {CalcPaceKm()} min per km");
    }
}
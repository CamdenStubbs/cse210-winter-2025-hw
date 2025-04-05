class Cycling : Activity
{
    private double _speed;
    
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double CalcDistanceKm()
    {
        return _speed / 60 * GetMinutes();
    }

    public override double CalcPaceKm()
    {
        return 60 / _speed;
    }

    public override void GetSummary()
    {
        Console.Write($"{GetDate()} Cycling ({GetMinutes()} min): Distance: {CalcDistanceKm()} km, ");
        Console.WriteLine($"Speed: {_speed} kph, Pace: {CalcPaceKm()} min per km");
    }
}
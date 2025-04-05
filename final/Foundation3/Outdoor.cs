class Outdoor : Event
{
    private string _weatherForecast;
    
    public Outdoor(string title, string description, string date, string time, Address address,
    string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}\nAddress: {GetAddress().FormatAddress()}\nWeather Forecast: {_weatherForecast}");
    }

    public override void DisplayShort()
    {
        Console.WriteLine($"Type: Outdoor Gathering\nTitle: {GetTitle()}\nDate: {GetDate()}");
    }
}
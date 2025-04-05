class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    
    public Lecture(string title, string description, string date, string time, Address address,
    string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}\nAddress: {GetAddress().FormatAddress()}\nSpeaker: {_speaker}\nCapacity: {_capacity}");
    }

    public override void DisplayShort()
    {
        Console.WriteLine($"Type: Lecture\nTitle: {GetTitle()}\nDate: {GetDate()}");
    }
}
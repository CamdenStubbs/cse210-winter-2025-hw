class Reception : Event
{
    private string _email;
    
    public Reception(string title, string description, string date, string time, Address address,
    string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override void DisplayFull()
    {
        Console.WriteLine($"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}\nAddress: {GetAddress().FormatAddress()}\nEmail to RSVP: {_email}");
    }

    public override void DisplayShort()
    {
        Console.WriteLine($"Type: Reception\nTitle: {GetTitle()}\nDate: {GetDate()}");
    }
}
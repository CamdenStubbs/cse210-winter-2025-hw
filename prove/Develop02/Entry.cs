using System;
public class Entry
{
    public string _entryDateTime;

    public string _entryText;

    public string _givenPrompt;

    public void Display()
    {
        Console.WriteLine($"{_givenPrompt} Entry: {_entryDateTime} {_entryText}");
    }
}

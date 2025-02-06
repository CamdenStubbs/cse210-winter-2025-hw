using System;

public class Prompt
{
    public int _promptIndex;
    public List<string> _promptList = new List<string>();
    public Random _randomPrompt = new Random();

    public string GeneratePrompt() 
    {
        string prompt = _promptList[_promptIndex];
        return prompt;
    }

}
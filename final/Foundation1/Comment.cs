class Comment
{
    private string _userName;
    private string _text;

    public Comment(string userName, string text)
    {
        _userName = userName;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"\nUsername: {_userName}\n\nComment: {_text}\n");
    }
}
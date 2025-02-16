using System.ComponentModel.DataAnnotations;

class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse;

    public Reference()
    {
        _book = "";
        _chapter = "";
        _startVerse = "";
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "";
    }

    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = $"-{endVerse}";
    }

    public string GetBook()
    {
        return _book;
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public string GetChapter()
    {
        return _chapter;
    }

    public void SetChapter(string chapter)
    {
        _chapter = chapter;
    }

    public string GetStartVerse()
    {
        return _startVerse;
    }

    public void SetStartVerse(string startVerse)
    {
        _startVerse = startVerse;
    }

    public string GetEndVerse()
    {
        return _endVerse;
    }

    public void SetEndVerse(string endVerse)
    {
        _endVerse = $"-{endVerse}";
    }
    
    public void Display()
    {
        Console.WriteLine($"{_book} {_chapter}:{_startVerse}{_endVerse}: ");
    }
}
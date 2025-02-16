using System.Net;

class Word 
{
    private string _wordText;

    private bool _isHidden;

    public Word()
    {
        _wordText = "";
        _isHidden = false;
    }

    public Word(string text) 
    {
        _wordText = text;
        _isHidden = false;
    }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public void HideBool() 
    {
        _isHidden = true;
    }

    public void HideWord()
    {
        if (_isHidden == false)
        {
            HideBool();
        }
    }

    public void DisplayShownWords()
    {
        if (_isHidden == false)
        {
            Console.Write($"{_wordText} ");
        }
        else 
        {
            Console.Write(" _");
            for (int i = 1;i < _wordText.Length - 1; i++)
            {
                Console.Write("_");
            }
            Console.Write("_ ");
        }
    }
}
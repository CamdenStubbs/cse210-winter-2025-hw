class Scripture 
{
    private string _scriptureText;
    private List<string> _scriptureWordList = new List<string>();
    private Reference _scriptureReference;
    private List<Word> _words = new List<Word>();
    private Random _randomWord = new Random();
    private int _wordsIndex;
    private int _shownTracker;

    public Scripture()
    {
        _scriptureText = "";
        _wordsIndex = 0;
        _shownTracker = 0;
    }

    public Scripture(string scriptureText)
    {
        _scriptureText = scriptureText;
        _wordsIndex = 0;
        _shownTracker = 0;
    }

    public Scripture(string scriptureText, Reference scriptureReference)
    {
        _scriptureText = scriptureText;
        _scriptureReference = scriptureReference;
        _wordsIndex = 0;
        _shownTracker = 0;
    }

    public Scripture(string scriptureText, Reference scriptureReference, int wordsIndex)
    {
        _scriptureText = scriptureText;
        _scriptureReference = scriptureReference;
        _wordsIndex = wordsIndex;
        _shownTracker = 0;
    }

    public List<string> GetScriptureWordList()
    {
        return _scriptureWordList;
    }

    public int GetShownTracker()
    {
        return _shownTracker;
    }

    public void SetScriptureText(string scriptureText)
    {
        _scriptureText = scriptureText;
    }

    public void SetScriptureReference(Reference reference)
    {
        _scriptureReference = reference;
    }

    public void SetWordsIndex(int index)
    {
        _wordsIndex = index;
    }

    public void SetRandomWordsIndex()
    {
        _wordsIndex = _randomWord.Next(_words.Count);
    }

    public void SplitScripture()
    {
        _scriptureWordList = _scriptureText.Split(" ").ToList();
    }

    public void AppendWord(Word word) 
    {
        _words.Add(word);
    }

    public void HideRandomWords(int number) 
    {
        CheckWordBool();
        for (int i = 0; i < number; i++)
        {
            while (_shownTracker > 0)
            {
                SetRandomWordsIndex();
                if (_words[_wordsIndex].GetIsHidden() == false)
                {
                    _words[_wordsIndex].HideWord();
                    _shownTracker --;
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }

    public void AddToTracker()
    {
        _shownTracker ++;
    }

    public void CheckWordBool()
    {
        if (_shownTracker == 0)
        {
            Console.WriteLine("You Hid All The Words!");
            _shownTracker = -1;
        }
    }

    public void Display() 
        {
            _scriptureReference.Display();
            foreach (Word word in _words)
            {
                word.DisplayShownWords();
            }
        }
}
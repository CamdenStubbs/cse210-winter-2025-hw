class Activity
{
    private string _activityName;
    private string _welcomeMessage;
    private string _description;
    private int _duration;
    private string _endMessage;
    private DateTime _startTime;
    private DateTime _futureTime;
    private DateTime _currentTime;


    public Activity(string description, string activityName)
    {
        _activityName = activityName;
        _welcomeMessage = $"\nWelcome to the {_activityName}.";
        _description = description;
        _duration = 0;
        _endMessage = $"\n\nGood Job! You completed the activity that lasted {_duration} seconds!\n";
    }

    public DateTime GetStartTime()
    {
        return _startTime;
    }

    public void SetCurrentTime()
    {
        _currentTime = DateTime.Now;
    }

        public DateTime GetCurrentTime()
    {
        return _currentTime;
    }

    public void SetStartTime()
    {
        _startTime = DateTime.Now;
    }

    public DateTime GetFutureTime()
    {
        return _futureTime;
    }

    public void SetFutureTime()
    {
        _futureTime = _startTime.AddSeconds(_duration);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void SetEndMessage(int duration)
    {
        _endMessage = $"\n\nGood Job! You completed the activity that lasted {duration} seconds!\n";
    }

    public void StartActivity()
    {
        Console.WriteLine($"{_welcomeMessage}");
        Console.WriteLine(_description);
        Console.WriteLine("\nPlease indicate the duration of the activity in seconds:");
        int duration = int.Parse(Console.ReadLine());
        SetDuration(duration);
        Console.WriteLine("\nGet Ready...");
    }

    public void EndActivity()
    {
        SetEndMessage(_duration);
        Console.WriteLine(_endMessage);
    }

    public void PauseAnimation()
    {
        List<string> animations = new List<string>();
        animations.Add("|");
        animations.Add("/");
        animations.Add("-");
        animations.Add("\\");
        for (int i = 0; i < 4; i++)
        {
            foreach (string animation in animations)
            {
                Console.Write($"{animation}");
                Thread.Sleep(300);
                Console.Write("\b \b");
            }
        }

    }

    public void Countdown()
    {
        List<string> numbers = new List<string>();
        numbers.Add("5");
        numbers.Add("4");
        numbers.Add("3");
        numbers.Add("2");
        numbers.Add("1");
        foreach (string number in numbers)
        {
            Console.Write(number);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}
class BreathingActivity : Activity
{
    public BreathingActivity(string description, string activityName) : base(description, activityName)
    {
        
    }

    public void BreathingLoop()
    {
        StartActivity();
        PauseAnimation();
        SetStartTime();
        SetFutureTime();
        while (true)
        {
            SetCurrentTime();
            if (GetCurrentTime() < GetFutureTime())
            {
                Console.Write("\n\nBreathe in...");
                Countdown();
                Console.Write("\n\nBreathe out...");
                Countdown();
            }
            else
            {
                break;
            }
        }
        EndActivity();
    }
}
class Log
{
    private int _activityCount;
    
    public Log()
    {
        _activityCount = 0;
    }

    public void IncreaseCount()
    {
        _activityCount++;
    }

    public int GetActivityCount()
    {
        return _activityCount;
    }
}
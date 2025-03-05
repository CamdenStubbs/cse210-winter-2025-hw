class ReflectionActivity : Activity
{
    public ReflectionActivity(string description, string activityName) : base(description, activityName)
    {

    }
    
    public void ReflectionLoop()
    {
        Random random = new Random();
        List<string> reflections = new List<string>();
        reflections.Add("Think of a time when you struggled with a task.");
        reflections.Add("Think of a time when you performed a small task of kindness.");
        reflections.Add("Think of a time when you tried to do your best.");
        reflections.Add("Think of a time when someone lifted up your spirits.");
        List<string> questions = new List<string>();
        questions.Add("Why was this experience meaningful to you?");
        questions.Add("Was this experience different than other experiences in some way?");
        questions.Add("How often has this kind of experience occured?");
        questions.Add("Does this moment tell you something about yourself?");
        questions.Add("Was there a person that was a critical part of this experience?");
        questions.Add("Did the location have any meaningful impact? If not, what circumstances led to this moment?");
        questions.Add("Does this experience make you want to do something similar today?");
        questions.Add("What feelings were invoked by this experience?");
        questions.Add("How much have you changed from this moment?");
        StartActivity();
        PauseAnimation();
        Console.WriteLine($"\n{reflections[random.Next(reflections.Count)]}");
        Console.Write("\nPress Enter When You Are Ready to Continue: ");
        Console.ReadLine();
        SetStartTime();
        SetFutureTime();
        while (true)
        {
            SetCurrentTime();
            if (GetCurrentTime() < GetFutureTime())
            {
                Console.WriteLine($"\n{questions[random.Next(questions.Count)]}");
                PauseAnimation();
                PauseAnimation();
            }
            else
            {
                break;
            }
        }
        EndActivity();
    }
}
using System.Runtime.CompilerServices;

class ListingActivity : Activity
{
    public ListingActivity(string description, string activityName) : base(description, activityName)
    {

    }

    public void ListingLoop()
    {
        List<string> items = new List<string>();
        List<string> questions = new List<string>();
        Random random = new Random();
        questions.Add("Who in your life do you appreciate?");
        questions.Add("What were some kind acts that you experienced throughout your life?");
        questions.Add("What spiritual moments do you cherish?");
        questions.Add("When have you felt happy throughout the week?");
        questions.Add("Who are some people that you have helped today?");
        StartActivity();
        PauseAnimation();
        Console.WriteLine($"\n{questions[random.Next(questions.Count)]}");
        Console.Write("...");
        Countdown();
        Console.WriteLine("\n\nPlease Begin to List Items:\n");
        SetStartTime();
        SetFutureTime();
        while (true)
        {
            SetCurrentTime();
            if (GetCurrentTime() < GetFutureTime())
            {
                string item = Console.ReadLine();
                items.Add(item);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine($"\nYou Wrote {items.Count} items!");
        EndActivity();
    }
}
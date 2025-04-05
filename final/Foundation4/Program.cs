using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running running = new Running("03 Dec 2024", 40, 2);
        activities.Add(running);

        Cycling cycling = new Cycling("03 Dec 2024", 40, 16);
        activities.Add(cycling);

        Swimming swimming = new Swimming("03 Dec 2024", 40, 5);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}
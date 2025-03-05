using System;

class Program
{
    static void Main(string[] args)
    {
        Log activityLog = new Log();
        while (true)
        {
            Console.WriteLine($"Activity Count: {activityLog.GetActivityCount()}\n");
            Console.WriteLine("Please Select an Activity by Inputting a Number:");
            Console.WriteLine("0: Quit\n1: Breathing Activity\n2: Reflection Activity\n3: Listing Activity");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                break;
            }

            else if (userInput == 1)
            {
                BreathingActivity breathing = new BreathingActivity("\nThis activity will calm your nerves as you breathe in and out."
                , "Breathing Activity");

                breathing.BreathingLoop();
                activityLog.IncreaseCount();
            }

            else if (userInput == 2)
            {
                ReflectionActivity reflection = new ReflectionActivity(
                "\nThis activity will show prompts and questions to help you reflect on your life"
                , "Reflection Activity");
                reflection.ReflectionLoop();
                activityLog.IncreaseCount();
            }

            else if (userInput == 3)
            {
                ListingActivity listing = new ListingActivity("\nThis activity will have you list good things in your life."
                , "Listing Activity");
                listing.ListingLoop();
                activityLog.IncreaseCount();
            }
        }
    }
}
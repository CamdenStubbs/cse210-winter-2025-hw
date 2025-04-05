using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Event 1\n_______");
        Address address1 = new Address("755 Walkboard Street", "Henderson", "Nevada", "USA");
        Lecture _lecture = new Lecture("Physics Lecture", "A Brief Overview of the Big Bang Theory",
        "January 27, 2026", "7:00 PM", address1,"Professor Justified", 175);
        _lecture.DisplayStandard();
        Console.WriteLine();
        _lecture.DisplayFull();
        Console.WriteLine();
        _lecture.DisplayShort();
        Console.WriteLine();

        Console.WriteLine("\nEvent 2\n_______");
        Address address2 = new Address("673 Mundane Court", "Clovis", "California", "USA");
        Reception _reception = new Reception("Our Perfect Wedding Reception", "Lindsey Sayso's and Mark Doit's big, fancy wedding reception!",
        "July 8, 2026", "12:00 PM", address2, "lindseysayso45@gmail.com");
        _reception.DisplayStandard();
        Console.WriteLine();
        _reception.DisplayFull();
        Console.WriteLine();
        _reception.DisplayShort();
        Console.WriteLine();

        Console.WriteLine("\nEvent 3\n_______");
        Address address3 = new Address("343 Barley Street", "Houston", "Texas", "USA");
        Outdoor _outdoor = new Outdoor("Line Dancing Extravaganza", "Join us for some classic line dancing, free food, and a good time!",
        "August 3, 2026", "3:00 PM", address3, "Partly Cloudy");
        _outdoor.DisplayStandard();
        Console.WriteLine();
        _outdoor.DisplayFull();
        Console.WriteLine();
        _outdoor.DisplayShort();
        Console.WriteLine();
    }
}
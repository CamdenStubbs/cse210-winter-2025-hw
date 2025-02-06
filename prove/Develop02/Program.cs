using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your personal journal!\nPlease input an integer to select an option");
        LoopMenu();
    }

    static void LoopMenu()
    {
        Journal journal = new Journal();
        int inputVariable = -1;
        while (inputVariable != 0)
        {
            Console.WriteLine("0: Quit");
            Console.WriteLine("1: Write New Entry");
            Console.WriteLine("2: Display Journal");
            Console.WriteLine("3: Save Journal");
            Console.WriteLine("4: Load Journal");

            inputVariable = int.Parse(Console.ReadLine());

            switch (inputVariable) 
            {
                case 0:
                    break;
                case 1:
                    journal.AppendEntry(WriteEntry());
                    break;
                case 2:
                    journal.Display();
                    break;
                case 3:
                    journal.SaveJournal();
                    break;
                case 4:
                    journal = LoadJournal();
                    break;

            }
        }
    }

    static Entry WriteEntry() 
    {
        Prompt journalPrompt = new Prompt();
        Entry journalEntry = new Entry();

        journalPrompt._promptList.Add("What was the highlight of your day?");
        journalPrompt._promptList.Add("Do you feel like you accomplished anything significant?");
        journalPrompt._promptList.Add("Is there anything that you wished you did differently today?");
        journalPrompt._promptList.Add("What are your next steps for tomorrow?");
        journalPrompt._promptList.Add("Did you go anywhere? What did you do there?");        

        DateTime theCurrentDate = DateTime.Now;
        journalEntry._entryDateTime = $"Date: {theCurrentDate.ToShortDateString()}";
        journalPrompt._promptIndex = journalPrompt._randomPrompt.Next(5);
        journalEntry._givenPrompt = journalPrompt.GeneratePrompt();
        Console.WriteLine(journalEntry._givenPrompt);
        journalEntry._entryText = Console.ReadLine();
        return journalEntry;
    }

    static Journal LoadJournal()
    {
        Console.WriteLine("Enter a filename to load the journal: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        Journal journal = new Journal();

        foreach (string line in lines)
        {
            Entry entry = new Entry();
            string[] parts = line.Split(";");
            entry._givenPrompt = parts[0];
            entry._entryDateTime = parts[1];
            entry._entryText = parts[2];
            journal._entries.Add(entry);
        }
        
        Console.WriteLine("Success!\n");

        return journal;
    }
}


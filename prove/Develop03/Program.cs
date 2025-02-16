using System;

class Program
{
    static void Main(string[] args)
    {
        MenuLoop();
    }

    static void MenuLoop()
    {
        Reference reference = new Reference("D&C", "9", "7");
        Scripture scripture = new Scripture("Behold, there are many called, but few are chosen. And why are they not chosen?", reference);
        scripture.SplitScripture();
        foreach (string word in scripture.GetScriptureWordList())
        {
            Word nextWord = new Word(word);
            scripture.AppendWord(nextWord);
            scripture.AddToTracker();
        }
        
        while (scripture.GetShownTracker() != -1)
        {
            Console.Clear();
            Console.WriteLine("Words Left:");
            Console.WriteLine(scripture.GetShownTracker());
            Console.WriteLine();
            Console.WriteLine("Press Enter to Hide 3 Words. Type 'Quit' to Exit the Menu: ");
            scripture.Display();
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "")
            {
                scripture.HideRandomWords(3);
            }
            else if (userInput == "quit")
            {
                break;
            }
        }
    }
}
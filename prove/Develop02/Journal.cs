using System.ComponentModel.DataAnnotations;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AppendEntry(Entry e)
    {
        _entries.Add(e);
    }

    public void Display()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
            Console.WriteLine();
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("Enter a filename to save the journal: ");
        string filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in _entries)
                {
                    outputFile.WriteLine($"{e._givenPrompt};{e._entryDateTime};{e._entryText}");
                }
            }
        Console.WriteLine("Success!\n");
    }
}
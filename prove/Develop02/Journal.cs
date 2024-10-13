using System;
using System.Collections.Generic;
using System.IO;

public class JournalEntry
{
    public string Date { get; set; }
    public string Prompt { get; set; }
    public string Entry { get; set; }
}

public class Journal
{
    private List<JournalEntry> journalEntries = new List<JournalEntry>();

    public void WriteEntry()
    {
        List<string> prompts = new List<string> { "What did you learn today?", "How are you feeling?", "What are you grateful for?" };

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];

        Console.WriteLine("Prompt: " + prompt);
        Console.Write("Enter your entry: ");
        string entry = Console.ReadLine();

        JournalEntry newEntry = new JournalEntry
        {
            Date = DateTime.Now.ToString("yyyy-MM-dd"),
            Prompt = prompt,
            Entry = entry
        };

        journalEntries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (journalEntries.Count == 0)
        {
            Console.WriteLine("No entries found.");
            return;
        }

        foreach (JournalEntry entry in journalEntries)
        {
            Console.WriteLine("Date: " + entry.Date);
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Entry: " + entry.Entry);
            Console.WriteLine();
        }
    }

    public void SaveJournal(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in journalEntries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Entry}");
            }
        }
    }

    public void LoadJournal(string filename)
    {
        journalEntries.Clear(); // Clear existing entries before loading

        using (StreamReader reader = new StreamReader(filename))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split('|');

                JournalEntry entry = new JournalEntry
                {
                    Date = parts[0],
                    Prompt = parts[1],
                    Entry = parts[2]
                };

                journalEntries.Add(entry);
            }
        }
    }
}

public class Programe 
{
    static void Main(string[] args) 
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("1. Write Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. Quit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    journal.WriteEntry();
                    break;
                case 2:
                    journal.DisplayEntries();
                    break;
                case 3:
                    Console.Write("Enter filename: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournal(saveFilename);
                    break;
                case 4:
                    Console.Write("Enter filename: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournal(loadFilename);
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
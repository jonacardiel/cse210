using System;
using System.Collections.Generic;
using System.Linq;

class Scripture
{
    public string Reference { get; }
    public string Text { get; }
    public List<int> HiddenWords { get; private set; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
        HiddenWords = new List<int>();
    }

    public Scripture(string reference, string[] verses)
        : this(reference, string.Join("\n", verses))
    {
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(Text.Split().Length);
            while (HiddenWords.Contains(index))
            {
                index = random.Next(Text.Split().Length);
            }
            HiddenWords.Add(index);
        }
    }

    public bool IsCompletelyHidden() => HiddenWords.Count == Text.Split().Length;
}

class ScriptureReference
{
    public string Book { get; }
    public int Chapter { get; }
    public int StartVerse { get; }
    public int EndVerse { get; }

    public ScriptureReference(string reference)
    {
        string[] parts = reference.Split();
        Book = parts[0];
        Chapter = int.Parse(parts[1]);
        StartVerse = int.Parse(parts[2]);
        EndVerse = parts[3] != null ? int.Parse(parts[3]) : StartVerse;
    }

    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }

    public override string ToString() => $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
}

class Word
{
    public int Index { get; }
    public string Text { get; }

    public Word(int index, string text)
    {
        Index = index;
        Text = text;
    }
}

class Program
{
    static void Main()
    {
        Scripture scripture = new Scripture("John 3:16", "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.WriteLine(scripture.Reference);
        Console.WriteLine(scripture.Text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press Enter to continue or 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(1); // Hide one word at a time
            Console.Clear();
            Console.WriteLine(scripture.Reference);
            Console.WriteLine(string.Join(" ", scripture.Text.Split().Select((word, index) => scripture.HiddenWords.Contains(index) ? "_" : word)));
        }
    }
}
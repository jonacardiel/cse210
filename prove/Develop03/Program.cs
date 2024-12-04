class Program
{
    static void Main()
    {
        ScriptureReference sr = new ScriptureReference("John",  3, 16 , 16);
        Scripture scripture = new Scripture(sr, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.");

        Console.WriteLine(scripture.GetScriptureReference());
        Console.WriteLine(scripture.GetText());

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
            Console.WriteLine(scripture.GetScriptureReference());
            //Console.WriteLine(string.Join(" ", scripture.Text.Split().Select((word, index) => scripture.HiddenWords.Contains(index) ? "_" : word)));
            Console.WriteLine(scripture.GetTextHidden());

        }
    }
}

// added scripturereference object
// changed the public methods to access private data
// muted Console.writeline that joined public properties, instead used GetTextHidden to acces the private data (seen in the next line)
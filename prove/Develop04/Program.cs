using System;
using System.Threading;

public abstract class Activity
{
    protected int duration;

    public void Start()
    {
        Console.WriteLine("Activity: " + GetActivityName());
        Console.WriteLine(GetActivityDescription());
        Console.Write("Enter duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Preparing... ");
        Pause(3);
    }

    public void End()
    {
        Console.WriteLine("Well done! You've completed the " + GetActivityName() + " activity.");
        Pause(3);
    }

    protected void Pause(int seconds)
{
    string[] emojis = { "⏳", "⌛", "⏳" };
    int emojiIndex = 0;

    Console.Write("Pausing...");
    for (int i = seconds * 2; i > 0; i -= 2)
    {
        Console.Write(emojis[emojiIndex]);
        Thread.Sleep(seconds*1000); // Sleep for 1 second
        Console.Write("\b"); // Backspace to overwrite the previous emoji
        emojiIndex = (emojiIndex + 1) % emojis.Length;
    }
    Console.WriteLine();
}

    protected abstract string GetActivityName();
    protected abstract string GetActivityDescription();
    public abstract void Execute();
}

public class BreathingActivity : Activity
{
    protected override string GetActivityName() => "Breathing";
    protected override string GetActivityDescription() => "Relax through deep breathing.";

    public override void Execute()
    {
        for (int i = 0; i < duration; i += 2)
        {
            Console.WriteLine("Breathe in...");
            Pause(2);
            Console.WriteLine("Breathe out...");
            Pause(2);
        }
    }
}

public class ReflectionActivity : Activity
{
    protected override string GetActivityName() => "Reflection";
    protected override string GetActivityDescription() => "Reflect on a positive experience.";

    public override void Execute()
    {
        string[] prompts = {
            "Think of a time when you overcame a challenge.",
            "Recall a moment of kindness you experienced.",
            "What are you grateful for today?"
        };

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);
        Pause(5);

        // Add more reflection questions here as needed
    }
}

public class ListingActivity : Activity
{
    protected override string GetActivityName() => "Listing";
    protected override string GetActivityDescription() => "List positive aspects of your life.";

    public override void Execute()
    {
        Console.WriteLine("Start listing. You have " + duration + " seconds.");
        Pause(duration);
    }
}

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Breathing\n2. Reflection\n3. Listing\n4. Exit");
            Console.Write("Choose an activity: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new BreathingActivity().Start();
                    new BreathingActivity().Execute();
                    new BreathingActivity().End();
                    break;
                case 2:
                    new ReflectionActivity().Start();
                    new ReflectionActivity().Execute();
                    new ReflectionActivity().End();
                    break;
                case 3:
                    new ListingActivity().Start();
                    new ListingActivity().Execute();
                    new ListingActivity().End();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
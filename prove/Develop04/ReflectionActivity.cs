public class ReflectionActivity : Activity
{
    private string[] prompts = {
        "Think of a time when you stood up for someone else.",
        
    };

    public ReflectionActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Reflection Activity: Reflect on a positive experience.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

    }

    public override void End()
    {
        Console.WriteLine("You've completed the reflection exercise. Well done!");
    }
}
//Inherits from the Activity class.  
//Overrides the Start() method to:  
//File instructions of reflection task. 
//Pick a random prompt from the list of prompts. 
//Show the prompt to the user. 
//Feed a set of self-reflection questions with pause between each one. 
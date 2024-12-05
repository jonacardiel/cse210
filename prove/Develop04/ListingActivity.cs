public class ListingActivity : Activity
{
    private string[] prompts = {
        "List people you appreciate.",
        
    };

    public ListingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Listing Activity: List positive things.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds");

        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Length)];
        Console.WriteLine(prompt);

        
    }

    public override void End()
    {
        Console.WriteLine("You've completed the listing exercise. Well done!");
    }
}
//Inherits from the Activity class.  
//Overrides the Start() method to:  
//Event the listing exercise output instructions. 
//Reference a random prompt in the list of prompts. 
//Feed the prompt to the user. 
//Ask the user to list objects and count time spent listing. 
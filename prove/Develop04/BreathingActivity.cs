public class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        Console.WriteLine("Breathing Activity: Relax and focus on your breath.");
        Console.WriteLine("Duration: " + durationInSeconds + " seconds");

        for (int i = 0; i < durationInSeconds; i += 5)
        {
            Console.WriteLine("Breathe in...");
            Pause(5);
            Console.WriteLine("Breathe out...");
            Pause(5);
        }
    }

    public override void End()
    {
        Console.WriteLine("You've completed the breathing exercise. Well done!");
    }
}
//Inherits from the Activity class.  
//Overrides the Start() method to:  
//Inform the user on the breathing exercise. 
//Pause between "Breathe in" and "Breathe out" messages with a loop. 
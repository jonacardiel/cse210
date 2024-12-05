class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program!");

        // Display menu and get user choice
        Console.WriteLine("Please select an activity:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");

        // Get user input
        int userChoice = int.Parse(Console.ReadLine());

        // Get duration from user
        Console.Write("Enter duration in seconds: ");
        int duration = int.Parse(Console.ReadLine());

        
        Activity activity;
        switch (userChoice)
        {
            case 1:
                activity = new BreathingActivity(duration);
                break;
            case 2:
                activity = new ReflectionActivity(duration);
                break;
            case 3:
                activity = new ListingActivity(duration);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                return;
        }

        // Start the activity
        activity.Start();
        activity.End();
    }
}
//Invite the user to select an activity in a menu. 
//Produces an instance of activity class selected by user. 
//Starts the active that you have selected with its Start() method. 
//Bursts the activity with the activity’s End() method. 
public abstract class Activity
{
    protected int durationInSeconds;

    public Activity(int duration)
    {
        durationInSeconds = duration;
    }

    public abstract void Start();
    public abstract void End();

    protected void Pause(int seconds)
    {
        // Implement a pause using Thread.Sleep or a timer
        
        Thread.Sleep(seconds * 1000);
    }
}

//durationInSeconds: holds activity time in seconds. 
//Start(): Abstract function to implement by derivable classes in order to start the action. 
//End(): Abstract method to be implemented by derived classes to end the activity. 
//Pause(int seconds): Encrypted function to put the program in pause for some number of seconds. This can be used to break down actions in an activity. 
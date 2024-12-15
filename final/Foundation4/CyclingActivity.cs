public class CyclingActivity : Activity
{
    public double SpeedInMPH { get; set; }

    public override double GetDistance()
    {
        return SpeedInMPH * DurationInMinutes / 60; // Distance in miles
    }

    public override double GetSpeed()
    {
        return SpeedInMPH; // Speed in mph
    }

    public override double GetPace()
    {
        return 60 / SpeedInMPH; // Pace in min/mile
    }
}
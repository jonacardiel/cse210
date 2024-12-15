public class RunningActivity : Activity
{
    public double DistanceInMiles { get; set; }

    public override double GetDistance()
    {
        return DistanceInMiles; // Distance in miles
    }

    public override double GetSpeed()
    {
        return DistanceInMiles / DurationInMinutes * 60; // Speed in mph
    }

    public override double GetPace()
    {
        return DurationInMinutes / DistanceInMiles; // Pace in min/mile
    }
}
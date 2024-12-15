public class SwimmingActivity : Activity
{
    public int NumberOfLaps { get; set; }

    public override double GetDistance()
    {
        return NumberOfLaps * 0.05; // Each lap is 50 meters, converting to km
    }

    public override double GetSpeed()
    {
        return GetDistance() / DurationInMinutes * 60; // Speed in kph
    }

    public override double GetPace()
    {
        return DurationInMinutes / GetDistance(); // Pace in min/km
    }
}

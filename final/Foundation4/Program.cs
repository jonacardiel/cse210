class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new RunningActivity
            {
                Date = new DateTime(2024, 12, 10),
                DurationInMinutes = 30,
                DistanceInMiles = 3.1 // 5K run
            },
            new CyclingActivity
            {
                Date = new DateTime(2024, 12, 11),
                DurationInMinutes = 60,
                SpeedInMPH = 15.5
            },
            new SwimmingActivity
            {
                Date = new DateTime(2024, 12, 12),
                DurationInMinutes = 45,
                NumberOfLaps = 40
            }
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}

public class Activity
{
    public DateTime Date { get; set; }
    public int DurationInMinutes { get; set; }

    public virtual double GetDistance()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSpeed()
    {
        return GetDistance() / DurationInMinutes * 60;
    }

    public virtual double GetPace()
    {
        return DurationInMinutes / GetDistance();
    }

    public string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {GetType().Name} ({DurationInMinutes} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }
}
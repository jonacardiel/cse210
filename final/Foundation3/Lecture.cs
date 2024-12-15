public class Lecture : BaseEvent
{
    public string Speaker ;
    public int Capacity ;

    public string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nSpeaker: {Speaker}\nCapacity: {Capacity}";
    }
}
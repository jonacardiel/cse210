public class Reception : BaseEvent
{
    public string RSVPEmail ;

    public string GetFullDetails()
    {
        return base.GetStandardDetails() + $"\nRSVP Email: {RSVPEmail}";
    }
}
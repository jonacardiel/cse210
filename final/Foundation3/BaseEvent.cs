public class BaseEvent
{
    public string Title ;
    public string Description ;
    public DateTime Date ;
    public TimeSpan Time ;
    public Address Address ;

    public virtual string GetStandardDetails()
    {
        return $"Title: {Title}\nDescription: {Description}\nDate: {Date.ToShortDateString()}\nTime: {Time}\nAddress: {Address}";
    }

    public virtual string GetShortDescription()
    {
        return $"{Title} - {Date.ToShortDateString()} at {Time}";
    }
}
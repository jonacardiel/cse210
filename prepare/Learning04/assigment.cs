public class Assignment
{
    private string StudentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        StudentName = studentName;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{StudentName} - {_topic}";
    }
}
public class Video
{
    public string Title ;
    public string Author ;
    public int LengthInSeconds ;
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public string GetVideoSummary()
    {
        return $"Title: {Title}, Author: {Author}, Length: {LengthInSeconds / 60}:{LengthInSeconds % 60:D2} minutes, Comments: {GetNumberOfComments()}";
    }
}
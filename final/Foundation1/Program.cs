class Program
{
    static void Main(string[] args)
    {
        // Creating video instances
        Video video1 = new Video
        {
            Title = "Learning C#",
            Author = "John Doe",
            LengthInSeconds = 600
        };

        video1.Comments.Add(new Comment { CommenterName = "Alice", CommentText = "Great video!" });
        video1.Comments.Add(new Comment { CommenterName = "Bob", CommentText = "Very informative." });

        Video video2 = new Video
        {
            Title = "Advanced C# Techniques",
            Author = "Jane Smith",
            LengthInSeconds = 900
        };

        video2.Comments.Add(new Comment { CommenterName = "Charlie", CommentText = "Loved the examples." });

        // List of videos
        List<Video> videos = new List<Video> { video1, video2 };

        // Displaying video summaries
        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoSummary());
        }
    }
}

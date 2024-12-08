class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        
        videos.Add(new Video { Title = "Video 1", Author = "Author 1", LengthInSeconds = 120 });
        

        // Add comments to each video
        videos[0].Comments.Add(new Comment { CommenterName = "User 1", CommentText = "Comment 1" });
        

        // Iterate through the list of videos and display information
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.Comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
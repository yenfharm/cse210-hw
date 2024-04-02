// Abstraction
using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName { get; set; }
    public string Text { get; set; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int LengthInSeconds { get; set; }
    private List<Comment> comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string text)
    {
        Comment comment = new Comment(commenterName, text);
        comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length (seconds): {LengthInSeconds}");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        if (comments.Count > 0)
        {
            Console.WriteLine("Comments:");

            foreach (var comment in comments)
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.Text}");
            }
        }

        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        // Create videos
        Video video1 = new Video("How to learn Python", "GgCode", 270);
        Video video2 = new Video("Making a Project with C#", "Youarm", 400);
        Video video3 = new Video("Basic Concepts about Programming", "Meme", 800);

        // Add comments to videos
        video1.AddComment("User1", "Awesome!");
        video1.AddComment("User2", "Thanks a lot");

        video2.AddComment("User3", "Very helpful");
        video2.AddComment("User4", "You're great!");

        video3.AddComment("User5", "I learned a lot!");
        video3.AddComment("User6", "Keep going!");

        // Add videos to the list
        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
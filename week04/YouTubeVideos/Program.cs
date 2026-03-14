using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
         VideoLibrary library = new VideoLibrary();

        Video video1 = new Video("Learning C#", "Alice", 600);
        video1.AddComment(new Comment("John", "Very helpful!"));
        video1.AddComment(new Comment("Mary", "Great explanation."));
        video1.AddComment(new Comment("Peter", "Thanks for sharing."));

        Video video2 = new Video("OOP Concepts", "Bob", 720);
        video2.AddComment(new Comment("Sarah", "Nice lesson."));
        video2.AddComment(new Comment("Tom", "Very clear."));
        video2.AddComment(new Comment("Jane", "Helpful examples."));

        Video video3 = new Video("Encapsulation Explained", "David", 540);
        video3.AddComment(new Comment("Mike", "Excellent."));
        video3.AddComment(new Comment("Anna", "Easy to understand."));
        video3.AddComment(new Comment("Chris", "Thank you!"));

        Video video4 = new Video("C# Constructors", "Emma", 450);
        video4.AddComment(new Comment("Lina", "Good lesson."));
        video4.AddComment(new Comment("Mark", "Simple explanation."));
        video4.AddComment(new Comment("Eva", "Very useful."));

        library.AddVideo(video1);
        library.AddVideo(video2);
        library.AddVideo(video3);
        library.AddVideo(video4);

        foreach (Video video in library.GetVideos())
        {
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetCommentCount()}");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment.GetName()}: {comment.GetText()}");
            }

            Console.WriteLine("--------------------------");
        }
    }
}

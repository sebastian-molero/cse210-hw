using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        Video video1 = new Video("Learning C# for beginners", "Code Developers", 23400);
        video1.AddComment(new Comment("Alice", "This video really helped me understand the basis of C#. Thanks a lot!"));
        video1.AddComment(new Comment("John", "Clear explanations and great examples. Subscribed!"));
        video1.AddComment(new Comment("Sophie", "Perfect for beginners. I finally get how variables and loops work."));

        Video video2 = new Video("How to Make the Perfect Lasagna", "Tasty Kitchen", 1140);
        video2.AddComment(new Comment("Maria", "I tried this recipe last night and my family loved it!"));
        video2.AddComment(new Comment("James", "Simple steps and delicious results. Thank you!"));
        video2.AddComment(new Comment("Luna", "Can you do one for vegetarian lasagna next?"));


        Video video3 = new Video("Relaxing Piano Music for Studying", "Calm Sounds", 86400);
        video3.AddComment(new Comment("Isabella", "This helped me focus while writing my essay."));
        video3.AddComment(new Comment("Noah", "I play this every morning. It really sets a peaceful tone."));
        video3.AddComment(new Comment("Emily", "So calming and beautiful. Thank you for uploading!"));


        video1.DisplayInfo();
        video2.DisplayInfo();
        video3.DisplayInfo();

    }
}
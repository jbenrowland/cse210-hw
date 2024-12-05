using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Exploring the Teton Mountain Range", "Lafaunda", 300);
        Video video2 = new Video("Cooking with Bob Ross", "Bob Ross Official", 600);
        Video video3 = new Video("Tech Reviews: Laptops", "TechTips", 480);

        video1.AddComment(new Comment("John", "Great video!"));
        video1.AddComment(new Comment("Emma", "Loved the scenery."));
        video1.AddComment(new Comment("Dave", "Inspiring content!"));

        video2.AddComment(new Comment("Alice", "Fantastic recipe!"));
        video2.AddComment(new Comment("Tom", "I’ll try this soon."));
        video2.AddComment(new Comment("Joe", "Let Him Cook!"));

        video3.AddComment(new Comment("Mike", "Very informative."));
        video3.AddComment(new Comment("Sophia", "Good breakdown of features."));
        video3.AddComment(new Comment("Liam", "Helpful for my next purchase!"));

        Video[] videos = new Video[3];
        videos[0] = video1;
        videos[1] = video2;
        videos[2] = video3;

        for (int i = 0; i < videos.Length; i++)
        {
            Video video = videos[i];
            Console.WriteLine("Title: " + video.GetTitle());
            Console.WriteLine("Author: " + video.GetAuthor());
            Console.WriteLine("Length: " + video.GetLengthInSeconds() + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetCommentCount());

            Comment[] comments = video.GetComments();
            for (int j = 0; j < comments.Length; j++)
            {
                Console.WriteLine(" - " + comments[j].GetCommenterName() + ": " + comments[j].GetText());
            }
            Console.WriteLine();
        }
    }
}

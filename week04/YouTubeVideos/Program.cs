using System;

class Program
{
    static void Main(string[] args)
    {

        // Create 3-4 videos
        Video video1 = new Video("How to Bake Bread", "KitchenQueen", 600);
        Video video2 = new Video("Nigeria Wildlife", "NatureAfrica", 480);
        Video video3 = new Video("Lagos City Tour", "TravelNaija", 900);

        // Add 3-4 comments to each video
        video1.AddComment(new Comment("Alice", "Great recipe, thanks!"));
        video1.AddComment(new Comment("Bob", "I tried this and it worked."));
        video1.AddComment(new Comment("Cynthia", "Very easy to follow."));

        video2.AddComment(new Comment("Daniel", "Beautiful animals!"));
        video2.AddComment(new Comment("Ejiro", "Nigeria is so rich in wildlife."));
        video2.AddComment(new Comment("Fatima", "Loved this video!"));

        video3.AddComment(new Comment("Grace", "Lagos looks amazing."));
        video3.AddComment(new Comment("Hassan", "Definitely want to visit."));
        video3.AddComment(new Comment("Ifeoma", "Nice tour!"));

        // Put videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display information for each video
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}
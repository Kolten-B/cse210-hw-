using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Video> videos = new List<Video>();

            // Create videos
            Video video1 = new Video("Video 1", "Author 1", 300);
            Video video2 = new Video("Video 2", "Author 2", 600);
            Video video3 = new Video("Video 3", "Author 3", 900);

            // Add comments to videos
            video1.AddComment(new Comment("User1", "Great video!"));
            video1.AddComment(new Comment("User2", "Thanks for sharing."));
            video1.AddComment(new Comment("User3", "Very informative."));

            video2.AddComment(new Comment("User4", "Amazing content!"));
            video2.AddComment(new Comment("User5", "Loved it."));
            video2.AddComment(new Comment("User6", "Keep it up!"));

            video3.AddComment(new Comment("User7", "Fantastic!"));
            video3.AddComment(new Comment("User8", "Superb!"));
            video3.AddComment(new Comment("User9", "Awesome!"));

            // Add videos to list
            videos.Add(video1);
            videos.Add(video2);
            videos.Add(video3);

            // Display videos and their comments
            foreach (var video in videos)
            {
                Console.WriteLine(video);
                foreach (var comment in video.GetComments())
                {
                    Console.WriteLine(comment);
                }
                Console.WriteLine();
            }
        }
    }
}

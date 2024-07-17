using System;
using System.Collections.Generic;

namespace YouTubeTracker
{
    public class Video
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Length { get; private set; } // in seconds
        private List<Comment> comments;

        public Video(string title, string author, int length)
        {
            Title = title;
            Author = author;
            Length = length;
            comments = new List<Comment>();
        }

        public void AddComment(Comment comment)
        {
            comments.Add(comment);
        }

        public int GetNumberOfComments()
        {
            return comments.Count;
        }

        public List<Comment> GetComments()
        {
            return comments;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}, Length: {Length} seconds, Comments: {GetNumberOfComments()}";
        }
    }
}

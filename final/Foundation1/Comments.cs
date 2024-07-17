namespace YouTubeTracker
{
    public class Comment
    {
        public string Author { get; private set; }
        public string Text { get; private set; }

        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Author}: {Text}";
        }
    }
}

class Video
{
    private string _title;
    private string _author;
    private int _lengthSeconds;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthSeconds)
    {
        _title = title;
        _author = author;
        _lengthSeconds = lengthSeconds;
    }

    public void AppendComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void DisplayAllComments()
    {
        foreach (Comment comment in _comments)
        {

            comment.Display();
        }
    }

    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}   Author: {_author}   Length (in seconds): {_lengthSeconds}\n");
        DisplayAllComments();
    }
}
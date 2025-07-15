class Video
{
    private string _title;

    private string _author;

    private int _length;

    private List<Comment> comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void addComment(string name, string text)
    {
        Comment newComment = new Comment(name, text);
        comments.Add(newComment);
    }

    public string displayVideoOnly()
    {
        string newVideo = $"{_title} by {_author} is {_length}seconds long";
        return newVideo;
    }

    public string displayVideoPlusNumberComment()
    {
        string newVideo = $"{_title} by {_author} is {_length}seconds long";
        newVideo += $"and has {comments.Count} Comments";
        return newVideo;
    }

    public string displayVideoPlusComments()
    {
        string newVideo = $"{_title} by {_author} is {_length}seconds long";
        foreach(Comment comment in comments)
        {
            string commenterPlusText = comment.DisplayComment();
            newVideo += $"\n {commenterPlusText}";
        }
        return newVideo;
    }

}
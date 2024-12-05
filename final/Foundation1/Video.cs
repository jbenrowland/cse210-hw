public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private Comment[] _comments;
    private int _commentCount;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new Comment[100];
        _commentCount = 0;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }

    public void AddComment(Comment comment)
    {
        if (_commentCount < _comments.Length)
        {
            _comments[_commentCount] = comment;
            _commentCount++;
        }
    }

    public int GetCommentCount()
    {
        return _commentCount;
    }

    public Comment[] GetComments()
    {
        Comment[] result = new Comment[_commentCount];
        for (int i = 0; i < _commentCount; i++)
        {
            result[i] = _comments[i];
        }
        return result;
    }
}

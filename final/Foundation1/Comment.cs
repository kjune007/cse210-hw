public class Comment
{
    private string _username;
    private string _commentText;

    public Comment()
    {
    }

    public void SetCommentInfo(string username, string comment)
    {
        _username = username;
        _commentText = comment;
    }

    public string GetComment()
    {
        return $" -> Username: {_username} --> Comment: {_commentText}";
    }
}
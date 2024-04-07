using System.Runtime.CompilerServices;
using System.Security.AccessControl;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();
    private int _numberOfComments;

    public Video()
    {
    }

    public void SetVideoInfo(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public string GetVideoInfo()
    {
        return $"Title: {_title}\n -> Author: {_author}\n -> Video Length: {_length} seconds\n -> Comments: {_numberOfComments} ";
    }

    public void AddComments(Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return _comments;
    }

    public void SetNumberOfComments()
    {
        foreach (Comment comment in _comments)
        {
            _numberOfComments++;
        }
    }
}
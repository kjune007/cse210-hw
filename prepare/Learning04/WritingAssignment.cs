public class WritingAssignment:Assignment
{
    private string _title;

    public WritingAssignment()
    {
    }

    public void SetWritingAssignment(string name, string topic,string title)
    {
        base.SetAssignment(name,topic);
        _title = title;
    }

    public void GetWritingInformation()
    {
        base.GetSummary();
        Console.WriteLine($"{_title}");
    }


}
public class MathAssignment:Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment()
    {
    }

    public void SetMathAssignment(string name, string topic, string section, string problems)
    {
        base.SetAssignment(name,topic);
        _textbookSection = section;
        _problems = problems;
    }

    public void GetHomework()
    {
        base.GetSummary();
        Console.WriteLine($"Section: {_textbookSection} Problems: {_problems}");
    }
}
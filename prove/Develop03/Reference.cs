public class Reference
{
    private string _book = "Proverbs";
    private string _chapter = "3";
    private string _verse = "5-6";

    public Reference()
    {
    }
    public string GetReference()
    {
        string text = $"{_book} {_chapter}: {_verse}";
        return text;
    }
}
public class Journal
{
    public List<string> _journalEntries = new List<string>();

    public Journal()
    {
    }

    public void Display()
    {
        for (int j= 0; j<_journalEntries.Count; j++)
        {
            Console.WriteLine($"{_journalEntries.ElementAt(j)}");
        }
    }
    
}
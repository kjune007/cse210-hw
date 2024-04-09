public class Lecture:Event
{
    private string _speaker;
    private int _capacity;

    public Lecture()
    {
    }

    public void SetEvent(string title,string description,string dateTime,Address address,string speaker,int capacity)
    {
        base.SetEvent(title,description,dateTime,address);
        _speaker = speaker;
        _capacity = capacity;

    }

    public void FullDetails()
    {
        string _location = _address.GetAddress();

        Console.WriteLine("");
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
        Console.WriteLine(
            $"Event ------------> {_title}\n"+
            $"Type -------------> Lecture\n"+
            $"Description ------> {_description}\n"+
            $"Time and Date ----> {_dateTime}\n"+
            $"Address ----------> {_location}\n"+
            $"Speaker ----------> {_speaker}\n"+
            $"Capacity ---------> {_capacity}"
        );
        Console.WriteLine();
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
    }

    public void ShortDetails()
    {
        Console.WriteLine("");
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
        Console.WriteLine(
            $"Event ------------> {_title}\n"+
            $"Type -------------> Lecture\n"+
            $"Time and Date ----> {_dateTime}"
        );
        Console.WriteLine();
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
    }
}
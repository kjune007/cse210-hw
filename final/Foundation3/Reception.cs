public class Reception:Event
{
    private string _email;

    public Reception()
    {
    }

    public void SetEvent(string title,string description,string dateTime,Address address,string email)
    {
        base.SetEvent(title,description,dateTime,address);
        _email = email;
    }

    public void FullDetails()
    {
        string _location = _address.GetAddress();

        Console.WriteLine("");
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
        Console.WriteLine(
            $"Event ------------> {_title}\n"+
            $"Type -------------> Reception\n"+
            $"Description ------> {_description}\n"+
            $"Time and Date ----> {_dateTime}\n"+
            $"Address ----------> {_location}\n"+
            $"RSVP -------------> {_email}"
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
            $"Type -------------> Reception\n"+
            $"Time and Date ----> {_dateTime}"
        );
        Console.WriteLine();
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
    }

}
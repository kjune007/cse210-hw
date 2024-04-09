using System.ComponentModel;
using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _description;
    protected string _dateTime;
    protected Address _address = new Address();

    public Event()
    {
    }

    public void SetEvent(string title,string description,string dateTime,Address address)
    {
        _title = title;
        _description = description;
        _dateTime = dateTime;
        _address = address;
    }

    public void StandardDetails()
    {
        string _location = _address.GetAddress();

        Console.WriteLine("");
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
        Console.WriteLine(
            $"Event ------------> {_title}\n"+
            $"Description ------> {_description}\n"+
            $"Time and Date ----> {_dateTime}\n"+
            $"Address ----------> {_location}"
        );
        Console.WriteLine();
        Console.WriteLine("**********************************************************");
        Console.WriteLine();        
    }

}
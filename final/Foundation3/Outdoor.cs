public class Outdoor:Event
{

    private string _weatherDescription;

    public Outdoor()
    {
    }

    public void SetEvent(string title,string description,string dateTime,Address address,string weather)
    {
        base.SetEvent(title,description,dateTime,address);
        _weatherDescription = weather;
    }

    public void FullDetails()
    {
        string _location = _address.GetAddress();

        Console.WriteLine("");
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
        Console.WriteLine(
            $"Event ------------> {_title}\n"+
            $"Type -------------> Outdoor Event\n"+
            $"Description ------> {_description}\n"+
            $"Time and Date ----> {_dateTime}\n"+
            $"Address ----------> {_location}\n"+
            $"Weather ----------> {_weatherDescription}" 
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
            $"Type -------------> Outdoor Event\n"+
            $"Time and Date ----> {_dateTime}"
        );
        Console.WriteLine();
        Console.WriteLine("**********************************************************");
        Console.WriteLine();
    }


}
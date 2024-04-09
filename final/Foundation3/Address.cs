public class Address
{
    private string _numberAndStreet;
    private string _city;
    private string _state;
    private string _country;
    public Address()
    {
    }

    public void SetAddress(string number,string city, string state, string country)
    {
        _numberAndStreet = number;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_numberAndStreet},{_city} {_state},{_country}";
    }

}
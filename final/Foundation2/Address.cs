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
    public bool CheckAddress()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public string GetAddress()
    {
        return $"{_numberAndStreet},\n{_city}, {_state}\n{_country}";
    }

}
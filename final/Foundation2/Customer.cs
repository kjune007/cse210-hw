public class Customer
{
private string _customerName;
private Address _address;
    public Customer()
    {
    }

    public void SetCustomer(string customer1,Address address)
    {
        _customerName = customer1;
        _address = address;
    }
    public bool CheckAddress()
    {
        bool _country = _address.CheckAddress();
        return _country;
    }

    public string GetCustomer()
    {
        string customerName = _customerName;
        return customerName;
    }

    public Address GetAddress()
    {
        return _address;
    }
}

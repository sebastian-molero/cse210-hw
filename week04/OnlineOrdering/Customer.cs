public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool LivesInUSA()
    {
        return _address.isInUSA();
    }

    public string GetName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.DisplayAddress();
    }
}
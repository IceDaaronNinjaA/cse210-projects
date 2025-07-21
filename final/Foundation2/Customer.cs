class Customer
{
    private string _name;

    private Address _address;

    public Customer(string name, string street, string city, string state, string country)
    {
        _name = name;
        Address newAddress = new Address(street, city, state, country);
        _address = newAddress;
    }

    public bool USA()
    {
        return _address.USA();
    }

    public string returnAddress()
    {
        return _address.returnAddress();

    }
    public string returnCustomerInfo()
    {
        return $"{_name}  {_address.returnAddress()}";

    }
    public string GetName()
    {
        return _name;
    }
}
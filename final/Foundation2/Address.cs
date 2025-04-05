class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _isUSA;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _isUSA = false;
    }

    public void SetIsUSA()
    {
        if (_country == "USA")
        {
            _isUSA = true;
        }
    }

    public bool GetIsUSA()
    {
        return _isUSA;
    }

    public void Display()
    {
        Console.WriteLine($"Street Address: {_streetAddress}\n{_city}, {_stateProvince}, {_country}\n");
    }


}